using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurant.Data.Models
{
    public class Category
    {
        public int id { get; set; }

        public string categoreName { get; set; }

        public List<Dishes> Dishes { get; set; }

    }
}
