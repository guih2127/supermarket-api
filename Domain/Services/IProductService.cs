using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket_api.Domain.Models;
using supermarket_api.Domain.Services.Communication;

namespace supermarket_api.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}