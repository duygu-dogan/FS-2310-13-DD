using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.ViewComponents
{
    public class MessageNotificationViewComponent:ViewComponent
    {
        private readonly IMessageService _messageManager;
        private readonly UserManager<User> _userManager;

        public MessageNotificationViewComponent(IMessageService messageManager, UserManager<User> userManager)
        {
            _messageManager = messageManager;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
                var userId = _userManager.GetUserId(HttpContext.User);
                var response = await _messageManager.GetMessageCountAsync(userId);
                var messageCount = response.Data;
                return View(messageCount);
        }
    }
}
