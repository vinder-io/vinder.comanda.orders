<p align="center">
  <img src="https://i.imgur.com/MmamZlQ.png" alt="vinder.logo" />
</p>

<h1 align="center">COMANDA</h1>

This module is responsible for handling all aspects of order management within the Comanda system. It provides the core business logic and APIs for creating, updating, retrieving, and managing orders, ensuring seamless integration with other modules and services. The module is designed to support scalability, maintainability, and reliability for order processing workflows in a restaurant.

How to run the system
---------------------
To start the system and all required infrastructure, simply run the following command in the root of the repository:

```
docker-compose up -d
```

This will launch all necessary services, including:
- MongoDB database
- The Vinder Identity Provider (see: https://github.com/vinder-io/vinder.identity.provider)

No additional setup is required; all dependencies are managed via Docker Compose.

After the infrastructure is up, you can start the API by running it from the `Vinder.Comanda.Orders.WebApi` project using your preferred .NET tool or IDE.

Before starting, make sure to create your own `.env` file in the project root, based on the provided `.env.example`, and fill in the real values for your environment.