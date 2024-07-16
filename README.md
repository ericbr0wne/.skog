# dotSkog - Social Networking API
Welcome to dotSkog, a content free social networking platform built using ASP.NET Core Web API, Entity Framework Core, and PostgreSQL.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [API Documentation](#api-documentation)
- [Contributing](#contributing)
- [License](#license)

## Introduction

A social network API experiment - no content?

## Features

- **User Management:** User registration, authentication, profile management, and search.
- **Posting:** Create, read, update, and delete posts (CRUD operations).
- **Commenting:**  Add, edit, and delete comments on posts. 

## Technologies

- **Backend:**
    - ASP.NET Core Web API
    - Entity Framework Core
    - PostgreSQL
    - Npgsql (.NET PostgreSQL driver)
- **Frontend:** 
    - Blazor
- **Other:** 
    - Docker for containerization

## Getting Started

1. **Prerequisites:**
   - .NET SDK (version X.X or later)
   - Docker Desktop (if using Docker)
   - PostgreSQL (running locally or in Docker)
   - Node.js and npm

2. **Installation:**
   - Clone this repository: [dotSkog](https://github.com/ericbr0wne/dotSkog)
   - Navigate to the project directory: `cd dotSkog`
   - Restore dependencies: `dotnet restore`
   - Update `appsettings.json` with your PostgreSQL connection string.
   - Apply migrations: `dotnet ef database update`
   - Run the application: `dotnet run`

3. **API Endpoints:**
   - TBA

## API Documentation

- **Swagger UI:** (If enabled) Access the Swagger UI at `http://localhost:5153/swagger` (or your configured port) to explore the API endpoints and try them out.
- **Custom Documentation:** (Optional)  You can create your own API documentation using a tool like Redoc or by writing markdown files in a `docs` folder.

## Contributing

- TBA

## License

- TBA

---
