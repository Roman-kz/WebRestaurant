using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.Models;

namespace WebRestaurant.ViewModels
{
    public class DishesListViewModel
    {
        public IEnumerable<Dishes> allDishes { get; set; }
        public string currCategory { get; set; }

    }
}
