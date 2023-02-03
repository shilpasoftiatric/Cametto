using Cametto.Data;
using Cametto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cametto.Controllers
{
    public class RegisterController : Controller
    {
        private ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Registrations.ToList());
        }
        public IActionResult Register()
        {



            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Registration registration)
        {
            if (ModelState.IsValid)
            {

                _context.Registrations.Add(registration);
                _context.SaveChanges();


                return RedirectToAction("Index", new { message = "Data inserted successfully" });
            }


            return View(registration);
        }
    }
}
