
---

# 🌐 ASP.NET Core API with Swagger Documentation! 🌐

## Table of Contents

1. [About the Project](#-about-the-project)
2. [Key Features](#-key-features)
3. [Technologies and Structure](#-technologies-and-structure)
4. [Getting Started](#-getting-started)
5. [Dependencies](#-dependencies)
6. [API Endpoints Overview](#api-endpoints-overview-)

## 📖 About the Project
This project is a simple ASP.NET Core Web API designed to demonstrate API development with integrated Swagger documentation. It serves as a basic template for building and documenting RESTful APIs using .NET.

## 🛠 Key Features
- **ASP.NET Core**: Provides a solid foundation for building high-performance APIs.
- **Swagger/OpenAPI**: Automatically generated API documentation for easy exploration and testing.
- **XML Comments**: Enhanced API documentation with detailed method descriptions and parameters.
- **Modular Design**: Clean separation of concerns, promoting maintainability and scalability.

## 🏗 Technologies and Structure
- **Backend**: ASP.NET Core used for robust API development.
- **Documentation**: Swagger integrated with OpenAPI for comprehensive API documentation.
- **Development Tools**: Visual Studio or VS Code recommended for an optimal development experience.

## 🚀 Getting Started

### Prerequisites
- Ensure you have .NET SDK installed on your machine.

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/ElyahuAnavi/aspnetcore-api-with-swagger.git
   ```
2. Navigate to the project directory:
   ```bash
   cd aspnetcore-api-with-swagger
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```

### Running the App
- Start the application:
  ```bash
  dotnet run
  ```
- Access Swagger UI for API documentation:
  ```bash
  http://localhost:5000/swagger
  ```

## 📦 Dependencies
- **Microsoft.AspNetCore.App**: ASP.NET Core shared framework for building web applications and services.
- **Swashbuckle.AspNetCore**: Tools for generating Swagger API documentation and integrating it with your ASP.NET Core application.
- **Microsoft.OpenApi**: Support for OpenAPI standards, enabling well-documented APIs.
- **System.IO**: Used for handling file operations like including XML comments in Swagger documentation.

## API Endpoints Overview 🚏

After launching the server, the API endpoints can be accessed at `http://localhost:5000`.

### Endpoints
- **GET /hello**: Returns a simple "Hello World" message, demonstrating a basic API response.
![image](https://github.com/user-attachments/assets/15acac64-f65f-4b92-8ade-d5c81d25dc89)

---

Feel free to clone the repository, explore the API, and extend the project with additional endpoints and features! Your feedback and contributions are welcome.

---

