using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.Product
{
    public class ProductGallery
    {
        public ProductGallery()
        {
            
        }

        [Key]
        public int GalleryId { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "تصویر محصول")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ImageName { get; set; }

        #region Relations

        public Product Product { get; set; }

        #endregion
    }
}
