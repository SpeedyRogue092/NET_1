using NET_1.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace NET_1.DB
{
    public class DBObjects
    {
        //функція для підключення до БД
        public static void Initial(AppDBContent appDbContent)
        {
            if (!appDbContent.Category.Any())
            {
				appDbContent.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!appDbContent.Toy.Any())
            {
				appDbContent.AddRange(
                new Toy
                {
					name = "Rei Chiquita",
					shortDesc = "Fanta",
					longDesc = "Зігріє вас під час третього удару",
					img = "https://media.entertainmentearth.com/assets/images/1dcf9f7c88944f6ebfde19cfca135e90xl.jpg",
					age = "12+",
					price = 1099,
					isFavourite = true,
					available = true,
					Category = Categories["Плюшевi iграшки"]
                },
               new Toy
               {
				   name = "Горо Маджима",
				   shortDesc = "Скажений Пес Шимано",
				   longDesc = "Фігурка легендарного персонажа серії Yakuza",
				   img = "https://lcdn.be/250442-large_default/yakuza-series-figure-majima-goro-qbitz-asmus-toys-qb002-17cm.jpg",
				   age = "16+",
				   price = 2199,
				   isFavourite = false,
				   available = true,
				   Category = Categories["Колекційні фігурки"]
               }
                );
            }
			appDbContent.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    //створення інфомаціїї для занесення в БД
                    var list = new Category[]{
                        new Category {categoryName = "Плюшевi iграшки", desc = "М'якi друзi на будь-який смак"},
                        new Category {categoryName = "Колекційні фігурки", desc = "Насолода для справжнiх колекцiонерiв"}};
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }

}