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

        public DbSet<PeddleRealmCore.Models.Item> Item { get; set; }
    }
}
