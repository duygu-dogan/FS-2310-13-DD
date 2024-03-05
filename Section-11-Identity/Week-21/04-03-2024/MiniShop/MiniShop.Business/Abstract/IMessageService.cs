﻿using MiniShop.Shared.ResponseViewModels;
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
        Task<Response<MessageDetailsViewModel>> CreateAsync(MessageDetailsViewModel messageDetailViewModel);
        Task<Response<NoContent>> HardDeleteAsync(int id);
        Task<Response<List<MessageDetailsViewModel>>> GetAllSentMessagesAsync(string userId);
        Task<Response<List<MessageDetailsViewModel>>> GetAllReceivedMessagesAsync(string userId, bool isRead=false);
        Task<Response<MessageDetailsViewModel>> GetByIdAsync(int id);
        Task<Response<int>> GetMessageCount(string userId, bool isRead = false);
    }
}
