# SuperHero API using Dapper, C#, SQL Server, and ASP.NET Core 8.0

This repository contains an API for managing superheroes. It is built with **C#**, **ASP.NET Core 8.0**, **Dapper** for database operations, and **SQL Server** for data storage.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This API provides CRUD operations for managing superheroes. It allows users to:
- **Get all superheroes**
- **Get a superhero by ID**
- **Add a new superhero**
- **Update an existing superhero**
- **Delete a superhero**

## Technologies Used

- **C#**
- **ASP.NET Core 8.0**
- **Dapper**
- **SQL Server**

## Getting Started

To run this project locally, follow these steps:

1. Clone this repository to your local machine.
2. Ensure you have .NET Core SDK and SQL Server installed.
3. Update the connection string in `appsettings.json` to match your SQL Server instance.
4. Run the SQL script provided in the `DatabaseScripts` folder to create the necessary database and table.
5. Open the solution in your preferred IDE (e.g., Visual Studio, Visual Studio Code).
6. Build and run the application.

## Endpoints

- **GET** `/api/SuperHero` - Retrieve all superheroes.
- **GET** `/api/SuperHero/{id}` - Retrieve a superhero by ID.
- **POST** `/api/SuperHero` - Add a new superhero.
- **PUT** `/api/SuperHero/{id}` - Update an existing superhero.
- **DELETE** `/api/SuperHero/{id}` - Delete a superhero by ID.

## Contributing

Contributions are welcome! Feel free to submit issues and pull requests.

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---
Feel free to customize this README according to your preferences and project requirements. If you have any questions or need further assistance, please don't hesitate to reach out. Happy coding! 🚀
