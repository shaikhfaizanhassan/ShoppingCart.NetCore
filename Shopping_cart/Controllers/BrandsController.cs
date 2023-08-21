using Microsoft.AspNetCore.Mvc;
using Shopping_cart.Models;

namespace Shopping_cart.Controllers
{
    public class BrandsController : Controller
    {
        private readonly ShopDbContext db;

        public BrandsController(ShopDbContext db)

        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBrand(Brand model)
        {
            var brand = new Brand()
            {
                BName = model.BName
            };
            db.brands.Add(brand);
            db.SaveChanges();
            return RedirectToAction("AddBrand");
            
        }

        public IActionResult ViewBrand()
        {
            var getbrnad = db.brands.ToList();
            return View(getbrnad);
        }
    }
}
