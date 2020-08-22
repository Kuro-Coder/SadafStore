using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.DTOs.ProductViewModels;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Pages.Admin.Products
{
    public class DeleteProductListModel : PageModel
    {
        private IProductService _productService;

        public DeleteProductListModel(IProductService productService)
        {
            _productService = productService;
        }

        public ProductForProductListViewModel ProductForProductListViewModel { get; set; }

        public void OnGet(int pageId = 1, string filterProductTitle = "", string filterTags = "")
        {
            ProductForProductListViewModel = _productService.GetDeleteProducts(pageId, filterTags, filterProductTitle);
        }
    }
}
