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
    public class DeleteUserModel : PageModel
    {
        private IUserService _userService;

        public DeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserPanelViewModel.InformationUserViewModel InformationUserViewModel { get; set; }

        public void OnGet(int id)
        {
            InformationUserViewModel = _userService.GetUserInformationInAdminPanel(id);
            ViewData["UserId"] = id;
        }

        public IActionResult OnPost(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToPage("Index");
        }
    }
}
