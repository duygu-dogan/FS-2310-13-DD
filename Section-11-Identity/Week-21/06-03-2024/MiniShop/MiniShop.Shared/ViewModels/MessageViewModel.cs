using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiniShop.Shared.ViewModels.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        [DisplayName("Mesaj: ")]
        [Required(ErrorMessage = "Mesaj alanı boş geçilemez")]
        public string Text { get; set; }
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

    }
}
