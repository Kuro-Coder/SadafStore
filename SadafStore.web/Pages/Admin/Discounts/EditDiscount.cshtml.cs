using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.Order;

namespace SadafStore.web.Pages.Admin.Discounts
{
    public class EditDiscountModel : PageModel
    {
        private IOrderService _orderService;

        public EditDiscountModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty] public DisCount Discounts { get; set; }
        public void OnGet(int id)
        {
            Discounts = _orderService.GetDisCountById(id);
        }

        public IActionResult OnPost(string stDate = "", string edDate = "")
        {
            if (stDate != "")
            {
                string[] std = stDate.Split('/');
                Discounts.StartDate = new DateTime(int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    new PersianCalendar()
                );
            }

            if (edDate != "")
            {
                string[] edd = edDate.Split('/');
                Discounts.EndDate = new DateTime(int.Parse(edd[0]),
                    int.Parse(edd[1]),
                    int.Parse(edd[2]),
                    new PersianCalendar()
                );
            }

            if (!ModelState.IsValid)
                return Page();

            _orderService.UpdateDiscount(Discounts);

            return RedirectToPage("Index");

        }
    }
}
