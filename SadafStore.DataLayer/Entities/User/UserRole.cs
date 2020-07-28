using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.User
{
    public class UserRole
    {
        [Key]
        public int UR_Id { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }


        #region Navigations And Ctors

        public UserRole()
        {

        }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        #endregion
    }
}
