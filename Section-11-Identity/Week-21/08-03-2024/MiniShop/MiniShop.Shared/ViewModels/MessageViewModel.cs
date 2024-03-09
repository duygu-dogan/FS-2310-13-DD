using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        [DisplayName("Mesaj: ")]
        [Required(ErrorMessage = "Mesaj alanı boş geçilemez")]
        public string Text { get; set; }
        [DisplayName("Yanıt: ")]
        public string Reply { get; set; }
        public string SendToId { get; set; }
        public string SendFromId { get; set; }
        public bool IsRead { get; set; }
        [DisplayName("Gönderim Tarihi: ")]
        public DateTime SendDate { get; set; } = DateTime.Now;

        [DisplayName("Kime: ")]
        public string SendToName { get; set; }
        [DisplayName("Kimden: ")]
        public string SendFromName { get; set; }
        public List<SelectListItem> UserList { get; set; }
        public int RelatedId { get; set; } = 0;

    }
}
