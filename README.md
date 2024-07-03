# React + Vite

This template provides a minimal setup to get React working in Vite with HMR and some ESLint rules.

Currently, two official plugins are available:

- [@vitejs/plugin-react](https://github.com/vitejs/vite-plugin-react/blob/main/packages/plugin-react/README.md) uses [Babel](https://babeljs.io/) for Fast Refresh
- [@vitejs/plugin-react-swc](https://github.com/vitejs/vite-plugin-react-swc) uses [SWC](https://swc.rs/) for Fast Refresh

# LogisticApp

LogisticApp is a logistics management application that includes user authentication, registration and query of terrestrial and marine shipments, and client management. The application uses ASP.NET Core for the backend, React for the frontend, and MongoDB as the database.

## PROJECT STRUCTURE

```/LogisticApp
/ClientApp
/public
index.html
/src
/components
App.js
Login.js
Register.js
TerrestrialShipment.js
MarineShipment.js
Client.js
index.js
App.css
/Controllers
AuthController.cs
TerrestrialShipmentsController.cs
MarineShipmentsController.cs
ClientsController.cs
/Models
Client.cs
TerrestrialShipment.cs
MarineShipment.cs
User.cs
/Services
AuthService.cs
ShipmentService.cs
ClientService.cs
MongoDbService.cs
/DTOs
LoginRequest.cs
RegisterRequest.cs
TerrestrialShipmentRequest.cs
MarineShipmentRequest.cs
ServiceResult.cs
AuthResult.cs
/Properties
launchSettings.json
appsettings.json
Program.cs
Startup.cs
LogisticApp.csproj
package.json
README.md
```

## Prerequisites

- .NET SDK
- Node.js and npm
- MongoDB

## Installation

1. **Clone the repository**:

```bash
git clone https://github.com/ferxas/LogisticApp.git
cd LogisticApp
```

2. **Restore backend dependencies**:

    ``dotnet restore``

3. **Install frontend dependencies**:
   ``cd ClientApp``
   ``npm install``
   ``cd ..``

4. **Configure environment variables**:
Ensure that the `appsettings.json` configuration is correct, especially the MongoDB connection string.

```json
{
  "ConnectionStrings": {
    "MongoDb": "mongodb://localhost:27017"
  },
  "DatabaseName": "LogisticDb",
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```


## Running the project
1. **Run the backend**:
``dotnet run``

2. **Run the frontend**:
``npm start``

3. **Access the application**:
Open your web browser and navigate to `https://localhost:5001` or `http://localhost:5000` to interact with the API.

### API USAGE
## User Registration
- **Endpoint:** ``/api/auth/register``
- **Method:** ``POST``
- **Body**:
```json
    {
    "email": "user@example.com",
    "password": "password123"
    }
```

## User Login
- **Endpoint:** ``/api/auth/login``
- **Method:** ``POST``
- **Body:**
  ```json
  {
  "email": "user@example.com",
  "password": "password123"
  }
  ```
## Create Terrestrial Shipment
- **Endpoint:** ``/api/terrestrialShipments``
- **Method:** ``POST``
- **Body:**
```json
  {
  "productType": "Electronics",
  "quantity": 100,
  "registrationDate": "2024-07-01T00:00:00Z",
  "deliveryDate": "2024-07-10T00:00:00Z",
  "deliveryWarehouse": "Warehouse 123",
  "shipmentPrice": 1000.00,
  "vehiclePlate": "ABC-123",
  "guideNumber": "G123456",
  "discount": 100.00
  }
```

## Get Terrestrial Shipments
- **Endpoint:** ``/api/terrestrialshipments``
- **Method:** ``GET``
- **Body:**
```json
{
  "productType": "Furniture",
  "quantity": 50,
  "registrationDate": "2024-07-01T00:00:00Z",
  "deliveryDate": "2024-07-15T00:00:00Z",
  "deliveryPort": "Port ABC",
  "shipmentPrice": 5000.00,
  "fleetNumber": "F123",
  "guideNumber": "G654321",
  "discount": 200.00
}
```

## Create Marine Shipment
- **Endpoint:** ``api/marineshipments``
- **Method:** ``POST``
- **Body:**
```json
{
  "productType": "Furniture",
  "quantity": 50,
  "registrationDate": "2024-07-01T00:00:00Z",
  "deliveryDate": "2024-07-15T00:00:00Z",
  "deliveryPort": "Port ABC",
  "shipmentPrice": 5000.00,
  "fleetNumber": "F123",
  "guideNumber": "G654321",
  "discount": 200.00
}
```

## Get Marine Shipments
- **Endpoint:** ``/api/`marineshipments``
- **Method:** ``GET``

## Create Client
- **Endpoint:** ``/api/`clients``
- **Method:** ``POST``
- **Body:**
```json
{
  "name": "Client Example",
  "email": "client@example.com"
}
```

## Get Clients
- **Endpoint:** ``/api/`clients``
- **Method:** ``GET``

## License
This project is licensed under the terms of the MIT License.

This `README.md` provides clear instructions on how to install, configure, run, and use your Logistic App project, as well as an overview of the project structure and available API endpoints.
