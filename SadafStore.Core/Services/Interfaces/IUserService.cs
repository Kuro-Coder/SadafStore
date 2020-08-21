using System;
using System.Collections.Generic;
using System.Text;
using SadafStore.Core.DTOs;
using SadafStore.DataLayer.Entities.User;
using SadafStore.DataLayer.Entities.Wallet;

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
        User GetUserById(int userId);
        User GetUserByUserName(string username);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);
        void DeleteUser(int userId);
        void UnDeleteUser(int userId);

        #endregion

        #region User Panel

        UserPanelViewModel.InformationUserViewModel GetUserInformation(string userName);
        UserPanelViewModel.NavBarsUserPanelViewModel GetNavBarUserPanelData(string userName);
        UserPanelViewModel.EditProfileViewModel GetDataForEditProfile(string userName);
        //username id old data and profile is new data to save
        void EditProfile(string username, UserPanelViewModel.EditProfileViewModel profile);
        //check OldPassword For Change
        bool CompareOldPasswordForChange(string oldPassword, string userName);
        //Tack New Password
        void ChangeUserPassword(string userName, string newPassword);

        #endregion

        #region Wallet Services

        //Get UserName and Send Wallet Balance
        int BalanceUserWallet(string userName);
        //Get UserName and Send UserId for Wallet
        int GetUserIdByUserName(string userName);
        //User Wallet Description
        List<WalletViewModel> GetWalletUser(string userName);
        //for how Wallet is charging and how much and pay or not pay
        int ChargeWallet(string userName, int amount, string description, bool isPay = false);
        //Save Wallet
        int AddWallet(Wallet wallet);
        //Get a Wallet By walletId
        Wallet GetWalletByWalletId(int walletId);

        void UpdateWallet(Wallet wallet);

        #endregion

        #region Admin Panel

        UserForUserListViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        UserForUserListViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);
        UserPanelViewModel.InformationUserViewModel GetUserInformationInAdminPanel(int userId);
        #endregion
    }
}
