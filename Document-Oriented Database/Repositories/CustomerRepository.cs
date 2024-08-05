using Document_Oriented_Database.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelationDataBaseSystem.Model;

namespace Document_Oriented_Database.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMongoCollection<Customer> _customerCollection;
        private readonly IOptions<DatabaseSetting> _dbsetting;

        public CustomerRepository(IOptions<DatabaseSetting> dbsetting)
        {
            _dbsetting = dbsetting;
            var mongoClient = new MongoClient(dbsetting.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(dbsetting.Value.DatabaseName);
            _customerCollection = (mongoDatabase.GetCollection<Customer>
                (dbsetting.Value.CustomerCollectionName));
        }

        public async Task Create(Customer customer)
        {
            await _customerCollection.InsertOneAsync(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerCollection.Find(_ => true).ToListAsync();
        }
    }
}
