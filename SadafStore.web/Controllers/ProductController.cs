﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int pageId = 1, string filter = "", string orderBy = "data",
            int startPrice = 0, int endPrice = 0, int take = 0, List<int> selectedGroups = null)
        {
            return View(_productService.GetProductsList(pageId, filter, orderBy, startPrice, endPrice, 2, selectedGroups));
        }

    }
}
