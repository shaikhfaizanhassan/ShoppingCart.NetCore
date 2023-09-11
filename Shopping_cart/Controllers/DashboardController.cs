using Microsoft.AspNetCore.Mvc;
using Shopping_cart.Models;

namespace Shopping_cart.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ShopDbContext db;

        public DashboardController(ShopDbContext db)

        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin model)
        {
            var login = db.admins.Where(x=>x.Username == model.Username && x.Password==model.Password).FirstOrDefault();
            if (login !=null) 
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                TempData["erorrmsg"] = "Invalid Login";
                return RedirectToAction("Index");
            }
            
        }
        public IActionResult Dashboard() 
        {
            return View();
        }
    }
}
