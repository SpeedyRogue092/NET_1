using System.Collections.Generic;
using NET_1.Data.Interfaces;
using NET_1.Data.Models;
using System;
using System.Linq;

namespace NET_1.Data.Mocks
{
    public class MockToys : IAllToys
    {
        private readonly IToysCategory _categoryToys = new MockCategory();
        public IEnumerable<Toy> Toys
        {
            get
            {
                return new List<Toy> {new Toy {name = "Rei Chiquita", shortDesc = "Fanta", longDesc="Зігріє вас під час третього удару", img="https://media.entertainmentearth.com/assets/images/1dcf9f7c88944f6ebfde19cfca135e90xl.jpg",
                price=1100, isFavourite=true, available=true, Category = _categoryToys.AllCategories.First()},
                new Toy { name = "Горо Маджима", shortDesc = "Скажений Пес Шимано", longDesc = "Фігурка легендарного персонажа серії Yakuza", img = "https://lcdn.be/250442-large_default/yakuza-series-figure-majima-goro-qbitz-asmus-toys-qb002-17cm.jpg",
                price = 2200, isFavourite = false, available = true, Category = _categoryToys.AllCategories.Last() } };
            }
        }
        public IEnumerable<Toy> getFavToys { get; set; }
        public Toy getObjectToy(int ToyId)
        {
            throw new NotImplementedException();
        }

    }
}
