using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SadafStore.DataLayer.Entities.Order;

namespace SadafStore.DataLayer.Entities.User
{
    public class UserDiscountCode
    {
        [Key]
        public int UD_Id { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }


        public User User { get; set; }
        public DisCount DisCount { get; set; }


    }
}
