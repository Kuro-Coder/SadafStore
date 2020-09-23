using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.Product
{
    public class ProductComment
    {
        [Key]
        public int CommentId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        [MaxLength(700)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAdminRead { get; set; }


        public Product Product { get; set; }
        public User.User User { get; set; }

    }
}
