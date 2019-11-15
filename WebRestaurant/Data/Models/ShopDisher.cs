using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurant.Data.Models
{
    public class ShopDisher
    {
        private readonly AppDBContent appDBContent;

        public ShopDisher(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopDisherID { get; set; }
    
        public List<ShopCartltem> ListshopCartltems { get; set; }

        public static ShopDisher GetDisher(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopDisherID = session.GetString("DisherID") ?? Guid.NewGuid().ToString();

            session.SetString("DisherID", shopDisherID);

            return new ShopDisher(context) { ShopDisherID = shopDisherID };
        }

        public void AddToDisher(Dishes dishes)
        {
            appDBContent.ShopCartltem.Add(new ShopCartltem {
                ShopDishesId = ShopDisherID,
                dishes = dishes,
                price = dishes.price
            });


            appDBContent.SaveChanges();
        }

        public List<ShopCartltem> getCartltems()
        {
            return appDBContent.ShopCartltem.Where(c => c.ShopDishesId == ShopDisherID).Include(s => s.dishes).ToList();
        }
    }
}
