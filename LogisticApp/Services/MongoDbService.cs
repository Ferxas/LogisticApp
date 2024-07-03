using LogisticApp.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace LogisticApp.Services
{
    public class MongoDbService
    {
        private readonly IMongoDatabase _database;
        
        public MongoDbService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
            _database = client.GetDatabase(configuration["DatabaseName"]);
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<TerrestrialShipment> TerrestrialShipments => _database.GetCollection<TerrestrialShipment>("TerrestrialShipments");
        public IMongoCollection<MarineShipment> MarineShipment => _database.GetCollection<MarineShipment>("MarineShipments");
        public IMongoCollection<Client> Clients => _database.GetCollection<Client>("Clients");
    } 
}