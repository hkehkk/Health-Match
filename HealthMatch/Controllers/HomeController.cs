using HealthMatch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMatch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DomainContext context;

        public HomeController(ILogger<HomeController> logger, DomainContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            context.Database.EnsureCreated();
            return View();
        }

        //public IActionResult Begin()
        //{
        //    context.Database.EnsureCreated();
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
