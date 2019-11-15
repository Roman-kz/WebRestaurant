using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurant.Data.Models
{
    public class ShopCartltem
    {
        public int id{ get; set; }
        public Dishes dishes { get; set; }
        public int price { get; set; }

        public string ShopDishesId { get; set; }


    }
}
