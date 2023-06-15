using NET_1.Data.Interfaces;
using NET_1.Data.Models;
using System.Collections.Generic;

namespace NET_1.Data.Mocks

{
    public class MockCategory : IToysCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> { new Category {categoryName = "Плюшевi iграшки", desc = "М'якi друзi на будь-який смак"},
                new Category {categoryName = "Колекційні фігурки", desc = "Насолода для справжнiх колекцiонерiв"}};
            }
        }

    }
}
