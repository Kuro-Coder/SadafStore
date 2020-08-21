using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.DTOs;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.Web.Pages.Admin.Users
{
    public class EditUserModel : PageModel
    {
        #region Injection and CTOR

        private IUserService _userService;
        private IPermissionService _permissionService;

        public EditUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        #endregion

        #region BindProperty

        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }

        #endregion

        #region OnGet

        public void OnGet(int id)
        {
            EditUserViewModel = _userService.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        #endregion

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (ModelState.IsValid)
            {
                return Page();
            }
            //Edit User
            _userService.EditUserFromAdmin(EditUserViewModel);
            //Edit Roles
            _permissionService.EditRolesUser(EditUserViewModel.UserId, SelectedRoles);

            return RedirectToPage("Index");
        }
    }
}