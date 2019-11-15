using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.Models;

namespace WebRestaurant.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Dishes> favdishes { get; set; }
    }
}
