import React, { useState } from 'react';
import axios from 'axios';

const TerrestrialShipment = () => {
  const [shipmentData, setShipmentData] = useState({
    productType: '',
    quantity: 0,
    registrationDate: '',
    deliveryDate: '',
    deliveryWarehouse: '',
    shipmentPrice: 0,
    vehiclePlate: '',
    guideNumber: '',
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setShipmentData({ ...shipmentData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post('http://localhost:5000/api/terrestrial-shipments', shipmentData);
      console.log('Shipment registered:', response.data);
    } catch (error) {
      console.error('Error registering shipment', error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <input name="productType" value={shipmentData.productType} onChange={handleChange} placeholder="Product Type" required />
      <input name="quantity" type="number" value={shipmentData.quantity} onChange={handleChange} placeholder="Quantity" required />
      <input name="registrationDate" type="date" value={shipmentData.registrationDate} onChange={handleChange} required />
      <input name="deliveryDate" type="date" value={shipmentData.deliveryDate} onChange={handleChange} required />
      <input name="deliveryWarehouse" value={shipmentData.deliveryWarehouse} onChange={handleChange} placeholder="Delivery Warehouse" required />
      <input name="shipmentPrice" type="number" value={shipmentData.shipmentPrice} onChange={handleChange} placeholder="Shipment Price" required />
      <input name="vehiclePlate" value={shipmentData.vehiclePlate} onChange={handleChange} placeholder="Vehicle Plate" required />
      <input name="guideNumber" value={shipmentData.guideNumber} onChange={handleChange} placeholder="Guide Number" required />
      <button type="submit">Register Shipment</button>
    </form>
  );
};

export default TerrestrialShipment;
