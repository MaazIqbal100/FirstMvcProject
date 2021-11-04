using MaazMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaazMvc.Controllers
{
    public class Booking : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }



        // GET: Booking/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel model)
        {
            return View();
        }

        
    }
}
