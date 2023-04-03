using HealthMatch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMatch.Controllers
{
    public class OutputController : Controller
    {
        private readonly DomainContext _context;

        public OutputController(DomainContext context)
        {
            _context = context;
        }

        public IActionResult Index(string zipcode, string urgentSelect)
        {
            ;

            return View();
        }
    }
}
