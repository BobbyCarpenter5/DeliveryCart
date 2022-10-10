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
    public class IndexModel : PageModel
    {
        private readonly DeliveryCartContext _context;

        public IndexModel(DeliveryCartContext context)
        {
            _context = context;
        }

        public IList<Shopper> Shopper { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Shopper != null)
            {
                Shopper = await _context.Shopper.ToListAsync();
            }
        }
    }
}
