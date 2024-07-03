import React, { useState, useEffect } from 'react';
import axios from 'axios';

const ShipmentList = () => {
  const [shipments, setShipments] = useState([]);

  useEffect(() => {
    const fetchShipments = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/shipments');
        setShipments(response.data);
      } catch (error) {
        console.error('Error fetching shipments', error);
      }
    };

    fetchShipments();
  }, []);

  return (
    <div>
      <h1>Shipments</h1>
      <ul>
        {shipments.map((shipment) => (
          <li key={shipment.guideNumber}>{shipment.productType} - {shipment.quantity}</li>
        ))}
      </ul>
    </div>
  );
};

export default ShipmentList;
