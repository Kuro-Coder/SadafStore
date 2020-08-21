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
    public class CreateUserModel : PageModel
    {
        #region Injection and CTOR

        private IUserService _userService;
        private IPermissionService _permissionService;

        public CreateUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        #endregion

        #region BindProperty

        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }

        #endregion

        #region OnGet

        public void OnGet()
        {
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        #endregion

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
                return Page();
            //Add User:
            int userId = _userService.AddUserFromAdmin(CreateUserViewModel);
            
            //Add Role:
            _permissionService.AddRolesToUser(SelectedRoles, userId);

            return Redirect("/Admin/Users");
        }
    }
}
