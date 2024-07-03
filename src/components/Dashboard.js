import React from 'react';
import { Link } from 'react-router-dom';

const Dashboard = () => {
  return (
    <div>
      <h1>Dashboard</h1>
      <Link to="/terrestrial-shipment">Register Terrestrial Shipment</Link>
      <br />
      <Link to="/marine-shipment">Register Marine Shipment</Link>
      <br />
      <Link to="/shipments">View All Shipments</Link>
    </div>
  );
};

export default Dashboard;
