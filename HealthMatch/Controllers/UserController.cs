using HealthMatch.Models;
using HealthMatch.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMatch.Controllers
{
    public class UserController : Controller
    {
        private readonly DomainContext _context;

        public UserController(DomainContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var domainContext = _context.Users;
            return View();
        }
        public IActionResult CreateMatch()
        {
            return View();
        }

        public IActionResult ViewMatches()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMatch([Bind("UserId, Zipcode, UrgencyNeed")] User user, 
            string zipcodeInput, string urgentSelect)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var z = zipcodeInput;
            var u = urgentSelect;
            
            using (var context = new DomainContext())
            {
                var query = _context.Clinics
                    .Where(a => a.Zipcode == z && a.IsUrgentOffered == u)
                    .ToList();

                ViewData["Clinics"] = query;
            }

            return View("ViewMatches");
            //return RedirectToAction("ViewMatches");
        }
    }
}
