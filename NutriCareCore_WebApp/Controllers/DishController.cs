using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NutriCareCore_WebApp.Data;
using NutriCareCore_WebApp.Models;
using System.Diagnostics.Metrics;

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
            BindEthinicity();
            BindFoodType();
            BindCategory();
            return View();
        }

        public void BindEthinicity()
        {
            //var EName = _db.NSysEthnic.ToList();
            //List<SelectListItem> listhosp = new List<SelectListItem>();

            //foreach (var item in EName)
            //{
            //    listhosp.Add(new SelectListItem
            //    {
            //        Text = item.EthnicName,
            //        Value = item.EthnicID.ToString()
            //    });
            //}

            //ViewBag.Ethnic = listhosp;
            
            var EName = _db.NSysEthnic.ToList();
            EName = (from c in _db.NSysEthnic select c).ToList();
            EName.Insert(0, new NSysEthnic { EthnicID = 0, EthnicName = "--Select Ethnic Name--" });

            List<SelectListItem> listhosp = new List<SelectListItem>();

            foreach (var item in EName)
            {
                listhosp.Add(new SelectListItem
                {
                    Text = item.EthnicName,
                    Value = item.EthnicID.ToString()
                });
            }

            ViewBag.Ethnic = listhosp;
        }
        public void BindFoodType()
        {
            var EName = _db.NSysFoodHabit.ToList();
            EName = (from c in _db.NSysFoodHabit select c).ToList();
            EName.Insert(0, new NSysFoodHabit { FoodHabitID = 0,  FoodHabitName= "--Select Food Type--" });

            List<SelectListItem> listFoodType = new List<SelectListItem>();

            foreach (var item in EName)
            {
                listFoodType.Add(new SelectListItem
                {
                    Text = item.FoodHabitName,
                    Value = item.FoodHabitID.ToString()
                });
            }

            ViewBag.FoodType = listFoodType;

        }
        public void BindCategory()
        {
            var FCName = _db.NSysFoodCategory.ToList();
            FCName = (from c in _db.NSysFoodCategory select c).ToList();
            FCName.Insert(0, new NSysFoodCategory { FoodCategoryID = 0, FoodCategoryName = "--Select Food Category--" });

            List<SelectListItem> listFoodCategory = new List<SelectListItem>();

            foreach (var item in FCName)
            {
                listFoodCategory.Add(new SelectListItem
                {
                    Text = item.FoodCategoryName,
                    Value = item.FoodCategoryID.ToString()
                });
            }

            ViewBag.FoodCategory = listFoodCategory;
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateNewDish()
        //{
        //    Dish Dish = new Dish();
        //    NSysEthnic nSysEthnic = new NSysEthnic();
        //    NSysFoodHabit nSysFoodHabit = new NSysFoodHabit();
        //    NSysFoodCategory nSysFoodCategory = new NSysFoodCategory();

        //    //Dish.DishName = 
            
        //    ////if (ModelState.IsValid)
        //    ////{
        //    ////    await _db.Catogories.AddAsync(Category);
        //    ////    await _db.SaveChangesAsync();

        //    ////    TempData["sucess"] = "Category Created  Successfully !";

        //    ////    return RedirectToAction("Index");
        //    ////}
        //    return View();
        //}
    }
}
