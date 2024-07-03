using System;

namespace LogisticApp.DTOs
{
    public class MarineShipmentRequest
    {
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryPort { get; set; }
        public string ShipmentPrice { get; set; }
        public string FleetNumber { get; set; }
        public string GuideNumber { get; set; }
        public double Discount { get; set; }
    }
}