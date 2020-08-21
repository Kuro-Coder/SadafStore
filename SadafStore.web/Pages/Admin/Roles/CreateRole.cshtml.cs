﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.User;

namespace SadafStore.Web.Pages.Admin.Roles
{
    public class CreateRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public CreateRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty] public Role Role { get; set; }

        public void OnGet()
        {
            ViewData["Permissions"] = _permissionService.GetAllPermission();
        }

        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();

            Role.IsDelete = false;
            int roleId = _permissionService.AddRole(Role);

            #region Permission

            _permissionService.AddPermissionsToRole(roleId, SelectedPermission);

            #endregion

            return RedirectToPage("Index");
        }
    }
}