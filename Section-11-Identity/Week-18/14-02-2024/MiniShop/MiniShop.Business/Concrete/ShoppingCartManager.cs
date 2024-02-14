﻿using AutoMapper;
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
    public class ShoppingCartManager : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMapper _mapper;

        public ShoppingCartManager(IShoppingCartRepository shoppingCartRepository, IMapper mapper)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> AddToCartAsync(string userId, int productId, int quantity)
        {

            ShoppingCart shoppingCart = await _shoppingCartRepository.GetShoppingCartByUserIdAsync(userId);
            
            if (shoppingCart != null) 
            {
                var index = shoppingCart.ShoppingCartItems.FindIndex(x => x.ProductId == productId);
                if (index < 0) 
                {
                    shoppingCart.ShoppingCartItems.Add(new ShoppingCartItem
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        ShoppingCartId = shoppingCart.Id
                    });
                }
                else
                {
                    shoppingCart.ShoppingCartItems[index].Quantity += quantity;
                }
                await _shoppingCartRepository.UpdateAsync(shoppingCart);
                return Response<NoContent>.Success();
            }
            return Response<NoContent>.Fail("Bir hata oluştu.");
        }

        public Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartId, int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<ShoppingCartViewModel>> GetShoppingCartByUserIdAsync(string userId)
        {
            var shoppingCart = await _shoppingCartRepository.GetShoppingCartByUserIdAsync(userId);
            if(shoppingCart == null) 
            {
                return Response<ShoppingCartViewModel>.Fail("İlgili sepette sorun var, yöneticiyle görüşün.");
            }
            var result = _mapper.Map<ShoppingCartViewModel>(shoppingCart);
            return Response<ShoppingCartViewModel>.Success(result);
        }

        public Task<Response<NoContent>> InitializeShoppingCartAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
