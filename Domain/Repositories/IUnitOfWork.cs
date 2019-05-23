using System.Threading.Tasks;

namespace supermarket_api.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}