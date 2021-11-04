using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaazMvc.Controllers
{
    public class HomeController1 : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
