# First_App - C# Windows Forms Application

## Overview
This is a simple C# Windows Forms application with login and registration functionality, connected to a local SQL Server database.

## Features
- User login with username/password validation
- New user registration
- Database connectivity using SQL Server LocalDB
- Basic form navigation

## Project Structure
First_App/
├── Database.mdf # Local SQL Server database file
├── Login.cs # Login form handling user authentication
├── Registration.cs # Registration form for new users
├── Home.cs # Main application form after login
├── Program.cs # Main application entry point
└── App.config # Application configuration file

## Database Setup
1. The application uses a LocalDB database file (`Database.mdf`)
2. The database should contain a `Users` table with at least these columns:
   - `Name` (nvarchar) - for usernames
   - `Password` (nvarchar) - for passwords

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/SnipeZoidYT/First_App.git
Open the solution in Visual Studio

Restore NuGet packages if needed

Ensure you have SQL Server LocalDB installed

## Usage
Run the application

On the login screen:

Enter credentials to log in

Click "Register" to create a new account

After successful login, you'll see the Home screen with your username displayed
