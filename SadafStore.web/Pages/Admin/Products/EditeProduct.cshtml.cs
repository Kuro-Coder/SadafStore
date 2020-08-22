using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.DTOs;
using SadafStore.Core.DTOs.ProductViewModels;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Pages.Admin.Products
{
    public class EditeProductModel : PageModel
    {
        private IProductService _productService;

        public EditeProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty] public EditProductViewModel EditProductViewModel { get; set; }

        public void OnGet(int id)
        {
            EditProductViewModel = _productService.GetProductForEdit(id);
            ViewData["Groups"] = _productService.GetAllGroups();
        }
    }
}
