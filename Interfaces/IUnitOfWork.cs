using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeddleRealmCore.Interfaces
{
    public interface IUnitOfWork
    {
        IItemRepository Items { get; }
        IOrderRepository Orders { get; }
        IShoppingCartRepository ShoppingCarts { get; }
        ICartRepository Carts { get; }
        void Complete();
    }
}
