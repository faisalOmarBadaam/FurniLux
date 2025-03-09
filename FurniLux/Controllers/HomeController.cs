using FurniLux.Data;
using FurniLux.Models;
using FurniLux.Tools;
using Microsoft.AspNetCore.Mvc;

namespace FurniLux.Controllers
{
    public class HomeController : Controller
    {

        List<Product> products;
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env)
        {
            products = ProductData.getData();
            _env = env;
        }

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var singleProduct = products.FirstOrDefault(x => x.Id == id);
            if (products == null)
            {
                return RedirectToAction("Index");
            }
            return View(singleProduct);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Product product, IFormFile? image)
        {
            if (ModelState.IsValid)
            {


                await FileTools.CopyPhotoToEnviroment(product, _env, image);
                products.Add(product);
                return RedirectToAction("Index");
            }
            else
                return View(product);

        }

        public ActionResult Edit(int id)
        {
            var exitedProduct = products.FirstOrDefault(x => x.Id == id);
            if (exitedProduct == null)
                return NotFound();
            return View(exitedProduct);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product, IFormFile? image)
        {
            if (ModelState.IsValid)
            {


                var ExitedProdect = products.FirstOrDefault(x => x.Id == id);
                if (ExitedProdect == null)
                    return NotFound();
                if (image != null)
                {
                    if (ExitedProdect.ImageUrl != null)
                    {
                        FileTools.DeletePhoto(_env, ExitedProdect.ImageUrl);
                    }
                    await FileTools.CopyPhotoToEnviroment(product, _env, image);
                }
                ExitedProdect.Name = product.Name ?? ExitedProdect.Name;
                ExitedProdect.StockQuantity = product.StockQuantity;
                ExitedProdect.ImageUrl = product.ImageUrl ?? ExitedProdect.ImageUrl;
                ExitedProdect.Dimensions = product.Dimensions ?? ExitedProdect.Dimensions;
                ExitedProdect.Material = product.Material ?? ExitedProdect.Material;
                ExitedProdect.Color = product.Color ?? ExitedProdect.Color;
                ExitedProdect.Price = product.Price;
                ExitedProdect.Description = product.Description ?? ExitedProdect.Description;
                ExitedProdect.UpdatedAt = DateTime.UtcNow;


                return RedirectToAction("Index");
            }
            else
                return View(product);




        }


        public ActionResult Delete(int id)
        {
            var exited = products.FirstOrDefault(x => x.Id == id);
            if (exited == null)
                return NotFound();
            if (exited.ImageUrl != "")
                FileTools.DeletePhoto(_env, exited.ImageUrl!);
            products.Remove(exited);
            return RedirectToAction("Index");
        }
    }
}
