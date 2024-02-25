using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.ViewModels;
using MiniShop.UI.Helpers;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index(bool id = false)
        {
            var categories = await _categoryManager.GetNonDeletedCategories(id);
            List<CategoryViewModel> categoryList = categories.Data.ToList();
            ViewBag.ShowDeleted = id;
            return View(categoryList);
        }

        //Form sayfasını açacak controller
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            AddCategoryViewModel model = new AddCategoryViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddCategoryViewModel model)
        {
            if (ModelState.IsValid) 
            {
                model.Url = Jobs.GetUrl(model.Name);
                await _categoryManager.CreateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            await _categoryManager.UpdateIsActiveAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id) 
        { 
            var category = await _categoryManager.GetByIdAsync(id);
            CategoryViewModel response = category.Data;
            EditCategoryViewModel model = _mapper.Map<EditCategoryViewModel>(response);
            return View(model);
        }
    }
}
