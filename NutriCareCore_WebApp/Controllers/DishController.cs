using Microsoft.AspNetCore.Mvc;
using NutriCareCore_WebApp.Data;
using NutriCareCore_WebApp.Models;

namespace NutriCareCore_WebApp.Controllers
{
    public class DishController : Controller
    {
        private readonly AppDbContext _db;
        public IEnumerable<Dish> Dishes { get; set; }
        [BindProperty]
        public Dish Dish { get; set; }
        public DishController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var obj_list = _db.Dish.ToList();
            return View(obj_list);
        }

        public IActionResult AddDish()
        {
            var obj_list = _db.Dish.ToList();
            return View(obj_list);
        }
    }
}
