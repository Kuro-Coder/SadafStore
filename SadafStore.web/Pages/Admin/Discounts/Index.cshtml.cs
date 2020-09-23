using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.Order;

namespace SadafStore.web.Pages.Admin.Discounts
{
    public class IndexModel : PageModel
    {
        private IOrderService _orderService;

        public IndexModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<DisCount> DisCounts { get; set; }

        public void OnGet()
        {
            DisCounts = _orderService.GetAllDiscounts();
        }
    }
}
