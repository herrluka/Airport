using Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Persistence.Configuration;

namespace Persistence.Mongo
{
    public class CatalogContext : ICatalogContext
    {
        private DatabaseSettings databaseSettings;
        public CatalogContext(IOptions<DatabaseSettings> databaseSettingsOption)
        {
            databaseSettings = databaseSettingsOption.Value;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);

            Products = database.GetCollection<Product>(databaseSettings.CollectionName);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
