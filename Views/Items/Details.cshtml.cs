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
    public class DetailsModel : PageModel
    {
        private readonly PeddleRealmCore.Data.StoreContext _context;

        public DetailsModel(PeddleRealmCore.Data.StoreContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Items
                .Include(i => i.ItemType).FirstOrDefaultAsync(m => m.Id == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
