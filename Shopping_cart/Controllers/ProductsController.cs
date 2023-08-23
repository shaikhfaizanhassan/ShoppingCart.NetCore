using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shopping_cart.Models;
using Shopping_cart.Models.ImageModel;

namespace Shopping_cart.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopDbContext db;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        public ProductsController(ShopDbContext db, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.db = db;
            this.environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            ViewBag.cat = new SelectList(db.categories, "CId", "CName");
            ViewBag.brand = new SelectList(db.brands, "BId", "BName");

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateImageModel model) 
        {
            if(ModelState.IsValid)
            {
                var path = environment.WebRootPath;
                var filepath = "Content/ProductImage/ " + model.ImagePath.FileName;
                var fullpath = Path.Combine(path, filepath);

                UploadFile(model.ImagePath,fullpath);

                var data = new Product() 
                { 
                PName = model.PName,
                PPrice = model.PPrice,
                PDesc = model.PDesc,
                CategoryID = model.CategoryID,
                BrandID = model.BrandID,
                ImagePath = filepath
                };
                db.Add(data);
                db.SaveChanges();
                return RedirectToAction("AddProduct");
            }
            else
            {
                return View(model);
            }
            
        }

        public IActionResult ViewProduct()
        {
            var getpro = db.products.ToList();
            return View(getpro);
        }

        public void UploadFile(IFormFile file, string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            file.CopyTo(fileStream);
        }

    }
}
