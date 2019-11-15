using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.interfaces;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data.Repository
{
    public class DishesRepository : IALLDishes
    {
        private readonly AppDBContent appDBContent;

        public DishesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Dishes> Dishes => appDBContent.Dishes.Include(c => c.Category);

        public IEnumerable<Dishes> GetFavDishes => appDBContent.Dishes.Where(p => p.isFavourite).Include(c => c.Category);

        public Dishes getObjectDish(int DishId) => appDBContent.Dishes.FirstOrDefault(p => p.id == DishId);
    }
}
