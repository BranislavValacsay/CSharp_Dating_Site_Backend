# Dating portal backend written in C#

## About This Project

This repository contains the example codebase for API backend for dating site.


## Built With

- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/) - The web framework used
- [Entity Framework](https://learn.microsoft.com/en-us/ef/) - Communication with SQL Database

## Features
- authentication and authorization
- user filtering on various criteria
- user detailed profile, including gender, location, photos, bio...
- instant messaging
- emails
- possible to "like" user
- functional gallery administration
- presnce tracking
- pagination


### Authentication System

- Secure login endpoint
- Password recovery mechanism


### Internal Management

- API for user and profile management
- user directory data management
- Backend support for internal communication tools
- SignalR for instal messaging
- Error handling


### Admin Dashboard Backend

- user rights adminstration (admin, user)

- CRUD operations for profile listings
- Status management logic (new, active, inactive)


### User Management

- CRUD operations for user accounts
- Role and permission management system


## Technical Specifications
### Authorization & Authentication

- Implement JWT (JSON Web Tokens) for secure authentication
- Role-based access control middleware

### API and Backend Architecture

- RESTful API design and implementation
- DTO (Data Transfer Objects) for data validation and transformation
- Request interceptors for logging, rate limiting, and request processing

### Search Functionality

- Implement search for advanced querying
- Pagination
- Design and implement multi-criteria filtering logic

### Database Design

- Optimize database schema for efficient querying
- Implement database indexing for frequently accessed data
- Database is accessed and processed by Entity Framework

Security Measures

- Implement HTTPS for all communications
- Cross-Origin Resource Sharing (CORS) configuration
- Input sanitization to prevent SQL injection and XSS attacks

Deployment and DevOps

- Containerization using Docker for consistent environments
- CI/CD pipeline setup for automated testing and deployment
- Environment-specific configuration management

### Installation
1. Clone the repository
   ```
   git clone https://github.com/BranislavValacsay/CSharp_Dating_Site_Backend.git
   ```
2. Navigate to the project directory
   ```
   cd CSharp_Dating_Site_Backend
   ```
3. [Any additional setup steps]

### Running the Application
- [Instructions on how to run the application locally]
```
  dotnet run
```

## Remark:
- backend is written with entity framework and running local MS SQL in mind. Code can be tweaked for advanced use.

## Contact

- LinkedIn: [https://www.linkedin.com/in/branislav-valacsay/](https://www.linkedin.com/in/branislav-valacsay/)
- Email: branislav.valacsay@archdev.tech
- Website: http://archdev.tech

---

"Blending creativity with technology to create something useful and engaging."
