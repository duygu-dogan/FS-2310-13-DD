using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
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

        public ProductController(IProductService productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(bool id = false)
        {
           Response<List<ProductViewModel>> result = await _productManager.GetAllNonDeletedAsync(id);
            ViewBag.ShowDeleted = id;
            return View(result.Data);
        }

        public async Task<IActionResult> UpdateIsHome(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:7700/products/updateishome/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:7700/products/updateisactive/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }

        //[NonAction]
        //public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        //{
        //    Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/categories");
        //        string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
        //        response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
        //    }
        //    return response.Data;
        //}


        //[HttpGet]
        ////Ürün oluşturma formunu açacak metot, yeni ürün oluşturacak metodu ayrıca yazacağız.
        //public async Task<IActionResult> Create()
        //{

        //    AddProductViewModel model = new AddProductViewModel
        //    {
        //        Categories = await GetCategoriesAsync()
        //    };
        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(AddProductViewModel model, IFormFile image)
        //{
        //    model.Url = Jobs.GetUrl(model.Name);
        //    if (ModelState.IsValid && model.CategoryIds.Count > 0 && image != null)
        //    {
        //        using (var httpClient = new HttpClient())
        //        {
        //            //Görsel yükleme işlemi
        //            using (var stream = image.OpenReadStream())
        //            {
        //                var imageContent = new MultipartFormDataContent();
        //                byte[] bytes = stream.ToByteArray();
        //                imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
        //                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:7700/products/imageupload", imageContent);
        //                string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
        //                if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
        //                {
        //                    model.ImageUrl = httpResponseMessageImageUrl;
        //                    //Product kayıt işlemi
        //                    var serializeModel = JsonSerializer.Serialize(model);
        //                    StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
        //                    var result = await httpClient.PostAsync("http://localhost:7700/products/create", stringContent);
        //                    if (result.IsSuccessStatusCode)
        //                    {
        //                        return RedirectToAction("Index");
        //                    }
        //                }
        //            }

        //        }
        //    }
        //    ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçilmeden ürün kaydı yapılamaz." : null;
        //    ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Görsel hatalı!" : null;
        //    model.Categories = await GetCategoriesAsync();
        //    return View(model);
        //}

        //[NonAction]
        //public async Task<ProductViewModel> GetProductAsync(int id)
        //{
        //    Response<ProductViewModel> response = new Response<ProductViewModel>();
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/products/GetWithCategories/{id}");
        //        string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
        //        response = JsonSerializer.Deserialize<Response<ProductViewModel>>(contentResponseApi);
        //    }
        //    return response.Data;
        //}
        //[NonAction]
        //public async Task<ProductViewModel> GetByIdAsync(int id)
        //{
        //    Response<ProductViewModel> response = new Response<ProductViewModel>();
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/products/{id}");
        //        string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
        //        response = JsonSerializer.Deserialize<Response<ProductViewModel>>(contentResponseApi);
        //    }
        //    return response.Data;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Edit(int id)
        //{
        //    ProductViewModel response = await GetProductAsync(id);
        //    //EditProductViewModel model = new EditProductViewModel
        //    //{
        //    //    Id = response.Data.Id,
        //    //    Name = response.Data.Name,
        //    //    ImageUrl = response.Data.ImageUrl,
        //    //    Url = response.Data.ImageUrl,
        //    //    IsActive = response.Data.IsActive,
        //    //    IsHome = response.Data.IsHome,
        //    //    Price = response.Data.Price,
        //    //    Properties = response.Data.Properties,
        //    //    CategoryIds = response.Data.Categories.Select(c=>c.Id).ToList(),
        //    //    Categories = await GetCategoriesAsync()
        //    //};
        //    EditProductViewModel model = _mapper.Map<EditProductViewModel>(response);
        //    model.CategoryIds = response.CategoryList.Select(c => c.Id).ToList();
        //    model.Categories = await GetCategoriesAsync();

        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(EditProductViewModel model, IFormFile image)
        //{
        //    model.Url = Jobs.GetUrl(model.Name);
        //    if (ModelState.IsValid && model.CategoryIds.Count > 0)
        //    {
        //        using (var httpClient = new HttpClient())
        //        {
        //            //Görsel yükleme işlemi
        //            using (var stream = image != null ? image.OpenReadStream() : null)
        //            {
        //                if (image != null)
        //                {
        //                    var imageContent = new MultipartFormDataContent();
        //                    byte[] bytes = stream.ToByteArray();
        //                    imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
        //                    HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:7700/products/imageupload", imageContent);
        //                    string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
        //                    if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
        //                    {
        //                        model.ImageUrl = httpResponseMessageImageUrl;
        //                    }
        //                }
        //                //Product kayıt işlemi
        //                var serializeModel = JsonSerializer.Serialize(model);
        //                StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
        //                var result = await httpClient.PutAsync("http://localhost:7700/products/update", stringContent);
        //                if (result.IsSuccessStatusCode)
        //                {
        //                    return RedirectToAction("Index");
        //                }
        //            }
        //        }
        //    }
        //    ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Görsel hatalı!" : null;
        //    ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçilmeden ürün kaydı yapılamaz." : null;
        //    model.Categories = await GetCategoriesAsync();
        //    return View(model);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    ProductViewModel productViewModel = await GetProductAsync(id);
        //    DeleteProductViewModel model = _mapper.Map<DeleteProductViewModel>(productViewModel);
        //    return View(model);
        //}

        //[HttpGet]
        //public async Task<IActionResult> HardDelete(int id)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        var result = await httpClient.DeleteAsync($"http://localhost:7700/products/harddelete/{id}");
        //        if (result.IsSuccessStatusCode)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    return View();
        //}
        //public async Task<IActionResult> SoftDelete(int id)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        var result = await httpClient.DeleteAsync($"http://localhost:7700/products/softdelete/{id}");

        //    }
        //    var productViewModel = await GetByIdAsync(id);
        //    //return RedirectToAction("Index");
        //    //RedirectionToAction'ın farklı kullanımlarını araştır.
        //    //TempData isimli veri taşıma yöntemini araştırın. ViewBag ile temel farkını anlamaya çalışın.
        //    return Redirect($"/Admin/Product/Index/{!productViewModel.IsDeleted}");
        //}
    }
}
