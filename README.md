# 1. Student Portal - ASP.NET MVC CRUD App
[Students-Portal](https://github.com/prashannastha7/ASP.Net-Projects/tree/main/StudentPortal)<br>
This project is an ASP.NET MVC CRUD (Create, Read, Update, Delete) application built using .NET 8 MVC template in Visual Studio 2022. It incorporates Entity Framework Core for data persistence with a SQL Server database. The application follows the Model-View-Controller (MVC) architectural pattern, leveraging ASP.NET for web development.

## Features

- **CRUD Operations**: Implement basic CRUD functionalities for managing student records.
- **Entity Framework Core**: Utilize EF Core for data modeling and database interactions.
- **Bootstrap 5**

## Prerequisites

Before running the project locally, ensure you have the following installed:

- Visual Studio 2022
- .NET 8 SDK
- SQL Server

## Getting Started

1. Clone this repository to your local machine.
   
   ```bash
   git clone (https://github.com/prashannastha7/ASP.Net-Projects/tree/main)


2.  Open the solution file (StudentPortal.sln) in Visual Studio 2022.

3.  Restore NuGet packages for the solution.

4.  Set up the database using Entity Framework Core migrations:

```bash
# Open Package Manager Console
Tools > NuGet Package Manager > Package Manager Console

# Run migration commands
Add-Migration "InitialMigration"
Update-Database  # for database synchronization

 Build and run the application using Visual Studio. 
