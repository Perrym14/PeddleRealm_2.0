using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Interfaces
{
    public interface IItemRepository
    {
        Item GetItem(int itemId);
        void Add(Item item);
        IEnumerable<Item> GetItems();
    }
}
