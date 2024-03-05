using AspNetCoreHero.ToastNotification.Abstractions;
using AspNetCoreHero.ToastNotification.Notyf;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;
using MiniShop.UI.EmailServices.Abstract;
using Newtonsoft.Json.Linq;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderManager;
        private readonly IEmailSender _emailSender;
        private readonly IShoppingCartService _shoppingCartManager;
        private readonly INotyfService _notyfService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, IShoppingCartService shoppingCartManager, INotyfService notyfService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderManager = orderManager;
            _emailSender = emailSender;
            _shoppingCartManager = shoppingCartManager;
            _notyfService = notyfService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    //EmailConfirmed= true
                };

                var result = await _userManager.CreateAsync(user,registerViewModel.Password);
                if (result.Succeeded)
                {
                    //Mail gönderme işlemi başlıyor
                    //Token oluşturma
                    //var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var backUrl = Url.Action("ConfirmEmail", "Account", new
                    //{
                    //    userId = user.Id,
                    //    token = tokenCode
                    //});
                    //await _emailSender.SendEmailAsync(
                    //    user.Email,
                    //    "MiniShopApp Üyelik Onayı",
                    //    $"<div>MiniShopApp Uygulamasına üyeliğinizi onaylamak için aşağıdaki linke tıklayınız.</div> <br> <a href='https://localhost:59079{backUrl}'>ONAY LİNKİ</a>"
                    //    );

                    //Yukarıdaki kodlar aktif edildiğinde bu kodu yorum satırı yapmalısınız.
                    var shoppingCart = await _shoppingCartManager.InitializeShoppingCartAsync(user.Id);
                    _notyfService.Success("Üyelik işleminiz başarıyla gerçekleşmiştir. Lütfen mailinizi kontrol ederek üyeliğinizi onaylayınız.", 5);
                    return Redirect("~/");

                }

            }

            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl=null)
        {
            if(returnUrl != null)
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user == null)
                {
                    //Olası daha önceden kalan cookie'yi silme işlemi
                    await _signInManager.SignOutAsync();
                    _notyfService.Error("Kullanıcı bulunamadı.");
                    return View(loginViewModel);
                }
                var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
                if (!isConfirmed)
                {
                    _notyfService.Warning("Lütfen mailinizi kontrol ederek üyeliğinizi onaylayınız.");
                }
                //Login olmayı deniyoruz.
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, true);
                var attempts = await _userManager.GetAccessFailedCountAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.ResetAccessFailedCountAsync(user);
                    await _userManager.SetLockoutEndDateAsync(user, null);
                    var returnUrl = TempData["ReturnUrl"]?.ToString();
                    _notyfService.Information("Başarıyla giriş yapıldı. Hoş geldiniz!");
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else if (result.IsLockedOut)
                {
                    //Kilitlenmenin ne zaman biteceğini alıyoruz.
                    var lockoutEndDate = await _userManager.GetLockoutEndDateAsync(user);
                    var timeLeft = (lockoutEndDate.Value - DateTime.Now).Seconds;
                    var attemptCount = _signInManager.Options.Lockout.MaxFailedAccessAttempts;
                    //if (attempts == 0)
                    //{
                    //    _notyfService.Error($"Hesabınız {attemptCount} kez hatalı giriş yaptığınız için, {lockoutEndDate.Value.ToString("f")}'e kadar kilitlendi.");
                    //}
                    //else
                    //{
                        _notyfService.Error($"Hesabınız kilitli. {timeLeft} saniye sonra tekrar deneyiniz.");
                    //}
                    return View(loginViewModel);
                }
                else
                {
                    var attemptCount = _signInManager.Options.Lockout.MaxFailedAccessAttempts;
                    
                    var attemptsLeft = attemptCount -attempts;
                    _notyfService.Information($"Kalan hakkınız {attemptsLeft}");
                    return View(loginViewModel);
                }
            }

            return View(loginViewModel);
            
        }
    
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["ReturnUrl"] = null;
            _notyfService.Information("Başarıyla çıkış yapıldı. Tekrar görüşmek üzere!");
            return Redirect("~/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> Profile()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _orderManager.GetOrdersAsync(userId);
            var user = await _userManager.FindByIdAsync(userId);
            
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel
            {
                User = new UserViewModel
                {
                    Id = userId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    DateOfBirth = user.DateOfBirth,
                    Gender = user.Gender,
                    UserName = user.UserName
                },
                Orders = orders
            };
            return View(userProfileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileViewModel userProfileViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userProfileViewModel.User.Id);
                user.FirstName = userProfileViewModel.User.FirstName;
                user.LastName = userProfileViewModel.User.LastName;
                user.Email = userProfileViewModel.User.Email;
                user.PhoneNumber = userProfileViewModel.User.PhoneNumber;
                user.Address = userProfileViewModel.User.Address;
                user.City = userProfileViewModel.User.City;
                user.DateOfBirth = userProfileViewModel.User.DateOfBirth;
                user.Gender = userProfileViewModel.User.Gender;
                user.UserName = userProfileViewModel.User.UserName;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, false);
                    _notyfService.Success("Profil bilgileriniz başarıyla güncellendi.");
                    return Redirect("~/");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            userProfileViewModel.Orders = await _orderManager.GetOrdersAsync(userProfileViewModel.User.Id);
            return View(userProfileViewModel);
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
                var isVerified = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.OldPassword);
                if (isVerified) 
                {
                    var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
                    if(result.Succeeded) 
                    {
                        var updateSecurityStampResult = await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, changePasswordViewModel.NewPassword, false, false);
                        _notyfService.Success("Şifreniz başarıyla değiştirildi.");
                        return RedirectToAction("Profile");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changePasswordViewModel);
                }
                _notyfService.Error("Eski şifrenizi yanlış girdiniz.");
            }
            return View(changePasswordViewModel);
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                _notyfService.Error("Bilgilerinizde hata var, kontrol ediniz.");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null) 
            { 
                _notyfService.Error("Kullanıcı bilgilerinize ulaşılamadı.");
                return View();
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            //Bu kişi onaylı bir user old. için shopping cart oluşturuyoruz.
            if (result.Succeeded)
            {
                var shoppingCart = await _shoppingCartManager.InitializeShoppingCartAsync(userId);
                _notyfService.Information("Üyeliğiniz başarıyla onaylandı. Hoş geldiniz!");
                return RedirectToAction("Login");
            }
            _notyfService.Error("Üyelik onaylama işlemi başarısız. Lütfen daha sonra tekrar deneyiniz.");
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                _notyfService.Error("Mail adresi boş olamaz.");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                _notyfService.Error("Kullanıcı bulunamadı.");
                return View();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var backUrl = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = token
            });
            var subject = "MiniShopApp Şifre Sıfırlama";
            var htmlMessage = $"<h5>MiniShop Şifre Sıfırlama İşlemi</h5>" +
                    $"<div>MiniShopApp Uygulaması şifrenizi sıfırlamak için aşağıdaki linke tıklayınız.</div> " +
                    $"<br> " +
                    $"<a class='btn btn-primary' href='https://localhost:59079{backUrl}'>ŞİFREMİ SIFIRLA</a>";
            await _emailSender.SendEmailAsync(
                    user.Email, subject, htmlMessage);
            return View();
        }
        public async Task<IActionResult> ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                _notyfService.Error("Bilgilerinizde hata var, kontrol ediniz.");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                _notyfService.Error("Kullanıcı bilgilerinize ulaşılamadı.");
                return View();
            }
            var model = new ResetPasswordViewModel
            {
                Token = token,
                UserId = userId
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userManager.FindByIdAsync(resetPasswordViewModel.UserId);
            if (user == null)
            {
                _notyfService.Error("Kullanıcı bilgilerinize ulaşılamadı.");
                return View(resetPasswordViewModel);
            }
            var result = await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Token, resetPasswordViewModel.Password);
            if (result.Succeeded)
            {
                _notyfService.Success("Şifreniz başarıyla değiştirildi. Yeni şifrenizle giriş yapabilirsiniz.");
                return RedirectToAction("Login");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            
            return View(resetPasswordViewModel);
        }
    }
}
