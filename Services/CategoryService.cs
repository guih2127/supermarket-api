using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket_api.Domain.Models;
using supermarket_api.Domain.Services;
using supermarket_api.Domain.Repositories;

namespace supermarket_api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}