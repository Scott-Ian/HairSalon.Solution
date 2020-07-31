# _Eau Claire's Salon_

#### _A website that manages a hair salon stylists and clientel_

#### By _**Ian Scott**_

## Description

_This is a web application which allows a user to manage a list of stylists and their respective clients. The user can add new clients, stylists, and delete/remove, as well as update values for both._

### User Stories
  * As the salon owner, I need to be able to see a list of all stylists.
  * As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
  * As the salon owner, I need to add a new stylist to our system when they are hired.
  * As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.
  * As the salon owner, I need to be able to update client and stylist information.


## Setup/Installation Requirements

1. This program utilizes .NET version 2.2, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK   version 2.2 or greater patch version, but do not upgrade to a higher minor version number.
2. Clone this repository onto your computer: https://github.com/Scott-Ian/HairSalon.Solution.git
3. In your preferred terminal window, navigate into BestRestaurants.SOLUTIONS/BestRestaurants using cd (i.e. cd desktop/HairSalon.Solution/HairSalon) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore
5. Establish the programs required Database:
  * Utilizing MySqlWorkbench, please create a database named 'ian_scott'. Conversely you can also use the following SQL command: CREATE DATABASE `ian_scott`;
  * Create table 'clients' with the following parameters/SQL instructions:
    >CREATE TABLE `clients` (\
    >`ClientId` int NOT NULL AUTO_INCREMENT,\
    >`Name` varchar(255) DEFAULT NULL,\
    >`DateOfFirstApp` datetime DEFAULT NULL,\
    >`Gender` varchar(255) DEFAULT NULL, \
    >`StylistId` int DEFAULT NULL, \
    >PRIMARY KEY (`ClientId`) \
    >) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci; \
  * Create table 'stylists' with the following parameters/SQL instructions:
    >CREATE TABLE `stylists` ( \
    >`StylistId` int NOT NULL AUTO_INCREMENT, \
    >`Name` varchar(255) DEFAULT NULL, \
    >`DateOfHire` datetime DEFAULT NULL, \
    >`Wage` int DEFAULT NULL, \
    >PRIMARY KEY (`StylistId`) \
    >) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

    **Please note that the SQL code snippets above may include backslashes as a line break for MarkDown viewers, and are not intended as part of the SQL instructions**
5.5 Conversely you can import the database and structure schema directly into your MySQL Workbench by going to Administration->DataImport/Restor and importing the file ian_scott.sql, at the top level of this project, as a Self-Contained File.
6. To initiate this program, run the command: $ dotnet run


## Known Bugs

_There is DbUpdate Concurrency Exception being thrown when a user attempts to submit changes to an existing entry. I am not sure what is causing this._

## Support and contact details

_If you would like to contribute, report bugs, or just chat, please reach out to Ian Scott via email at: chesnekov@gmail.com_

## Technologies Used

_This program utilizes DotNet 2.2, Entity Framework, C#, Html, CSS, SQL database managment/integration, one-to-many database relationships, the Model-View-Controller web design structure, as well as RESTFUL routing, and CRUD functionality._

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Ian Scott**.