# DatabaseSQLServer
This project aims to develop an interface for inserting data related to property purchases, with full CRUD (Create, Read, Update, Delete) functionality. The application allows users to:

Create new real estate transaction records.
View the data stored in the database.
Edit existing information.
Delete records as needed.
The project structure is based on a robust relational system, taking advantage of the previously defined MER (Entity-Relationship Model) and DER (Entity-Relationship Diagram) models, ensuring data consistency and integrity.

Technologies Used
Language: C#
Structure: Entity Framework Core
Entity Framework Core Extensions:
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Front-end: HTML, CSS
Database: SQL Server
Features
Complete CRUD: Creation, reading, updating and deleting information.
Property Management: User-friendly interface to manage property purchase transactions.
Table Relationship: Optimized structure based on MER and DER diagrams.
How to execute the project

Clone the repository:
git clone https://github.com/seu-usuario/DatabaseSQLServer.git
Configure the SQL Server database connection in the appropriate configuration file.

Open the Package Manager Console in Visual Studio and run the following commands to configure the tables in the database:
Add-Migration InitialCreate
Update-Database

Project Structure
Models: Data structures that represent database tables.
Controllers: Layer that manages requests and business rules.
Views: HTML and CSS pages and components that make up the user interface.

Contribution
Feel free to contribute to the project! Just follow the steps:

Fork the repository.
Create a new branch for your changes;
Submit your changes;
Open a Pull Request

