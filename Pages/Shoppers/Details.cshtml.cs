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
    public class DetailsModel : PageModel
    {
        private readonly DeliveryCartContext _context;

        public DetailsModel(DeliveryCartContext context)
        {
            _context = context;
        }

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
    }
}
