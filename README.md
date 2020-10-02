# _Pierre's Bakery: Vendor & Order Tracker_

#### _An MVC application to help the user track bakery vendors and the orders belonging to those vendors, October 2nd 2020_

#### By _**Chloe Hellberg**_

## Description

_This application is for a fictional bakery and includes the following functionality when the user runs the aplication:_
  * User can create a new Vendor group to represent each new vendor they supply to
  * Each Vendor has it's own page and the user can add new Orders to it to help keep track of what is typically supplied to that Vendor
  * The Order form includes properties for the title, description, the price, and the date of the orders

_Functionality for the Models are also tested._

## Specs for Testing
| Spec | Input | Output |
| :---------------------------- | :------------- | :------------ |
| 1. Create two classes: Bread and Pastry. | Item Amount | Cost of Each |
| 2. ~~Build Database of Item and corresponding price for each.~~ | ~~Info~~ | ~~Database~~
| 3. Build out CalculateBread Method with initial costs for Bread. | int Bread: 1 | int Cost: $5
| 4. Add functionality in CalculatePastry Method for initial cost of Pastry. | int Pastry: 1 | int Cost $2
| 5. Add logic for Pierre's deals for Bread. Buy 2, get 1 free. | int Bread: 3 | int Cost: $10
| 6. Add logic for Pierre's deals for Pastry. Buy 3 for $5. | int Pastry: 3 | int Cost: $5
| 7. Add additional UI for other fun options. | 1 Rye & 1 Sourdough | Cost: $10


## Setup/Installation Requirements

* _Download Option_
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in terminal to run the program
  * Have fun with Pierre's Bakery Tracker!

* _Cloning Option_
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in terminal to run the program
  * Have fun with Pierre's Bakery Tracker!

## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_If there are any questions or concerns, please email chloe.hellberg@gmail.com. Feel free to contribute to this code._

## Technologies Used

_C#_
_ASP.NET Core_
_Razor_

### License

_Licensed under MIT_

Copyright (c) 2020 **_Chloe Hellberg_**