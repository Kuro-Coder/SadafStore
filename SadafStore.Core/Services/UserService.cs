using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SadafStore.Core.CodeGenerator;
using SadafStore.Core.Convertors;
using SadafStore.Core.DTOs;
using SadafStore.Core.Security;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Context;
using SadafStore.DataLayer.Entities.User;
using SadafStore.DataLayer.Entities.Wallet;

namespace SadafStore.Core.Services
{
    public class UserService : IUserService
    {
        private SadafStoreContext _context;
        public UserService(SadafStoreContext context)
        {
            _context = context;
        }

        #region User Register/Login Account

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedTexts.FixEmails(login.Email);
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == hashPassword);
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActiveCode = GeneratorCode.GenerateGuidCode();
            _context.SaveChanges();
            return true;
        }

        #endregion

        #region User Panel

        public User GetUserByUserName(string userName)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == userName);
        }

        UserPanelViewModel.InformationUserViewModel IUserService.GetUserInformation(string userName)
        {
            var user = GetUserByUserName(userName);
            UserPanelViewModel.InformationUserViewModel information = new UserPanelViewModel.InformationUserViewModel();
            information.Email = user.Email;
            information.AvatarName = user.AvatarName;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(userName);
            information.UserAddress = user.AvatarAddress;
            information.TelNumber = user.AvatarPhone;

            return information;
        }

        #endregion

        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public UserPanelViewModel.NavBarsUserPanelViewModel GetNavBarUserPanelData(string userName)
        {
            return _context.Users.Where(u => u.UserName == userName).Select(u =>
                new UserPanelViewModel.NavBarsUserPanelViewModel()
                {
                    UserNameInNav = u.UserName,
                    UserAvatarInNav = u.AvatarImg
                }).Single();
        }

        public UserPanelViewModel.EditProfileViewModel GetDataForEditProfile(string userName)
        {
            return _context.Users.Where(u => u.UserName == userName).Select(u =>
                new UserPanelViewModel.EditProfileViewModel
                {
                    UserName = u.UserName,
                    AvatarName = u.AvatarName,
                    AvatarPhone = u.AvatarPhone,
                    AvatarAddress = u.AvatarAddress,
                    ImageName = u.AvatarImg
                }).Single();
        }

        public bool CompareOldPasswordForChange(string oldPassword, string userName)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.UserName == userName && u.Password == hashOldPassword);
        }

        public void ChangeUserPassword(string userName, string newPassword)
        {
            var user = GetUserByUserName(userName);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }

        public int BalanceUserWallet(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            // واریز 
            var enter = _context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 1 && w.IsPay)
                .Select(w => w.Amount).ToList();
            //برداشت
            var exit = _context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 2 && w.IsPay)
                .Select(w => w.Amount).ToList();
            return (enter.Sum() - exit.Sum());
        }

        public int GetUserIdByUserName(string userName)
        {
            return _context.Users.Single(u => u.UserName == userName).UserId;
        }

        public List<WalletViewModel> GetWalletUser(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            return _context.Wallets.Where(w => w.IsPay && w.UserId == userId).Select(w => new WalletViewModel()
            {
                Amount = w.Amount,
                TransactionDate = w.CreateDate,
                Description = w.Description,
                PayType = w.TypeId
            })
                .ToList();
        }

        public int ChargeWallet(string userName, int amount, string description, bool isPay = false)
        {
            Wallet wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = description,
                IsPay = isPay,
                TypeId = 1,
                UserId = GetUserIdByUserName(userName)
            };
            return AddWallet(wallet);
        }

        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public Wallet GetWalletByWalletId(int walletId)
        {
            return _context.Wallets.Find(walletId);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }

        public UserForUserListViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users;
            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }
            //Show Paging
            int take = 20;
            int skip = (pageId - 1) * take;
            UserForUserListViewModel list = new UserForUserListViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }

        public void EditProfile(string username, UserPanelViewModel.EditProfileViewModel profile)
        {
            if (profile.AvatarImage != null)
            {
                string imagePath = "";
                if (profile.ImageName != "null.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AvatarsImg", profile.ImageName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }
                profile.ImageName = GeneratorCode.GenerateGuidCode() + Path.GetExtension(profile.AvatarImage.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AvatarsImg", profile.ImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    profile.AvatarImage.CopyTo(stream);
                }
            }
            #region GetData

            var user = GetUserByUserName(username);
            user.UserName = profile.UserName;
            user.AvatarName = profile.AvatarName;
            user.AvatarAddress = profile.AvatarAddress;
            user.AvatarPhone = profile.AvatarPhone;
            user.AvatarImg = profile.ImageName;

            #endregion
            UpdateUser(user);
        }

        public int AddUserFromAdmin(CreateUserViewModel user)
        {
            #region GetData

            User addUser = new User();
            addUser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            addUser.ActiveCode = GeneratorCode.GenerateGuidCode();
            addUser.Email = user.Email;
            addUser.IsActive = true;
            addUser.RegisterDate = DateTime.Now;
            addUser.UserName = user.UserName;

            #endregion
            #region Save Avatar

            if (user.AvatarImg != null)
            {
                string imagePath = "";
                addUser.AvatarImg = GeneratorCode.GenerateGuidCode() + Path.GetExtension(user.AvatarImg.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AvatarsImg", addUser.AvatarImg);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    user.AvatarImg.CopyTo(stream);
                }
            }
            else
            {
                addUser.AvatarImg = "null.jpg";
            }

            #endregion
            return AddUser(addUser);
        }

        public EditUserViewModel GetUserForShowInEditMode(int userId)
        {
            return _context.Users.Where(u => u.UserId == userId)
                .Select(u => new EditUserViewModel()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Email = u.Email,
                    ImageName = u.AvatarImg,
                    IsActive = u.IsActive,
                    UserRoles = u.UserRoles.Select(r => r.RoleId).ToList()
                }).Single();
        }

        public void EditUserFromAdmin(EditUserViewModel editUser)
        {
            User user = GetUserById(editUser.UserId);
            user.Email = editUser.Email;
            user.IsActive = editUser.IsActive;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }

            if (editUser.AvatarImg != null)
            {
                //Delete old Image
                if (editUser.ImageName != "null.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AvatarsImg",
                        editUser.ImageName);
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }

                //Save New Image
                user.AvatarImg = GeneratorCode.GenerateGuidCode() + Path.GetExtension(editUser.AvatarImg.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AvatarsImg", user.AvatarImg);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editUser.AvatarImg.CopyTo(stream);
                }
            }
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public UserForUserListViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users.IgnoreQueryFilters().Where(u => u.IsDelete);
            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }
            //Show Paging
            int take = 20;
            int skip = (pageId - 1) * take;
            UserForUserListViewModel list = new UserForUserListViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }

        public void DeleteUser(int userId)
        {
            User user = GetUserById(userId);
            user.IsDelete = true;
            user.IsActive = false;
            UpdateUser(user);
        }

        public void UnDeleteUser(int userId)
        {
            User user = GetUserById(userId);
            user.IsDelete = false;
            user.IsActive = true;
            UpdateUser(user);
        }

        public UserPanelViewModel.InformationUserViewModel GetUserInformationInAdminPanel(int userId)
        {
            var user = GetUserById(userId);
            UserPanelViewModel.InformationUserViewModel information = new UserPanelViewModel.InformationUserViewModel();
            information.Email = user.Email;
            information.AvatarName = user.AvatarName;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(user.UserName);
            information.UserAddress = user.AvatarAddress;
            information.TelNumber = user.AvatarPhone;
            information.UserName = user.UserName;

            return information;
        }
    }
}
