using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data.interfaces
{
    public interface IDeshesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
