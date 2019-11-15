using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.interfaces;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data.mocks
{
    public class MockCategory : IDeshesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoreName = "Завтрак"},
                    new Category { categoreName = "Салаты"},
                    new Category { categoreName = "Холодные закуски"},
                    new Category { categoreName = "Горячие закуски"},
                    new Category { categoreName = "Первое блюда"},
                    new Category { categoreName = "Вторые блюда"}
                };
            }
        } 
    }
}
