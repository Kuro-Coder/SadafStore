using System;
using System.Collections.Generic;
using System.Text;
using SadafStore.Core.DTOs;
using SadafStore.DataLayer.Entities.Permissions;
using SadafStore.DataLayer.Entities.User;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Roles

        List<Role> GetRoles();
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);

        #endregion

        #region Permissions

        List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);
        //Permission Checker
        bool CheckPermission(int permissionId, string userName);

        #endregion
    }
}
