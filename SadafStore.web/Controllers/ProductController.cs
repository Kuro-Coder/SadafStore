using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private IOrderService _orderService;

        public ProductController(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }

        public IActionResult Index(int pageId = 1, string filter = "", string orderBy = "",
            int startPrice = 0, int endPrice = 0, int take = 0, List<int> selectedGroups = null)
        {
            ViewBag.pageId = pageId;
            ViewBag.Groups = _productService.GetAllGroups();
            ViewBag.SelectedGroups = selectedGroups;
            return View(_productService.GetProductsList(pageId, filter, orderBy, startPrice, endPrice, 4, selectedGroups));
        }

        [Route("ShowProduct/{id}")]
        public IActionResult ShowProduct(int id)
        {
            var product = _productService.GetProductForShow(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [Authorize]
        public IActionResult BuyProduct(int id)
        {
            _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/ShowProduct/" + id);
        }

    }
}
