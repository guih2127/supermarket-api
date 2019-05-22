using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket_api.Domain.Models;

namespace supermarket_api.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}