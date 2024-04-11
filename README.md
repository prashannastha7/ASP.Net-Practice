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

## Open Package Manager Console
Tools > NuGet Package Manager > Package Manager Console

## Run migration commands
Add-Migration "InitialMigration"
Update-Database  # for database synchronization

Build and run the application using Visual Studio.



# 2. NpWalkz
   NpWalkz is a project developed to practice building RESTful APIs using ASP.NET Web API templates. This project serves as an educational exercise to understand how to create and implement web APIs with the ASP.NET framework.

## Overview

The purpose of NpWalkz is to provide a basic implementation of a RESTful API for managing walk entries. Users can perform (Create, Read) operations on region records, including details such as image, location.

## Technologies Used

- **ASP.NET Web API**: The framework for building HTTP services that can reach a broad range of clients, including browsers and mobile devices.
- **C#**: The programming language used for backend development within the ASP.NET framework.
- **Entity Framework**: An ORM (Object-Relational Mapping) framework for .NET used to interact with the database.
- **SQL Server**: A relational database management system used for data storage.
  
## Installation and Setup

To run this ASP.NET Web API project locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone(https://github.com/prashannastha7/ASP.Net-Projects/tree/main/NpWalkz/NpWalks)
<br>

### API Endpoints
The following API endpoints are available:

- GET /api/regions: Get all regions. <br>
- GET /api/region/{id}: Get a specific region by ID. <br>
- POST /api/region: Create a new region entry.


   ![image](https://github.com/prashannastha7/ASP.Net-Projects/assets/92351587/4cd42851-1b7c-432c-b9fd-c832df464a4a)

