using Application.Repository;
using Domain.Entities;
using MongoDB.Driver;
using Persistence.Mongo;

namespace Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext catalogContext;

        public ProductRepository(ICatalogContext catalogContext)
        {
            this.catalogContext = catalogContext;
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            await catalogContext.Products.InsertOneAsync(entity);
            return entity;
        }

        public async Task DeleteByIdAsync(string id)
        {
            await catalogContext.Products.DeleteOneAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var filter = Builders<Product>.Filter.Empty;
            return await catalogContext.Products.Find(filter).ToListAsync();
            
        }

        public async Task<Product> GetByIdAsync(string id)
        {
            return await catalogContext.Products.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(string id, Product entity)
        {
            await catalogContext.Products.ReplaceOneAsync(x => x.Id.Equals(entity.Id), entity);
        }
    }
}
