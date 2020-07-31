using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }
        [Display(Name = "نوع تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int TypeId { get; set; }
        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int UserId { get; set; }
        [Display(Name = "مبلغ تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int Amount { get; set; }
        [Display(Name = "توضح‌ درمورد تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string Description { get; set; }
        [Display(Name = "تایید تراکنش")]
        public bool IsPay { get; set; }
        [Display(Name = "تاریخ تراکنش")]
        public DateTime TransactionDate { get; set; }

        #region Navigations And Ctors

        public Wallet()
        {

        }
        
        public virtual User.User Users { get; set; }
        public virtual WalletType WalletType { get; set; }
        #endregion

    }
}
