using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IUserService _userService;

        public ProductController(IProductService productService, IOrderService orderService, IUserService userService)
        {
            _productService = productService;
            _orderService = orderService;
            _userService = userService;
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

        [HttpPost]
        public IActionResult CreateComment(ProductComment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userService.GetUserIdByUserName(User.Identity.Name);

            _productService.AddComment(comment);

            return View("ShowComment", _productService.GetProductComment(comment.ProductId));
        }

        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_productService.GetProductComment(id, pageId));
        }

    }
}
