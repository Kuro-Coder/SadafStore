using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.Order
{
    public class DisCount
    {
        [Key]
        public int DiscountId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DisCountCode { get; set; }
        [Required]
        public int DisCountPercent { get; set; }
        public int? UsableCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
