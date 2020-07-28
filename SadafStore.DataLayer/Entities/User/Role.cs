using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.User
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public int RoleName { get; set; }

        #region Navigations And Ctors

        public Role()
        {

        }

        public virtual List<UserRole> UserRole { get; set; }

        #endregion
    }
}
