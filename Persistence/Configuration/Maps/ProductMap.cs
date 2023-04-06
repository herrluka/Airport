using Domain.Entities;
using MongoDB.Bson.Serialization;

namespace Persistence.Configuration.Maps
{
    public sealed class ProductMap
    {
        public static void Register()
        {
            BsonClassMap.RegisterClassMap<Product>(cm =>
            {
                cm.AutoMap();
                cm.MapIdField(x => x.Id);
            });
        }
    }
}
