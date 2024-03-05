using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMapper _mapper;
        private readonly IMessageRepository _messageRepository;

        public MessageManager(IMapper mapper, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _messageRepository = messageRepository;
        }

        public async Task<Response<MessageDetailsViewModel>> CreateAsync(MessageDetailsViewModel messageDetailViewModel)
        {
            var createdMessage =  await _messageRepository.CreateAsync(_mapper.Map<Message>(messageDetailViewModel));
            if (createdMessage == null)
            {
                return Response<MessageDetailsViewModel>.Fail("Mesaj oluşturulamadı");
            }
            var messageDetailsViewModel = _mapper.Map<MessageDetailsViewModel>(createdMessage);
            return Response<MessageDetailsViewModel>.Success(messageDetailsViewModel);
            
        }

        public async Task<Response<List<MessageDetailsViewModel>>> GetAllSentMessagesAsync(string userId)
        {
            var messageList = await _messageRepository.GetAllAsync(x => x.SendFromId == userId);
            if(messageList == null)
            {
                return Response<List<MessageDetailsViewModel>>.Fail("Mesaj kutusu boş");
            }
            var messageViewModelList = _mapper.Map<List<MessageDetailsViewModel>>(messageList);
            return Response<List<MessageDetailsViewModel>>.Success(messageViewModelList);
        }
        public async Task<Response<List<MessageDetailsViewModel>>> GetAllReceivedMessagesAsync(string userId, bool isRead)
        {
            var messageList = await _messageRepository.GetAllAsync(x => x.SendToId == userId && x.IsRead == isRead);
            if (messageList == null)
            {
                var errorMessage = !isRead ? "Okunmamış mesaj bulunamadı" : "Okunmuş mesaj bulunamadı";
                return Response<List<MessageDetailsViewModel>>.Fail($"{errorMessage}");
            }
            var messageViewModelList = _mapper.Map<List<MessageDetailsViewModel>>(messageList);
            return Response<List<MessageDetailsViewModel>>.Success(messageViewModelList);
        }
        public async Task<Response<MessageDetailsViewModel>> GetByIdAsync(int id)
        {
            var message = await _messageRepository.GetByIdAsync(x => x.Id == id);
            if (message == null)
            {
                return Response<MessageDetailsViewModel>.Fail("Mesaj bulunamadı");
            }
            var messageViewModel = _mapper.Map<MessageDetailsViewModel>(message);
            return Response<MessageDetailsViewModel>.Success(messageViewModel);
        }

        public async Task<Response<int>> GetMessageCount(string userId, bool isRead = false)
        {
            var messageCount = await _messageRepository.GetCount(x => x.SendFromId == userId && x.IsRead == isRead);
            if (messageCount == 0)
            {
                return Response<int>.Fail("Mesaj bulunamadı");
            }
            return Response<int>.Success(messageCount);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var message = await _messageRepository.GetByIdAsync(x => x.Id == id);
            await _messageRepository.HardDeleteAsync(message);
            return Response<NoContent>.Success();
        }
    }
}
