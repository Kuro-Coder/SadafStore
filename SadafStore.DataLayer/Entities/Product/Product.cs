﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SadafStore.DataLayer.Entities.Order;

namespace SadafStore.DataLayer.Entities.Product
{
    public class Product
    {
        public Product()
        {

        }

        [Key]
        public int ProductId { get; set; }

        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductTitle { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(2000, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیح کامل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public string Description { get; set; }

        [Display(Name = "قیمت جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int Price { get; set; }

        [Display(Name = "قیمت قدیم")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int OldPrice { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductNumber { get; set; }

        [MaxLength(50)]
        public string ProductImage { get; set; }

        [MaxLength(400)]
        public string Tags { get; set; }

        [MaxLength(800)]
        public string Features { get; set; } 

        public bool IsDelete { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        #region Relations

        public virtual List<ProductSelectedGroup> ProductSelectedGroups { get; set; }
        public virtual List<ProductGallery> ProductGalleries { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<ProductComment> ProductComments { get; set; }

        #endregion
    }
}
