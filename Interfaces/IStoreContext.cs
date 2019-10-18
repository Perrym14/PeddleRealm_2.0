using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Interfaces
{
    public interface IStoreContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<ItemType> ItemTypes { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
