using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Data.Models;

namespace WebRestaurant.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {



            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Dishes.Any())
            {
                content.AddRange(
                     new Dishes
                     {
                         dishName = "Каша молочная",
                         price = 550,
                         longDesc = "",
                         img = "/img/Molochnaya-risovaya-kasha.jpg",
                         available = true,
                         isFavourite = false,
                         Category = Categories["Завтрак"]
                     },

                    new Dishes
                    {
                        dishName = "Яичница – глазунья",
                        price = 350,
                        longDesc = "2 яйца",
                        img = "/img/Яичница – глазунья.jpg",
                        available = true,
                        isFavourite = false,
                        Category = Categories["Завтрак"]
                    },

                    new Dishes
                    {
                        dishName = "Нарезка овощная ",
                        price = 700,
                        longDesc = "Свежие огурцы, помидоры, лук",
                        img = "/img/Нарезка овощная.jpg",
                        available = true,
                        isFavourite = false,
                        Category = Categories["Холодные закуски"]
                    },

                    new Dishes
                    {
                        dishName = "Закуска «Кавказ»",
                        price = 950,
                        longDesc = "Свежие овощи, брынза, зелень",
                        img = "/img/Закуска «Кавказ».jpg",
                        available = true,
                        isFavourite = true,
                        Category = Categories["Холодные закуски"]
                    },

                    new Dishes
                    {
                        dishName = "Русская закуска",
                        price = 900,
                        longDesc = "всеми любимая селедочка, отварная  картошечка, маринованные огурчики, грибы. А если все это и к водочк",
                        img = "/img/Русская закуска.jpg",
                        available = true,
                        isFavourite = true,
                        Category = Categories["Холодные закуски"]
                    },

                    new Dishes
                    {
                        dishName = "Сообразим на троих",
                        price = 2000,
                        longDesc = "Ассорти из жаренных колбасок и картошки, маринованный лучок, огурчики соленные",
                        img = "/img/Сообразим на троих.jpeg",
                        available = true,
                        isFavourite = true,
                        Category = Categories["Горячие закуски"]
                    },

                    new Dishes
                    {
                        dishName = "Завтрак охотника",
                        price = 1500,
                        longDesc = "колбаса, сосиски, сардельки, сало  на сковороде с луком",
                        img = "/img/Завтрак охотника.jpg",
                        available = true,
                        isFavourite = false,
                        Category = Categories["Горячие закуски"]
                    },

                    new Dishes
                    {
                        dishName = "Суп с фрикадельками",
                        price = 600,
                        longDesc = "Говяжий бульон, мясные шарики, морковь, картофель",
                        img = "/img/Суп с фрикадельками.jpg",
                        available = true,
                        isFavourite = false,
                        Category = Categories["Первое блюда"]
                    },

                    new Dishes
                    {
                        dishName = "Пельмени русские",
                        price = 700,
                        longDesc = "подаются  со сметаной/коброй",
                        img = "/img/Пельмени русские.jpg",
                        available = true,
                        isFavourite = true,
                        Category = Categories["Вторые блюда"]
                    },

                    new Dishes
                    {
                        dishName = "Бризоль",
                        price = 700,
                        longDesc = "",
                        img = "/img/Бризоль.jpg",
                        available = true,
                        isFavourite = true,
                        Category = Categories["Вторые блюда"]
                    }

                    );
            }

            content.SaveChanges();


        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                    new Category { categoreName = "Завтрак"},
                    new Category { categoreName = "Салаты"},
                    new Category { categoreName = "Холодные закуски"},
                    new Category { categoreName = "Горячие закуски"},
                    new Category { categoreName = "Первое блюда"},
                    new Category { categoreName = "Вторые блюда"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoreName, el);
                }
                   return category;
                
            }
        }
    }
}

