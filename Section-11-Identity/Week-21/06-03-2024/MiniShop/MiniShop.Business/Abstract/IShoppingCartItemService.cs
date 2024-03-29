﻿using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IShoppingCartItemService
    {
        Task<Response<NoContent>> ChangeQuantityAsync(int shoppingCartItemId, int quantity);
        Task<Response<NoContent>> DeleteFromShoppingCartAsync(int shoppingCartItemId);
        Task<Response<NoContent>> ClearShoppingCartAsync(int shoppingCartId);
        Task<int> Count(int shoppingCartId);
        Task<ShoppingCartItemViewModel> GetShoppingCartItemAsync(int shoppingCartItemId);
    }
}
