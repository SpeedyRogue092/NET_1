using Microsoft.EntityFrameworkCore;
using NET_1.Data.Models;

namespace NET_1.DB
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options) { }
        public DbSet<Toy> Toy { get; set; }
        public DbSet<Category> Category { get; set; }
    }

}
