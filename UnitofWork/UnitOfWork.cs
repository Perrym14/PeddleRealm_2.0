using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeddleRealmCore.Data;
using PeddleRealmCore.Interfaces;

namespace PeddleRealmCore.UnitofWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly StoreContext _storeContext;
        public IItemRepository Items { get; }
        public IOrderRepository Orders { get; }
        public IShoppingCartRepository ShoppingCarts { get; }
        public ICartRepository Carts { get; }

        public UnitOfWork(StoreContext storeContext)
        {
            _storeContext = storeContext;

        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
