﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderManager = orderManager;
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
                    LastName = registerViewModel.LastName
                };

                var result = await _userManager.CreateAsync(user,registerViewModel.Password);
                if (result.Succeeded)
                {
                    //return RedirectToAction("Index","Home");
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
            if(!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı");
                return View(loginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifre hatalı");
                return View(loginViewModel);
            }
            var returnUrl = TempData["ReturnUrl"]?.ToString();
            if(!String.IsNullOrEmpty(returnUrl)) 
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["ReturnUrl"] = null;
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
        public async Task<IActionResult> ChangePassword()
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
                        return RedirectToAction("Profile");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changePasswordViewModel);
                }
                ModelState.AddModelError("", "Girdiğiniz şifre hatalıdır");
            }
            return View(changePasswordViewModel);
        }
    }
}
