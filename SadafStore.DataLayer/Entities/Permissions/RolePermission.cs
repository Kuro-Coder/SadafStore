using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SadafStore.DataLayer.Entities.User;

namespace SadafStore.DataLayer.Entities.Permissions
{
    public class RolePermission
    {
        public RolePermission()
        {

        }

        [Key]
        public int RP_Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        //Relations
        public Role Role { get; set; }
        public Permission Permission { get; set; }

    }
}
