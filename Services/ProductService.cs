using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket_api.Domain.Models;
using supermarket_api.Domain.Repositories;
using supermarket_api.Domain.Services;

namespace supermarket_api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
    
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}