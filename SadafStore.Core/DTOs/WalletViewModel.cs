using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.Core.DTOs
{
    public class ChargeWalletViewModel
    {
        [Display(Name = "مبلغ واریزی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int Amount { get; set; }
    }

    public class WalletViewModel
    {
        public int Amount { get; set; }
        public int PayType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }

    }
}
