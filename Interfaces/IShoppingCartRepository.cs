using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Interfaces
{
    public interface IShoppingCartRepository
    {
        void AddToCart();
        void EmptyCart();
        List<Cart> GetCartItems();
        int GetCount();
        decimal GetTotal();
        /*Write signature for:
         GetCart(HttpContext)
         GetCart(Controller helper method)
         RemoveFromCart(returns itemCount)
         GetCartItems
         CreateOrder
         GetCartId
         MigrateCart
         */

    }
}
