# Blog Application (ASP.NET Core 9 MVC)

> **Note:** This project is a comprehensive demonstration of building a full-stack web application using the latest **ASP.NET Core 9**, **MVC architecture**, and **Entity Framework Core**. It features a complete CRUD system for blogging and secure user authentication.

## 📖 Overview

This application serves as a modern blogging platform where users can register, log in, and manage blog posts. It showcases best practices in .NET development, including the implementation of the **Repository Pattern** for cleaner code architecture and **Identity** for robust security.

## 🛠️ Tech Stack

* **Framework:** ASP.NET Core 9 MVC
* **Database:** SQL Server
* **ORM:** Entity Framework Core (EF Core) Code-First
* **Authentication:** ASP.NET Core Identity
* **Frontend:** Razor Views (.cshtml), Bootstrap 5
* **Architecture:** Model-View-Controller (MVC) with Repository Pattern & Dependency Injection

## ✨ Features

* **📝 Full CRUD Operations:** Create, Read, Update, and Delete functionality for blog posts.
* **🔐 User Authentication:** Secure registration and login system using Identity.
* **🎨 Responsive UI:** Styled with Bootstrap for mobile and desktop compatibility.
* **🗄️ Database Management:** Automated database setup using EF Core Migrations.
* **🏗️ Clean Architecture:** Implements Dependency Injection (DI) and the Repository Pattern to decouple logic.

## 🚀 How to Run the Application

Follow these steps to get the project running on your local machine.

### Prerequisites

* [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
* [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or LocalDB
* [Visual Studio 2022](https://visualstudio.microsoft.com/) (v17.12 or later recommended for .NET 9)

### Installation Steps

1.  **Clone the Repository**
    ```bash
    git https://github.com/mesailesh7/MotivateMeBlog.git
    cd MotivateMeBlog
    ```

2.  **Configure Database**
    * Open `appsettings.json`.
    * Update the `ConnectionStrings:DefaultConnection` value to match your local SQL Server instance.
    * *Example:* `"Server=.;Database=BlogAppDb;Trusted_Connection=True;TrustServerCertificate=True;"`

3.  **Run Migrations**
    Open your terminal or Package Manager Console in Visual Studio and run:
    ```bash
    dotnet ef database update
    ```
    *This command creates the database and all required tables (Posts, Users, Roles) automatically.*

4.  **Run the Application**
    ```bash
    dotnet run
    ```
    *Open your browser to `http://localhost:5000` (or the port shown in your terminal).*

## 📸 Screenshots

![Home Page](./screenshots/home.png)
*(Place a screenshot of your blog feed here)*

## 📂 Project Structure

* **Controllers:** Handles user requests (HomeController, BlogController, AccountController).
* **Models:** Defines data structure (BlogPost, User).
* **Data:** Contains the DbContext and Repository implementations.
* **Views:** Razor files for rendering the UI.
* **wwwroot:** Static files (CSS, JS, Images).

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 👤 Author

* **Sunny** 
