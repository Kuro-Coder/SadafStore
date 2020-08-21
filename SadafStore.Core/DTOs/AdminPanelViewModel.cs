using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;
using SadafStore.DataLayer.Entities.User;

namespace SadafStore.Core.DTOs
{
    public class UserForUserListViewModel
    {
        public List<User> Users { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

    }

    public class CreateUserViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string Password { get; set; }

        public IFormFile AvatarImg { get; set; }
        
    }

    public class EditUserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        [Display(Name = "ایمیل کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string Password { get; set; }

        public List<int> UserRoles { get; set; }

        public IFormFile AvatarImg { get; set; }

        public string ImageName { get; set; }

        [Display(Name = "وضعیت کاربر")]
        public bool IsActive { get; set; }
    }
}
