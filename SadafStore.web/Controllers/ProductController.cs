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

        public IActionResult Index(int pageId = 1, string filter = "", string orderBy = "", int take = 0, List<int> selectedGroups = null)
        {
            ViewBag.pageId = pageId;
            ViewBag.Groups = _productService.GetAllGroups();
            ViewBag.SelectedGroups = selectedGroups;
            return View(_productService.GetProductsList(pageId, filter, orderBy, 4 , selectedGroups));
        }

        [Route("ShowProduct/{id}")]
        public IActionResult ShowProduct(int id, bool finaly = false)
        {

            var product = _productService.GetProductForShow(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Finaly = finaly;
            return View(product);
        }

        [Authorize]
        public ActionResult BuyProduct(int id)
        {
            int orderId = _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }

    }
}
