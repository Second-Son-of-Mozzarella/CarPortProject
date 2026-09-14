# CarPort

CarPort is a database-driven application designed to organize, manage, and query structured vehicle information. The project is currently in the initial backend and database architecture stage.

## Technology Stack

### Backend

* **C#**
* **ASP.NET Core 8 Web API**
* **Entity Framework Core 8**
* **LINQ**
* **REST API**

### Database

* **Microsoft SQL Server**
* **T-SQL**
* **Entity Framework Core Migrations**

### Supporting Technologies

* **NLog** — application logging
* **Swagger / OpenAPI** — API documentation and testing
* **FluentValidation** — request and model validation
* **Git / GitHub** — source control

## Project Structure

The backend follows a layered architecture intended to keep the API, business logic, database access, and data models separated.

```text
CarPort/
│
├── Controllers/
│   └── API endpoints and HTTP request handling
│
├── Data/
│   └── Entity Framework Core DbContext and database configuration
│
├── Models/
│   └── Core database entities
│
├── DTOs/
│   └── Data Transfer Objects used by the API
│
├── Services/
│   └── Application and business logic
│
├── Interfaces/
│   └── Service and abstraction interfaces
│
├── Middleware/
│   └── Custom HTTP middleware and error handling
│
├── Properties/
│   └── ASP.NET development configuration
│
├── Program.cs
│   └── Application startup and dependency injection configuration
│
├── appsettings.json
│   └── Application configuration and database connection settings
│
├── appsettings.Development.json
│   └── Development-specific configuration
│
├── nlog.config
│   └── NLog logging configuration
│
└── CarPort.csproj
    └── Project dependencies and .NET configuration
```

## Architecture

The intended flow of the application is:

```text
Client
  │
  ▼
ASP.NET Core Web API
  │
  ▼
Controllers
  │
  ▼
Services
  │
  ▼
Entity Framework Core
  │
  ▼
LINQ
  │
  ▼
Microsoft SQL Server
```

### Controllers

Controllers are responsible for receiving HTTP requests and returning HTTP responses. They should contain minimal business logic and delegate operations to the service layer.

### Services

Services contain application and business logic. They provide a separation between the API endpoints and database operations.

### Models

Models represent the application's core data entities and are mapped to database tables through Entity Framework Core.

### DTOs

DTOs define the data exposed through the API. They prevent database entities from being unnecessarily exposed directly to API clients.

### Data

The `Data` layer contains the Entity Framework Core `DbContext` and database configuration.

### Database

SQL Server is the primary persistent data store. Entity Framework Core is used to translate C# and LINQ queries into SQL, while T-SQL can be used for database-specific functionality and complex operations.

## Development Workflow

Development will follow an iterative Agile approach:

```text
Design
  ↓
Create/Modify Models
  ↓
Configure EF Core
  ↓
Create Migration
  ↓
Update SQL Server
  ↓
Implement Service
  ↓
Implement Controller
  ↓
Test API
  ↓
Commit Changes
```

## Database Development

The project will use a **Code First** Entity Framework Core workflow.

```text
C# Models
    ↓
EF Core DbContext
    ↓
Migration
    ↓
SQL Server Schema
```

Database changes should generally be made through the C# models and EF Core migrations rather than manually modifying the production database.

## Current Status

CarPort is currently in the **initial project setup and architecture phase**.

Current priorities:

* [x] Create ASP.NET Core 8 project
* [x] Configure Git repository
* [ ] Define database entities
* [ ] Create Entity Framework Core `DbContext`
* [ ] Establish SQL Server connection
* [ ] Create initial migration
* [ ] Implement initial API endpoints
* [ ] Configure NLog
* [ ] Configure Swagger/OpenAPI
* [ ] Add validation
* [ ] Add automated testing
* [ ] Implement authentication/authorization
* [ ] Deploy application

## Future Goals

The architecture is intended to support a large relational database with many entities and relationships while maintaining a clean separation between the API, application logic, and database.

As development progresses, additional functionality may include:

* Advanced searching and filtering
* Pagination
* Complex relational queries
* Data import tools
* Authentication and authorization
* API versioning
* Automated testing
* Performance optimization
* Production deployment
