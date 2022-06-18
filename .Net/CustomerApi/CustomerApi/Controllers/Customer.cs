using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
