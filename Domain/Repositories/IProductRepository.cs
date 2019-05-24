using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket_api.Domain.Models;

namespace supermarket_api.Domain.Repositories
{
    public interface IProductRepository
    {
         Task<IEnumerable<Product>> ListAsync();
    }
}