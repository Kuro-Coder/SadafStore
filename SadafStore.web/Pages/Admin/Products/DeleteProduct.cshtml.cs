using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.DTOs.ProductViewModels;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.web.Pages.Admin.Products
{
    public class DeleteProductModel : PageModel
    {
        private IProductService _productService;

        public DeleteProductModel(IProductService productService)
        {
            _productService = productService;
        }

        public InformationProductViewModel InformationProductViewModel { get; set; }

        public void OnGet(int id)
        {
            InformationProductViewModel = _productService.GetProductInformationInAdminPanel(id);
            ViewData["ProductId"] = id;
        }

        public IActionResult OnPost(int id)
        {
            _productService.DeleteProduct(id);

            return RedirectToPage("Index");
        }
    }
}
