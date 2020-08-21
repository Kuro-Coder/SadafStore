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
    public class UnDeleteUserModel : PageModel
    {
        private IUserService _userService;

        public UnDeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserPanelViewModel.InformationUserViewModel InformationUserViewModel { get; set; }

        public void OnGet(int userId)
        {
            InformationUserViewModel = _userService.GetUserInformationInAdminPanel(userId);
            ViewData["UserId"] = userId;
        }

        public IActionResult OnPost(int id)
        {
            _userService.UnDeleteUser(id);
            return RedirectToPage("DeleteUserList");
        }
    }
}
