using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SadafStore.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
