using Cametto.Data;
using Cametto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cametto.Controllers
{
    public class FoodController : Controller
    {
        private ApplicationDbContext _context;

        public FoodController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var foodlist = _context.FoodItems.Select(x => new FoodItem()
            {
                Id = x.Id,
                Image = x.Image,
                Item = x.Item,
                price = x.price,
                RestrurantId = x.RestrurantId,
            }).ToList();

            return View(foodlist);
        }
    }
}
