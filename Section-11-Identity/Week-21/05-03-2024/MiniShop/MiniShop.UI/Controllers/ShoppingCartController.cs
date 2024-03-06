using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IShoppingCartService _shoppingCartManager;
        private readonly IShoppingCartItemService _shoppingCartItemManager;

        public ShoppingCartController(UserManager<User> userManager, IShoppingCartService shoppingCartManager, IShoppingCartItemService shoppingCartItemManager)
        {
            _userManager = userManager;
            _shoppingCartManager = shoppingCartManager;
            _shoppingCartItemManager = shoppingCartItemManager;
        }

        //Kullanıcının sepetini gösterecek
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            return View(shoppingCart.Data);
        }
        [Authorize]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            var userId = _userManager.GetUserId(User);
            await _shoppingCartManager.AddToCartAsync(userId, productId, quantity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int itemId, int quantity)
        {
            await _shoppingCartItemManager.ChangeQuantityAsync(itemId, quantity);
            var result = await _shoppingCartItemManager.GetShoppingCartItemAsync(itemId);
            var itemTotalPrice = $"{(quantity * result.ProductPrice):C0}";
            var userId = _userManager.GetUserId(User);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            var cartTotalPrice = $"{shoppingCart.Data.TotalPrice():C0}";
            var subTotal = $"{(shoppingCart.Data.TotalPrice() / 1.2m):C0}";
            var response = new { itemPrice= itemTotalPrice, cartTotal= cartTotalPrice, cartSubTotal = subTotal };
            return Json(response);
        }
        public async Task ClearFromShoppingCart(int id)
        {
            await _shoppingCartItemManager.ClearShoppingCartAsync(id);
        }
        public async Task<IActionResult> DeleteFromShoppingCart(int id)
        {
            if (ModelState.IsValid)
            {
                await _shoppingCartItemManager.DeleteFromShoppingCartAsync(id);
            }
            return RedirectToAction("Index");
        }
    }
}
