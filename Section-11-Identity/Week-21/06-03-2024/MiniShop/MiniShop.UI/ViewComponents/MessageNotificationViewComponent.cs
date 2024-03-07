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

        public async Task<IViewComponentResult> InvokeAsync(string userName)
        {
            if(userName != null)
            {
                var user = await _userManager.FindByNameAsync(userName);
                var userId = await _userManager.GetUserIdAsync(user);
                var response = await _messageManager.GetMessageCountAsync(userId);
                var messageCount = response.Data;
                return View(messageCount);
            }
            return View(0);
        }
    }
}
