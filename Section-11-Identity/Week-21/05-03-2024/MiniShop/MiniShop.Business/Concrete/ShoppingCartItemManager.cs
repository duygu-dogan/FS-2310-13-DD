using Microsoft.EntityFrameworkCore;
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
    public class ShoppingCartItemManager : IShoppingCartItemService
    {
        private readonly IShoppingCartItemRepository _shoppingCartItemRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartItemManager(IShoppingCartItemRepository shoppingCartItemRepository, IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task<Response<NoContent>> ChangeQuantityAsync(int shoppingCartItemId, int quantity)
        {
            ShoppingCartItem shoppingCartItem = await _shoppingCartItemRepository.GetByIdAsync(x=>x.Id ==shoppingCartItemId);
                await _shoppingCartItemRepository.ChangeQuantityAsync(shoppingCartItem, quantity);
                return Response<NoContent>.Success();
        }

        public async Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId)
        {
            //var cart = await _shoppingCartRepository.GetByIdAsync(x=> x.Id ==shoppingCartId, source => source.Include(x => x.ShoppingCartItems));
            //cart.ShoppingCartItems = new List<ShoppingCartItem>();
            //await _shoppingCartRepository.UpdateAsync(cart);
            //return Response<NoContent>.Success();
            await _shoppingCartItemRepository.ClearFromShoppingCartAsync(shoppingCartId);
            return Response<NoContent>.Success();
        }

        public async Task<int> Count(int shoppingCartId)
        {
            return await _shoppingCartItemRepository.GetCount(x=> x.ShoppingCartId == shoppingCartId );
        }

        public async Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartItemId)
        {
            await _shoppingCartItemRepository.DeleteFromShoppingCartAsync(shoppingCartItemId);
            return Response<NoContent>.Success();
            //var deletedCart = await _shoppingCartRepository.GetByIdAsync(x => x.Id == shoppingCartItemId);
            //await _shoppingCartRepository.HardDeleteAsync(deletedCart);
            //return Response<NoContent>.Success();

        }
        public async Task<ShoppingCartItemViewModel> GetShoppingCartItemAsync(int shoppingCartItemId)
        {
            var shoppingCartItem = await _shoppingCartItemRepository.GetByIdAsync(x => x.Id == shoppingCartItemId, source => source.Include(x => x.Product));
            return new ShoppingCartItemViewModel
            {
                Id = shoppingCartItem.Id,
                ProductId = shoppingCartItem.ProductId,
                ProductName = shoppingCartItem.Product.Name,
                Quantity = shoppingCartItem.Quantity,
                ProductPrice = shoppingCartItem.Product.Price,
                ProductImageUrl = shoppingCartItem.Product.ImageUrl
            };
        }
    }
}
