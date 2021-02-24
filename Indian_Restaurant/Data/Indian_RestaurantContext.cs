using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Indian_Restaurant.Models;

namespace Indian_Restaurant.Data
{
    public class Indian_RestaurantContext : DbContext
    {
        public Indian_RestaurantContext (DbContextOptions<Indian_RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Indian_Restaurant.Models.Food> Food { get; set; }
    }
}
