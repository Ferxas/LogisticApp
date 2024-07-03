import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Login from './components/Login';
import Dashboard from './components/Dashboard';
import TerrestrialShipment from './components/TerrestrialShipment';
import MarineShipment from './components/MarineShipment';
import ShipmentList from './components/ShipmentList';

function App() {
  return (
    <Routes>
      <Switch>
        <Route path="/login" component={Login} />
        <Route path="/dashboard" component={Dashboard} />
        <Route path="/terrestrial-shipment" component={TerrestrialShipment} />
        <Route path="/marine-shipment" component={MarineShipment} />
        <Route path="/shipments" component={ShipmentList} />
      </Switch>
    </Routes>
  );
}

export default App;
