import React, { useState } from 'react';
import axios from 'axios';

const MarineShipment = () => {
  const [shipmentData, setShipmentData] = useState({
    productType: '',
    quantity: 0,
    registrationDate: '',
    deliveryDate: '',
    deliveryPort: '',
    shipmentPrice: 0,
    fleetNumber: '',
    guideNumber: '',
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setShipmentData({ ...shipmentData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post('http://localhost:5000/api/marine-shipments', shipmentData);
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
      <input name="deliveryPort" value={shipmentData.deliveryPort} onChange={handleChange} placeholder="Delivery Port" required />
      <input name="shipmentPrice" type="number" value={shipmentData.shipmentPrice} onChange={handleChange} placeholder="Shipment Price" required />
      <input name="fleetNumber" value={shipmentData.fleetNumber} onChange={handleChange} placeholder="Fleet Number" required />
      <input name="guideNumber" value={shipmentData.guideNumber} onChange={handleChange} placeholder="Guide Number" required />
      <button type="submit">Register Shipment</button>
    </form>
  );
};

export default MarineShipment;
