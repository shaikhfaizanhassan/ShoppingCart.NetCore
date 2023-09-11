using Microsoft.AspNetCore.Mvc;
using Shopping_cart.Models;

namespace Shopping_cart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext db;

        public HomeController(ShopDbContext db)

        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var getpro = db.products.ToList();
            return View(getpro);
        }
    }
}
