﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.DataLayer.Entities.User
{
    public class User
    {
        public User()
        {

        }

        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد!!!")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string Password { get; set; }

        [Display(Name = "کد فعال سازی")]
        [MaxLength(50)]
        public string ActiveCode { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        public bool IsDelete { get; set; }

        #region User Avatar

        [Display(Name = "تصویرکاربری شما")]
        [MaxLength(50)]
        public string AvatarImg { get; set; }

        [Display(Name = "نام واقعی شما")]
        public string AvatarName { get; set; }

        [Display(Name = "شماره تماس با شما")]
        public string AvatarPhone { get; set; }

        [Display(Name = "آدرس شما")]
        public string AvatarAddress { get; set; }

        #endregion

        #region Relations
        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<Wallet.Wallet> Wallets { get; set; }
        public virtual List<Order.Order> Orders { get; set; }
        public virtual List<UserDiscountCode> UserDiscountCodes { get; set; }
        public virtual List<ProductComment> ProductComments { get; set; }


        #endregion
    }
}
