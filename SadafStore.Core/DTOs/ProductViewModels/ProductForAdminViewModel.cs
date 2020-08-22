using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.Core.DTOs.ProductViewModels
{
    public class CreateProductViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductName { get; set; }

        [Display(Name = "ویژگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(2000, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductFeature { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductPrice { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductNumber { get; set; }

        //[Display(Name = "وضعیت")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        //public bool ProductIsActive { get; set; }

        [Display(Name = "توضیح")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public string ProductDescription { get; set; }

        [Display(Name = "کلمه کلیدی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductTags { get; set; }

        public IFormFile ProductImageName { get; set; }

    }

    public class ProductForProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

    }

}
