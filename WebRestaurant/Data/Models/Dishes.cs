using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurant.Data.Models
{
    public class Dishes
    {
        public int id { set; get; }

        public string dishName { set; get; }

        public string longDesc { set; get; }

        public int price { set; get; }

        public string img { set; get; }

        public bool isFavourite { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }

    }
}
