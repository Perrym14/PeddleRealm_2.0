using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeddleRealmCore.Data;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Views.Items
{
    public class CreateModel : PageModel
    {
        private readonly PeddleRealmCore.Data.StoreContext _context;

        public CreateModel(PeddleRealmCore.Data.StoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ItemTypeId"] = new SelectList(_context.Set<ItemType>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Item.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}