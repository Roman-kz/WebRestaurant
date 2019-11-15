using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.interfaces;
using WebRestaurant.Data.Models;
using WebRestaurant.ViewModels;

namespace WebRestaurant.Controllers
{
    public class ShopDisherController : Controller
    {
        private readonly IALLDishes _dishesRep;
        private readonly ShopDisher _shopDisher;

        public ShopDisherController(IALLDishes dishesRep, ShopDisher shopDisher)
        {
            _dishesRep = dishesRep;
            _shopDisher = shopDisher;
        }

        public ViewResult Index()
        {
            var items = _shopDisher.getCartltems();
            _shopDisher.ListshopCartltems = items;

            var obj = new ShopDisherViewModel
            {
                shopDisher = _shopDisher
            };

            return View(obj);
        }


        public RedirectToActionResult addToDisher(int id)
        {
            var item = _dishesRep.Dishes.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopDisher.AddToDisher(item);
            }
            return RedirectToAction("Index");
        }

    }
}
