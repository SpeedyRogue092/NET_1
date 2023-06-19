using NET_1.Data.Interfaces;
using NET_1.Data.Models;
using NET_1.DB;
using System.Collections.Generic;

namespace NET_1.Data.Repository
{
    public class CategoryRepository: IToysCategory
	{
		private readonly AppDBContent appDBContent;
		public CategoryRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}
		public IEnumerable<Category> AllCategories => appDBContent.Category;
	}
}

