using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IMessageService
    {
        Task<Response<MessageViewModel>> CreateAsync(MessageViewModel messageViewModel);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<List<MessageViewModel>>> GetAllSentMessagesAsync(string fromUserId);
        Task<Response<List<MessageViewModel>>> GetAllReceivedMessagesAsync(string toUserId, bool isRead);
        Task<Response<List<MessageViewModel>>> GetAllReceivedMessagesAsync(string toUserId);
        Task<Response<MessageViewModel>> GetByIdAsync(int id);
        Task<Response<int>> GetMessageCountAsync(string toUserId, bool isRead = false);
        Task<Response<NoContent>> MarkAsReadAsync(int id);
    }
}
