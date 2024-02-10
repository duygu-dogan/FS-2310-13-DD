using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using MiniShop.UI.Extensions;
using MiniShop.UI.Helpers;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace MiniShop.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryManager;
        private readonly IImageHelper _imageHelper;

        public ProductController(IProductService productManager, IMapper mapper, ICategoryService categoryManager, IImageHelper imageHelper)
        {
            _productManager = productManager;
            _mapper = mapper;
            _categoryManager = categoryManager;
            _imageHelper = imageHelper;
        }

        public async Task<IActionResult> Index(bool id = false)
        {
           Response<List<ProductViewModel>> result = await _productManager.GetAllNonDeletedAsync(id);
            ViewBag.ShowDeleted = id;
            return View(result.Data);
        }

        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var result = await _productManager.UpdateIsHomeAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var result = await _productManager.UpdateIsActiveAsync(id);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryManager.GetActiveCategories();
            AddProductViewModel model = new AddProductViewModel
            {
                Categories = categories.Data
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductViewModel model, IFormFile image)
        {
            if (ModelState.IsValid && model.CategoryIds.Count > 0 && image != null)
            {
                model.ImageUrl = await _imageHelper.UploadImage(image, "products");
                model.Url = Jobs.GetUrl(model.Name);
                await _productManager.CreateAsync(model);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçilmeden ürün kaydı yapılamaz." : null;
            ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Görsel hatalı!" : null;
            var categories = await _categoryManager.GetActiveCategories();
            model.Categories = categories.Data;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productManager.GetProductWithCategoriesAsync(id);
            ProductViewModel response = product.Data;
            EditProductViewModel model = _mapper.Map<EditProductViewModel>(response);
            model.CategoryIds = response.CategoryList.Select(c => c.Id).ToList();
            var categories = await _categoryManager.GetActiveCategories();
            model.Categories = categories?.Data;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductViewModel model, IFormFile image)
        {
            if (ModelState.IsValid && model.CategoryIds.Count > 0)
            {
                if (image != null)
                {
                    model.ImageUrl = await _imageHelper.UploadImage(image, "products");
                }
                model.Url = Jobs.GetUrl(model.Name);
                await _productManager.UpdateAsync(model);
                return RedirectToAction("Index");

            }
            ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Görsel hatalı!" : null;
            ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçilmeden ürün kaydı yapılamaz." : null;
            var categories = await _categoryManager.GetActiveCategories();
            model.Categories = categories.Data;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productManager.GetByIdAsync(id);
            ProductViewModel productViewModel = product.Data;
            DeleteProductViewModel model = _mapper.Map<DeleteProductViewModel>(productViewModel);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            await _productManager.HardDeleteAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> SoftDelete(int id)
        {

            await _productManager.SoftDeleteAsync(id);
            var productViewModel = await _productManager.GetByIdAsync(id);
            return Redirect($"/Admin/Product/Index/{!productViewModel.Data.IsDeleted}");
        }
    }
}
