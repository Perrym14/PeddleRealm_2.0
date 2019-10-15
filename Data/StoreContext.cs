using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<PeddleRealmCore.Models.Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<ItemType>().ToTable("Item Type");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("Order Detail");
        }
    }
}
