using System.Linq;
using tuanstore.Models;

namespace tuanstore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
