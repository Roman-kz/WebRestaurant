using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartltem> ShopCartltem { get; set; }
    }
}
