using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageManager;
        private readonly UserManager<User> _userManager;
        private readonly INotyfService _notyf;

        public MessageController(IMessageService messageManager, UserManager<User> userManager, INotyfService notyf)
        {
            _messageManager = messageManager;
            _userManager = userManager;
            _notyf = notyf;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var response = await _messageManager.GetAllReceivedMessagesAsync(userId);
            var messages = response.Data ?? new List<MessageViewModel>();
            return View(messages);
        }

        public async Task<IActionResult> NewMessage()
        {
            var userId = _userManager.GetUserId(User);
            var users = await _userManager.Users.Where(x => x.Id != userId).ToListAsync();
            List<SelectListItem> userSelectList = users.Select(x => new SelectListItem
            {
                Text = x.UserName,
                Value = x.Id
            }).ToList();
            MessageViewModel message = new MessageViewModel
            {
                SendFromId = userId,
                UserList = userSelectList
            };
            return View(message);
        }
        [HttpPost]
        public async Task<IActionResult> NewMessage(MessageViewModel model)
        {
            var toUser = await _userManager.FindByIdAsync(model.SendToId);
            model.SendToName = toUser.UserName;
            var fromUser = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            model.SendFromId = fromUser.Id;
            model.SendFromName = fromUser.UserName;

            var result = await _messageManager.CreateAsync(model);
            if(result.IsSucceeded)
            {
                _notyf.Success("Mesajınız başarıyla gönderildi");
            }
            else
            {
                _notyf.Error("Mesajınız gönderilirken bir hata oluştu");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ReadMessage(int id)
        {
            var response = await _messageManager.GetByIdAsync(id);
            var message = response.Data;
            await _messageManager.MarkAsReadAsync(id);
            return View(message);
        }
    }
}
