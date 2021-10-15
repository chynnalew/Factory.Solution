# Dr Sillystringz's Factory

#### an Epicodus project that allows the user to keep track of machine repairs

#### Created By: Chynna Lew

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench

## Description

This application was created to show proficiency in ASP.Net Core MVC many-to-may relationships using mySql, Entity, and Razor. This app allows the user to manage their engineers and the machines they are licensed to fix.
Project requirements:
- create a many to many relationship between engineers and machines
- allow the user to see the relationship from both the engineer page and the machines page
- create a splash page that lists all engineers and machines
- build out full CRUD functionality for at least one of the classes

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/chynnalew/Factory.Solution) repository, or download and open the Zip on your local machine
* Open the Factory.Solution folder in your preferred text editor
* To install required packages, navigate to Factory.Solution/Factory in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
* Create a file named "appsettings.json" in the Factory directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=chynna_lew;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }.
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database:
  - In the terminal, navigate to Factory.Solution/Factory
  - run the command "dotnet ef migrations add Initial"
  - run the command "dotnet ef database update"
* To Make Changes to the Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to Factory.Solution/Factory:
    - "dotnet ef migrations add Initial"
    - "dotnet ef database update"
* To Restore, build, and run the project:
  - Navigate to the Factory.Solution/Factory folder in the command line or terminal
    - Run the command "$ dotnet restore" to restore the project dependencies
    - Run the command "$ dotnet build" to build and compile the project
    - Run the command "$ dotnet run" to build and compile the project

## Known Bugs

* none at this time

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew

## Support and contact details

* [Chynna Lew](github.com/chynnalew) 
* <ChynnaLew@yahoo.com>