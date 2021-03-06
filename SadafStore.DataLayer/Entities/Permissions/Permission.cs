﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SadafStore.DataLayer.Entities.Permissions
{
    public class Permission
    {
        public Permission()
        {
            
        }

        [Key]
        public int PermissionId { get; set; }

        [Display(Name = "نام دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string PermissionTitle { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public List<Permission> Permissions { get; set; }

        //Relations
        public List<RolePermission> RolePermissions { get; set; }

    }
}
