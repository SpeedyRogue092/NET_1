using System.Collections.Generic;
using NET_1.Data.Models;

namespace NET_1.Data.Interfaces
{
    public interface IAllToys
    {
        IEnumerable<Toy> Toys { get; }
        IEnumerable<Toy> getFavToys { get;}

        Toy getObjectToy(int toyId);

    }
}
