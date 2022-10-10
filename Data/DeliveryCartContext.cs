using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;

    public class DeliveryCartContext : DbContext
    {
        public DeliveryCartContext (DbContextOptions<DeliveryCartContext> options)
            : base(options)
        {
        }

        public DbSet<DeliveryCart.Models.Customer> Customer { get; set; } = default!;

        public DbSet<DeliveryCart.Models.Shopper>? Shopper { get; set; }
    }
