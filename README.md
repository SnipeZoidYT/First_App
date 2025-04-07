# 🚀 First_App - C# Windows Forms Application

<div align="center">
  
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

</div>

## 🌟 Features
- 🔐 User login with username/password validation
- 📝 New user registration
- 🗃️ Database connectivity using SQL Server LocalDB
- 🖥️ Basic form navigation
- 👋 Personalized welcome message on Home screen

## 📂 Project Structure
First_App/
├── 📁 Database.mdf # Local SQL Server database file
├── 📄 Login.cs # Login form handling user authentication
├── 📄 Registration.cs # Registration form for new users
├── 📄 Home.cs # Main application form after login
├── 📄 Program.cs # Main application entry point
└── 📄 App.config # Application configuration file

Copy

## 🛠️ Setup & Installation

### 🗄️ Database Setup
1. The application uses a LocalDB database file (`Database.mdf`)
2. Ensure your database has a `Users` table with:
   - `Name` (nvarchar) - for usernames 👤
   - `Password` (nvarchar) - for passwords 🔒

### 💻 Installation
```bash
git clone https://github.com/SnipeZoidYT/First_App.git
cd First_App
Open the solution in Visual Studio 🖥️

Restore NuGet packages if needed 📦

Ensure SQL Server LocalDB is installed 🗄️

⚙️ Configuration
The connection string is in Login.cs:

csharp
Copy
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True"
✏️ Update this path to your actual database location

🎮 How to Use
▶️ Run the application

🔑 Login Screen:

Enter credentials to log in

Click "Register" to create new account 📝

� Home Screen appears after login with your username displayed

🚧 Known Issues & Improvements
Area	Improvement Needed
🔒 Security	Passwords stored in plain text (should be hashed)
🛡️ Validation	Add password complexity requirements
🧩 Error Handling	More comprehensive try-catch blocks
🗃️ Database	Move connection string to config file
📜 License
MIT License - Free to use, modify, and distribute! 🎉

<div align="center">
Made with ❤️ by [YourName] | Give it a ⭐ if you like it!

</div>
