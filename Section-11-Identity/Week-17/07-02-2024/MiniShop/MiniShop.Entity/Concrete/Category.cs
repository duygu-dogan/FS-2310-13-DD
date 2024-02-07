using MiniShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity.Concrete
{
    public class Category:BaseEntity,IMainEntity
    {
        public string Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }//Navigation Property
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
