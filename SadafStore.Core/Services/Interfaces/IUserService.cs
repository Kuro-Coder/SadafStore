﻿using System;
using System.Collections.Generic;
using System.Text;
using SadafStore.Core.DTOs;
using SadafStore.DataLayer.Entities.User;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IUserService
    {
        #region Account InterFaces

        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activeCode);
        User GetUserByUserName(string username);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);

        #endregion

        #region User Panel

        UserPanelViewModel.InformationUserViewModel GetUserInformation(string userName);

        #endregion
    }
}
