using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeddleRealmCore.Data;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Views.Items
{
    public class IndexModel : PageModel
    {
        private readonly PeddleRealmCore.Data.StoreContext _context;

        public IndexModel(PeddleRealmCore.Data.StoreContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items
                .Include(i => i.ItemType).ToListAsync();
        }
    }
}
