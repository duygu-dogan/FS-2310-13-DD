using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(MiniShopDbContext _context):base(_context)
        {
            
        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
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

        public async Task DeleteFromShoppingCartAsync(int shoppingCartId, int productId)
        {
            //var query = $@"DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @p0 AND ProductId=@p1";
            //await MiniShopDbContext.Database.ExecuteSqlRawAsync(query, shoppingCartId, productId);

            var deletedShoppingCartItem = await MiniShopDbContext
                .ShoppingCartItems
                .Where(x => x.ShoppingCartId == shoppingCartId && x.ProductId == productId)
                .FirstOrDefaultAsync();
            MiniShopDbContext.ShoppingCartItems.Remove(deletedShoppingCartItem);
            await MiniShopDbContext.SaveChangesAsync();
        }

        public async Task<ShoppingCart> GetShoppingCartByUserIdAsync(string id)
        {
            var shoppingCart = await MiniShopDbContext
                .ShoppingCarts
                .Where(sc => sc.UserId == id)
                .Include(sc => sc.ShoppingCartItems)
                .ThenInclude(sci => sci.Product)
                .FirstOrDefaultAsync();
            return shoppingCart;

            
        }
    }
}
