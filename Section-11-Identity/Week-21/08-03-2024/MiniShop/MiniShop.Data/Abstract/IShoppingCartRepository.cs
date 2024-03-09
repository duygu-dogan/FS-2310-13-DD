using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart>
    {
        Task<ShoppingCart> GetShoppingCartByUserIdAsync(string id);


    }
}
