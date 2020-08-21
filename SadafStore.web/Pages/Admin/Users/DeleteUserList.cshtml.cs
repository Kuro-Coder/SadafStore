using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.DTOs;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Pages.Admin.Users
{
    public class DeleteUserListModel : PageModel
    {
        private IPermissionService _permissionService;
        private IUserService _userService;

        public DeleteUserListModel(IPermissionService permissionService, IUserService userService)
        {
            _permissionService = permissionService;
            _userService = userService;
        }

        public UserForUserListViewModel UserForUserListViewModel { get; set; }

        public void OnGet(int pageId = 1, string filterUserName = "", string filterEmail = "")
        {
            UserForUserListViewModel = _userService.GetDeleteUsers(pageId, filterEmail, filterUserName);
        }
    }
}
