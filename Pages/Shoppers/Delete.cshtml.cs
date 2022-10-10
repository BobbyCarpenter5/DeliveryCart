using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;

namespace DeliveryCart.Pages_Shoppers
{
    public class DeleteModel : PageModel
    {
        private readonly DeliveryCartContext _context;

        public DeleteModel(DeliveryCartContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Shopper Shopper { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shopper == null)
            {
                return NotFound();
            }

            var shopper = await _context.Shopper.FirstOrDefaultAsync(m => m.ShopperID == id);

            if (shopper == null)
            {
                return NotFound();
            }
            else 
            {
                Shopper = shopper;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Shopper == null)
            {
                return NotFound();
            }
            var shopper = await _context.Shopper.FindAsync(id);

            if (shopper != null)
            {
                Shopper = shopper;
                _context.Shopper.Remove(Shopper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
