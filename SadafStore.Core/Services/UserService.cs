using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using SadafStore.Core.CodeGenerator;
using SadafStore.Core.Convertors;
using SadafStore.Core.DTOs;
using SadafStore.Core.Security;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Context;
using SadafStore.DataLayer.Entities.User;

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
            information.Wallet = 0;
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

            var user = GetUserByUserName(username);
            user.UserName = profile.UserName;
            user.AvatarName = profile.AvatarName;
            user.AvatarAddress = profile.AvatarAddress;
            user.AvatarPhone = profile.AvatarPhone;
            user.AvatarImg = profile.ImageName;

            UpdateUser(user);
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
    }
}
