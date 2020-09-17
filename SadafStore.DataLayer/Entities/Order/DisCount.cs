using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SadafStore.DataLayer.Entities.User;

namespace SadafStore.DataLayer.Entities.Order
{
    public class DisCount
    {
        [Key]
        public int DiscountId { get; set; }
        [Display(Name = "کد تخفیف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(50)]
        public string DisCountCode { get; set; }
        [Display(Name = "مقدار تخفیف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int DisCountPercent { get; set; }
        public int? UsableCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual List<UserDiscountCode> UserDiscountCodes { get; set; }

    }
}
