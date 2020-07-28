using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            information.UserName = user.UserName;
            information.Email = user.Email;
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
    }
}
