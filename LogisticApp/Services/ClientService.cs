using LogisticApp.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticApp.Services
{
    public class ClientService
    {
        private readonly MongoDbService _mongoDbService;

        public ClientService(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public async Task<ServiceResult> CreateClientAsync(Client client)
        {
            await _mongoDbService.Clients.InsertOneAsync(client);
            return new ServiceResult { Success = true };
        }

        public async Task<List<Client>> GetClientAsync()
        {
            return await _mongoDbService.Clients.Find(_ => true).ToListAsync();
        }
    }
}