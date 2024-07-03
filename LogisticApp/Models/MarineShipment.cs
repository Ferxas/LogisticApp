using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace LogisticApp.Models
{
    public class MarineShipment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryPort { get; set; }
        public string ShipmentPrice { get; set; }
        public string FleetNumber { get; set; }
        public string GuideNumber { get; set; }
        public double Discount { get; set; }
        public double FinalPrice { get; set; }
    }
}