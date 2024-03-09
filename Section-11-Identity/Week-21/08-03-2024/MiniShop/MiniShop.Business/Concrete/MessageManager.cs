using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;

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

        public async Task<Response<MessageViewModel>> CreateAsync(MessageViewModel messageViewModel)
        {
            var createdMessage = await _messageRepository.CreateAsync(_mapper.Map<Message>(messageViewModel));
            if (createdMessage == null)
            {
                return Response<MessageViewModel>.Fail("Mesaj oluşturulamadı");
            }
            var message = _mapper.Map<MessageViewModel>(createdMessage);
            return Response<MessageViewModel>.Success(message);

        }

        public async Task<Response<List<MessageViewModel>>> GetAllSentMessagesAsync(string userId)
        {
            var messageList = await _messageRepository.GetAllAsync(x => x.SendFromId == userId);
            if (messageList == null)
            {
                return Response<List<MessageViewModel>>.Fail("Mesaj kutusu boş");
            }
            var messageViewModelList = _mapper.Map<List<MessageViewModel>>(messageList);
            return Response<List<MessageViewModel>>.Success(messageViewModelList);
        }
        public async Task<Response<List<MessageViewModel>>> GetAllReceivedMessagesAsync(string userId, bool isRead)
        {
            var messageList = await _messageRepository.GetAllAsync(x => x.SendToId == userId && x.IsRead == isRead);
            if (messageList == null)
            {
                var errorMessage = !isRead ? "Okunmamış mesaj bulunamadı" : "Okunmuş mesaj bulunamadı";
                return Response<List<MessageViewModel>>.Fail($"{errorMessage}");
            }
            messageList = messageList.OrderByDescending(x => x.SendDate).ToList();
            var messageViewModelList = _mapper.Map<List<MessageViewModel>>(messageList);
            return Response<List<MessageViewModel>>.Success(messageViewModelList);
        }
        public async Task<Response<MessageViewModel>> GetByIdAsync(int id)
        {
            var message = await _messageRepository.GetByIdAsync(x => x.Id == id);
            if (message == null)
            {
                return Response<MessageViewModel>.Fail("Mesaj bulunamadı");
            }
            var messageViewModel = _mapper.Map<MessageViewModel>(message);
            return Response<MessageViewModel>.Success(messageViewModel);
        }

        public async Task<Response<int>> GetMessageCountAsync(string toUserId, bool isRead = false)
        {
            var messageCount = await _messageRepository.GetCount(x => x.SendToId == toUserId && x.IsRead == isRead);
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

        public async Task<Response<NoContent>> MarkAsReadAsync(int id)
        {
            var message = await _messageRepository.GetByIdAsync(x => x.Id == id);
            message.IsRead = true;
            await _messageRepository.UpdateAsync(message);
            return Response<NoContent>.Success();
        }

        public async Task<Response<List<MessageViewModel>>> GetAllReceivedMessagesAsync(string toUserId)
        {
            var messageList = await _messageRepository.GetAllAsync(x => x.SendToId == toUserId);
            if (messageList.Count == 0)
            {
                var errorMessage = "Hiç mesajını bulunmamaktadır.";
                return Response<List<MessageViewModel>>.Fail($"{errorMessage}");
            }
            messageList = messageList.OrderByDescending(x => x.SendDate).ToList();
            var messageViewModelList = _mapper.Map<List<MessageViewModel>>(messageList);
            return Response<List<MessageViewModel>>.Success(messageViewModelList);
        }
    }
}
