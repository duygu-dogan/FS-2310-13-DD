using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories
{
    public class ShoppingCartItemRepository : GenericRepository<ShoppingCartItem>, IShoppingCartItemRepository
    {
        public ShoppingCartItemRepository(MiniShopDbContext _context) : base(_context)
        {

        }
        MiniShopDbContext MiniShopDbContext
        { get { return _dbContext as MiniShopDbContext; } }
        public async Task ChangeQuantityAsync(ShoppingCartItem shoppingCartItem, int quantity)
        {
            shoppingCartItem.Quantity = quantity;
            MiniShopDbContext.Update(shoppingCartItem);
            await MiniShopDbContext.SaveChangesAsync();
        }

        public async Task ClearFromShoppingCartAsync(int shoppingCartId)
        {
            //var query = @$"DELETE FROM ShoppingCartItems WHERE ShoppingCartId =@p0";
            //await MiniShopDbContext.Database.ExecuteSqlRawAsync(query, shoppingCartId);
            var deletedShoppingCartItems = await MiniShopDbContext
                .ShoppingCartItems
                .Where(x => x.ShoppingCartId == shoppingCartId)
                .ToListAsync();
            MiniShopDbContext.ShoppingCartItems.RemoveRange(deletedShoppingCartItems);
            await MiniShopDbContext.SaveChangesAsync();
        }

        public async Task DeleteFromShoppingCartAsync(int shoppingCartItemId)
        {
            //var query = $@"DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @p0 AND ProductId=@p1";
            //await MiniShopDbContext.Database.ExecuteSqlRawAsync(query, shoppingCartId, productId);
            var deletedShoppingCartItem = await MiniShopDbContext
                .ShoppingCartItems
                .Where(x => x.Id == shoppingCartItemId)
                .FirstOrDefaultAsync();
            MiniShopDbContext.ShoppingCartItems.Remove(deletedShoppingCartItem);
            await MiniShopDbContext.SaveChangesAsync();
        }
    }
}
