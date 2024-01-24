using Microsoft.AspNetCore.Mvc;
using MiniShop.MVC.Areas.Admin.Models;

namespace MiniShop.MVC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
