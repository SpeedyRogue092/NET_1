using Microsoft.EntityFrameworkCore;
using NET_1.Data.Interfaces;
using NET_1.Data.Models;
using NET_1.DB;
using System.Collections.Generic;
using System.Linq;

namespace NET_1.Data.Repository
{
    public class ToyRepository : IAllToys
	{
		private readonly AppDBContent appDBContent;
		public ToyRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}
		public IEnumerable<Toy> Toys => appDBContent.Toy.Include(c => c.Category);
		public IEnumerable<Toy> getFavToys => appDBContent.Toy.Where(p => p.isFavourite).Include(c => c.Category);
		public Toy getObjectToy(int toyId) => appDBContent.Toy.FirstOrDefault(p => p.id == toyId);
	}
}
