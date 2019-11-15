using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.interfaces;
using WebRestaurant.ViewModels;

namespace WebRestaurant.Controllers
{
    public class HomeController : Controller 
    {
        private readonly IALLDishes _dishesRep;

        public HomeController(IALLDishes dishesRep)
        {
            _dishesRep = dishesRep;
        }

        public ViewResult Index()
        {
            var homDishes = new HomeViewModel
            {
                favdishes = _dishesRep.GetFavDishes
            };
            return View(homDishes);
        }
    }
}
