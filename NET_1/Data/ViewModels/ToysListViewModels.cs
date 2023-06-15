using NET_1.Data.Models;
using System.Collections.Generic;

namespace NET_1.Data.ViewModels
{
    public class ToysListViewModels
    {
        public IEnumerable<Toy> allToys { get; set; }
        public string currCategory { get; set; }
    }
}
