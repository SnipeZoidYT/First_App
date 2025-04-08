# 🚀 First_App – C# Windows Forms Bank App

<div align="center">

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

</div>

---

## 🌟 Features
- 🔐 User login with username/password validation  
- 📝 New user registration  
- 🗃️ Database connectivity using **SQL Server LocalDB**  
- 🖱️ Simple and intuitive form navigation  
- 👋 Personalized welcome screen after login  

---

## 📂 Project Structure

```plaintext
First_App/
├── Database.mdf           # Local SQL Server database file
├── Login.cs               # Login form and authentication logic
├── Registration.cs        # Form for new user registration
├── Home.cs                # Main dashboard after login
├── ViewAccount.cs         # Displays account details
├── Program.cs             # Application entry point
└── App.config             # Application configuration (connection strings, etc.)
```

---

## 🛠️ Setup & Installation

### 📦 Prerequisites
- ✅ Visual Studio installed
- ✅ .NET Framework support
- ✅ SQL Server LocalDB installed

### 🗄️ Database Setup
1. This app uses `Database.mdf` (LocalDB).
2. Ensure it contains a `Users` table with:
   - `Name` (nvarchar) – Username 👤  
   - `Password` (nvarchar) – Password 🔒  
   - `Age` (int) – Optional  
   - `Email` (nvarchar) – Optional  
   - `Balance` (decimal) – Account balance 💰  

### 🖥️ Installation Steps

```bash
git clone https://github.com/SnipeZoidYT/First_App.git
cd First_App
```

1. Open the solution in Visual Studio  
2. Restore NuGet packages if prompted  
3. Update the database path in the connection string:

```csharp
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True"
```

> ✏️ Replace the path above with your local `.mdf` file location.

---

## 🎮 How to Use

- ▶️ **Run** the app via Visual Studio  
- 🔑 **Login** screen appears first  
  - Enter credentials or click **Register** to create a new account  
- 🏠 **Home** screen appears after login  
  - Displays a welcome message and account actions  
- 🧾 **View Account** screen shows your:
  - Name
  - Age
  - Email
  - Balance  

---

## 🚧 Known Issues & Future Improvements

| Area           | Suggestion                                         |
|----------------|----------------------------------------------------|
| 🔒 Security     | Hash and salt passwords instead of plain text      |
| 🛡️ Validation   | Enforce strong password rules                      |
| 🧩 Error Handling | Add broader try-catch with detailed messages      |
| ⚙️ Configuration | Move connection string to `App.config`            |

---

## 📜 License

**MIT License** – Free to use, modify, and share 🎉

---

<div align="center">

Made with ❤️ by **Christopher**  
⭐ Star this repo if you like it!

</div>
