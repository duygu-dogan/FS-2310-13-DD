using Microsoft.AspNetCore.Mvc;
using MVCFileUploadApp.Core;
using MVCFileUploadApp.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace MVCFileUploadApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UploadImage(IFormFile image) 
        { 
            if (image == null)
            {
                ViewBag.Message = "Resimde bir sorun var, lütfen tekrar deneyiniz.";
                return View("Index");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", image.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }

            ViewBag.Message = "Resim başarıyla yüklendi";
            return View("Index");
        }

        [HttpGet]
        public IActionResult ResimYukle() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResimYukle(IFormFile image)
        {
            var imageUrl = Uploader.UploadImage(image);
            return View();
        }
    }
}
