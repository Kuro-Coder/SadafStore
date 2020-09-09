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

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(2000, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductShortDescription { get; set; }

        [Display(Name = "توضیح")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public string ProductDescription { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductNewPrice { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductOldPrice { get; set; }

        [Display(Name = "تعداد مانده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductNumber { get; set; }

        [Display(Name = "ویژگی محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(800, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductFeatures { get; set; }

        [Display(Name = "کلمه کلیدی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(400, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductTags { get; set; }

        public IFormFile ProductImageName { get; set; }

    }

    public class ProductForProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

    }

    public class EditProductViewModel
    {
        public int ProductId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductName { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(2000, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductShortDescription { get; set; }

        [Display(Name = "توضیح")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public string ProductDescription { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductNewPrice { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductOldPrice { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        public int ProductNumber { get; set; }

        //[Display(Name = "وضعیت")]
        //public bool ProductIsActive { get; set; }

        public List<int> ProductGroups { get; set; }

        [Display(Name = "ویژگی محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(800, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductFeatures { get; set; }

        [Display(Name = "کلمه کلیدی")]
        [MaxLength(400, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string ProductTags { get; set; }

        public IFormFile ProductImageName { get; set; }
        public string ImageName { get; set; }

    }

    public class InformationProductViewModel
    {
        public string ProductName { get; set; }
        public string ProductShortDescription { get; set; }
        public int ProductOldPrice { get; set; }
        public int ProductNewPrice { get; set; }
        public int ProductNumber { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFeature { get; set; }
        public string ProductTags { get; set; }
        public DateTime DateTime { get; set; }


    }
}
