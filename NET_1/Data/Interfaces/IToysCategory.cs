using NET_1.Data.Models;
using System.Collections.Generic;

namespace NET_1.Data.Interfaces
{
    public interface IToysCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
