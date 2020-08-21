using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.ViewComponents
{
    public class ProductGroupComponent : ViewComponent
    {
        private IProductService _productService;

        public ProductGroupComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ProductGroup",_productService.GetAllGroups()));
        }
    }
}
