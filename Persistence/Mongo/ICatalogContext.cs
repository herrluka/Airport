using Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mongo
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
