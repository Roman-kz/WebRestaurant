using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.interfaces;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data.mocks
{
    public class MockDishes : IALLDishes
    {
        private readonly IDeshesCategory menuCategory = new MockCategory();
        public IEnumerable<Dishes> Dishes {

            get
            {
                return new List<Dishes>
                {
                    new Dishes
                    {
                        dishName = "Каша молочная",
                        price = 550,
                        longDesc = "",
                        img ="/img/Molochnaya-risovaya-kasha.jpg",
                        available = true,
                        isFavourite = false,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Яичница – глазунья",
                        price = 350,
                        longDesc = "2 яйца",
                        img ="/img/Яичница – глазунья.jpg",
                        available = true,
                        isFavourite = false,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Нарезка овощная ",
                        price = 700,
                        longDesc = "Свежие огурцы, помидоры, лук",
                        img ="/img/Нарезка овощная.jpg",
                        available = true,
                        isFavourite = false,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Закуска «Кавказ»",
                        price = 950,
                        longDesc = "Свежие овощи, брынза, зелень",
                        img ="/img/Закуска «Кавказ».jpg",
                        available = true,
                        isFavourite = true,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Русская закуска",
                        price = 900,
                        longDesc = "всеми любимая селедочка, отварная  картошечка, маринованные огурчики, грибы. А если все это и к водочк",
                        img ="/img/Русская закуска.jpg",
                        available = true,
                        isFavourite = false,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Сообразим на троих",
                        price = 2000,
                        longDesc = "Ассорти из жаренных колбасок и картошки, маринованный лучок, огурчики соленные",
                        img ="/img/Сообразим на троих.jpeg",
                        available = true,
                        isFavourite = true,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Завтрак охотника",
                        price = 1500,
                        longDesc = "колбаса, сосиски, сардельки, сало  на сковороде с луком",
                        img ="/img/Завтрак охотника.jpg",
                        available = true,
                        isFavourite = true,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Суп с фрикадельками",
                        price = 600,
                        longDesc = "Говяжий бульон, мясные шарики, морковь, картофель",
                        img ="/img/Суп с фрикадельками.jpg",
                        available = true,
                        isFavourite = true,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Пельмени русские",
                        price = 700,
                        longDesc = "подаются  со сметаной/коброй",
                        img ="/img/Пельмени русские.jpg",
                        available = true,
                        isFavourite = true,
                        Category = menuCategory.AllCategories.Last()
                    },

                    new Dishes
                    {
                        dishName = "Бризоль",
                        price = 700,
                        longDesc = "",
                        img ="/img/Бризоль.jpg",
                        available = true,
                        isFavourite = true,
                        Category = menuCategory.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Dishes> GetFavDishes { get; set; }

        public Dishes getObjectDish(int DishId)
        {
            throw new NotImplementedException();
        }
    }
}
