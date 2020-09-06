using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.Order
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required] public int UserId { get; set; }
        public bool IsFinaly { get; set; }
        [Required] public int OrderSum { get; set; }
        [Required] public DateTime CreateTime { get; set; }

        #region Relations

        public virtual User.User User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
