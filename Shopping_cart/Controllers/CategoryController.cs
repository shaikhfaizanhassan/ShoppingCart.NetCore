using Microsoft.AspNetCore.Mvc;
using Shopping_cart.Models;

namespace Shopping_cart.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ShopDbContext db;

        public CategoryController(ShopDbContext db)

        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddCategory(Category model)
        {
            var cat = new Category() 
            { 
            CName = model.CName
            };
            db.categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("AddCategory");
            
        }

        public IActionResult ViewCategory()
        {
		//hello
            var getallcategory = db.categories.ToList();
            return View(getallcategory);
        }
    }
}
