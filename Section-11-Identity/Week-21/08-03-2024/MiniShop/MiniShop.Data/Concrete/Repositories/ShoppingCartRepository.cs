﻿using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(MiniShopDbContext _context) : base(_context)
        {

        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
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
