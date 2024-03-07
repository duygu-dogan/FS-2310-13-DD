using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity.Concrete
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string SendToId { get; set; }
        public string SendToName { get; set; }
        public string SendFromId { get; set; }
        public string SendFromName { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
        public int RelatedId { get; set; } = 0;
    }
}
