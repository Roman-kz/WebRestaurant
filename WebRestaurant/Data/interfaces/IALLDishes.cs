using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data.interfaces
{
    public interface IALLDishes
    {

        IEnumerable<Dishes> Dishes { get; }
        IEnumerable<Dishes> GetFavDishes { get; }
        Dishes getObjectDish(int DishId);
    }
}
