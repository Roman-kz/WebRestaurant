using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.interfaces;
using WebRestaurant.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace WebRestaurant.Data.Repository
{
    public class CategoryRepository : IDeshesCategory
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
