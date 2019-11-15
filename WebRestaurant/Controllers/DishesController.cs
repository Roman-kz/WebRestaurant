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
    public class DishesController : Controller
    {
        private readonly IALLDishes iALLDisher;
        private readonly IDeshesCategory deshesCategory;

        public DishesController(IALLDishes aLLDishes, IDeshesCategory deshesCategory1)
        {
            iALLDisher = aLLDishes;
            deshesCategory = deshesCategory1;
        }


        [Route("Dishes/list")]
        [Route("Dishes/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Dishes> dishes = null;
            string dishesCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                dishes = iALLDisher.Dishes.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Салаты", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = iALLDisher.Dishes.Where(i => i.Category.categoreName.Equals("Салаты")).OrderBy(i => i.id);
                    dishesCategory = "Салаты";
                }
                else if (string.Equals("Завтрак", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = iALLDisher.Dishes.Where(i => i.Category.categoreName.Equals("Завтрак")).OrderBy(i => i.id);
                    dishesCategory = "Завтрак";
                }

                else if (string.Equals("Холодные закуски", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = iALLDisher.Dishes.Where(i => i.Category.categoreName.Equals("Холодные закуски")).OrderBy(i => i.id);
                    dishesCategory = "Холодные закуски";
                }

                else if (string.Equals("Горячие закуски", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = iALLDisher.Dishes.Where(i => i.Category.categoreName.Equals("Горячие закуски")).OrderBy(i => i.id);
                    dishesCategory = "Горячие закуски";
                }

                else if (string.Equals("Первое блюда", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = iALLDisher.Dishes.Where(i => i.Category.categoreName.Equals("Первое блюда")).OrderBy(i => i.id);
                    dishesCategory = "Первое блюда";
                }

                else if (string.Equals("Вторые блюда", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = iALLDisher.Dishes.Where(i => i.Category.categoreName.Equals("Вторые блюда")).OrderBy(i => i.id);
                    dishesCategory = "Вторые блюда";
                }

               

            }

            var dishesObj = new DishesListViewModel
            {
                allDishes = dishes,
                currCategory = dishesCategory
            };




            ViewBag.Title = "Блюда";
            //DishesListViewModel obj = new DishesListViewModel();
            //obj.allDishes = iALLDisher.Dishes;
            //obj.currCategory = "Блюда";
            return View(dishesObj);
        }
    }
}
