using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.DTOs.Order;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class MyOrdersController : Controller
    {
        private IOrderService _orderService;

        public MyOrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetUserOrders(User.Identity.Name));
        }

        public IActionResult ShowOrder(int id)
        {
            var order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult Finaly(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name,id))
            {
                return Redirect("/UserPanel/MyOrders/ShowOrder" + id + "?finaly=true");
            }

            return BadRequest();
        }

        public IActionResult UseDisCount(int orderId, string code)
        {
            DisCountUseType type = _orderService.UseDisCount(orderId, code);
            return Redirect("/UserPanel/MyOrders/ShowOrder/"+orderId+"?type="+type.ToString());
        }
    }
}
