using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.API.Controllers
{
    //localhost:5000/api/Categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet] //default olmasına rağmen Swagger istediği için belirtmemiz gerekiyor.
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await _categoryManager.GetAllAsync();
            return null;
        }
    }
}
