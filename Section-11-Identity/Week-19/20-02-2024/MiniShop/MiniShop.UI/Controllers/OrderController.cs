using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IShoppingCartService _shoppingCartManager;
        private IOrderService _orderService;

        public OrderController(UserManager<User> userManager, IShoppingCartService shoppingCartManager, IOrderService orderService)
        {
            _userManager = userManager;
            _shoppingCartManager = shoppingCartManager;
            _orderService = orderService;
        }

        //Login olmuş kullanıcının geçmiş siparişlerini gösterecek
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            
            OrderViewModel orderViewModel = new OrderViewModel
            {
                FirstName = user.FirstName, LastName = user.LastName, Address = user.Address, Email=user.Email, City= user.City, PhoneNumber = user.PhoneNumber, Note = "Lütfen hızlı gelsin.",
            };
            orderViewModel.ShoppingCart = shoppingCart.Data;
            return View();
        }
    }
}
