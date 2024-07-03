using LogisticApp.DTOs;
using LogisticApp.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticApp.Services
{
    public class ShipmentService
    {
        private readonly MongoDbService _mongoDbService;

        public ShipmentService(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public async Task<ServiceResult> CreateTerrestrialShipmentAsync(TerrestrialShipmentRequest request)
        {
            var newShipment = new TerrestrialShipment
            {
                ProductType = request.ProductType,
                Quantity = request.Quantity,
                RegistrationDate = request.RegistrationDate,
                DeliveryDate = request.DeliveryDate,
                DeliveryWarehouse = request.DeliveryWarehouse,
                ShipmentPrice = request.ShipmentPrice,
                VehiclePlate = request.VehiclePlate,
                GuideNumber = request.GuideNumber,
                Discount = request.Discount,
                FinalPrice = request.ShipmentPrice - request.Discount
            };
            await _mongoDbService.TerrestrialShipments.InsertOneAsync(newShipment);
            return new ServiceResult { Success = true };
        }

        public async Task<ServiceResult> CreateMarineShipmentAsync(MarineShipmentRequest request)
        {
            var newShipment = new MarineShipment
            {
                ProductType = request.ProductType,
                Quantity = request.Quantity,
                RegistrationDate = request.RegistrationDate,
                DeliveryDate = request.DeliveryDate,
                DeliveryPort = request.DeliveryPort,
                ShipmentPrice = request.ShipmentPrice,
                FleetNumber = request.FleetNumber,
                GuideNumber = request.GuideNumber,
                Discount = request.Discount,
                FinalPrice = request.ShipmentPrice - request.Discount
            };
            await _mongoDbService.MarineShipments.InsertOneAsync(newShipment);
            return new ServiceResult { Success = true };
        }

        public async Task<List<TerrestrialShipment>> GetTerrestrialShipmentsAsync()
        {
            return await _mongoDbService.TerrestrialShipments.Find(_ => true).ToListAsync();
        }

        public async Task<List<MarineShipment>> GetMarineShipmentsAsync()
        {
            return await _mongoDbService.MarineShipments.Find(_ => true).ToListAsync();
        }
    }
}
