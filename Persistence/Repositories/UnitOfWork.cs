using System.Threading.Tasks;
using supermarket_api.Domain.Repositories;
using supermarket_api.Persistence.Contexts;

namespace supermarket_api.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}