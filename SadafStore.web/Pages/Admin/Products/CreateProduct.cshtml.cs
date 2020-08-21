using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SadafStore.Core.DTOs.ProductViewModels;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.web.Pages.Admin.Products
{
    public class CreateProductModel : PageModel
    {
        private IProductService _productService;

        public CreateProductModel(IProductService productService)
        {
            _productService = productService;
        }
        [BindProperty] public CreateProductViewModel CreateProductViewModel { get; set; }

        public void OnGet()
        {
            ViewData["Groups"] = _productService.GetAllGroups();
        }

        public IActionResult OnPost(List<int> selectedGroups)
        {
            if (!ModelState.IsValid)
                return Page();

            //Add User:
            int productId = _productService.CreateProductsForAdmin(CreateProductViewModel);
            

            //Add Role:
            _productService.AddGroupsToProduct(selectedGroups,productId);

            return Redirect("/Admin/Products");
        }
    }
}
