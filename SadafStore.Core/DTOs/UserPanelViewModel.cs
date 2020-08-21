using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;

namespace SadafStore.Core.DTOs
{
    public class UserPanelViewModel
    {
        public class InformationUserViewModel
        {
            public string Email { get; set; }
            public string AvatarName { get; set; }
            public DateTime RegisterDate { get; set; }
            public int Wallet { get; set; }
            public string UserAddress { get; set; }
            public string TelNumber { get; set; }
            public string UserName { get; set; }

        }

        public class NavBarsUserPanelViewModel
        {
            public string UserAvatarInNav { get; set; }
            public string UserNameInNav { get; set; }
            
        }

        public class EditProfileViewModel
        {
            [Display(Name = "نام کاربری")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string UserName { get; set; }
            public string AvatarName { get; set; }
            public string AvatarPhone { get; set; }
            public string AvatarAddress { get; set; }
            public IFormFile AvatarImage { get; set; }
            public string ImageName { get; set; }

        }

        public class ChangePasswordViewModel 
        {
            [Display(Name = "کلمه عبور فعلی")]
            [Required(ErrorMessage = " => لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string OldPassword { get; set; }
            [Display(Name = "کلمه عبور جدید")]
            [Required(ErrorMessage = " => لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string NewPassword { get; set; }
            [Display(Name = "تکرار کلمه عبور جدید")]
            [Required(ErrorMessage = " => لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            [Compare("NewPassword", ErrorMessage = " => کلمه های عبور جدید مغایرت دارند")]
            public string ReNewPassword { get; set; }

        }
    }
}
