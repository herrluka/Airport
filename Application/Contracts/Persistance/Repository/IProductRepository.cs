using Domain.Entities;

namespace Application.Repository
{
    public interface IProductRepository : IBaseRepository<string, Product>
    {
    }
}
