# _Eau Claire's Salon_

#### _A website that manages a hair salon stylists and clientel_

#### By _**Ian Scott**_

## Description

_Long description._

### User Stories
  * As the salon owner, I need to be able to see a list of all stylists.
  * As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
  * As the salon owner, I need to add a new stylist to our system when they are hired.
  * As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.


  CREATE TABLE `ian_scott`.`clients` (
  `ClientId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL DEFAULT 'Null',
  `DateOfFirstApp` DATE NULL DEFAULT NULL,
  `Gender` VARCHAR(255) NULL DEFAULT 'Null',
  `StylistId` INT NULL DEFAULT 0,
  PRIMARY KEY (`ClientId`));

  CREATE TABLE `ian_scott`.`stylists` (
  `StylistId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL DEFAULT 'Null',
  `DateOfHire` DATE NULL DEFAULT NULL,
  `Wage` INT NULL DEFAULT 0,
  PRIMARY KEY (`StylistId`));

## Setup/Installation Requirements

1. This program utilizes .NET version 3.1, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK   version 2.2 or greater patch version, but do not upgrade to a higher minor version number.
2. Clone this repository onto your computer: https://github.com/...
3. In your preferred terminal window, navigate into BestRestaurants.SOLUTIONS/BestRestaurants using cd (i.e. cd desktop/BestRestaurants.SOLUTIONS/BestRestaurants) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore
5. To initiate this program, run the command: $ dotnet run
6. To run the test suite included with this project, within the terminal navigate into BestRestaurants.TESTS and run the following commands:
    * $ dotnet restore
    * $ dotnet test


## Known Bugs

_ _

## Support and contact details

_Contact me at...._

## Technologies Used

- C#
- .NET

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Ian Scott**.