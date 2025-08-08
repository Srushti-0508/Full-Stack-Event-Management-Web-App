# SOFT20181 Starter Code
# Event Management Web Application

**A full-stack event management system** built with **ASP.NET Core Razor Pages**, **Entity Framework Core**, and **SQLite**, featuring user authentication, role-based access, search & filter, and an admin dashboard for managing events, users, and messages.  

---

## ✨ Quick Overview
- 🎫 **Browse Events** – Detailed event pages with random recommendations.
- 🔍 **Search & Filter** – Find events by keywords or criteria.
- 🔐 **Authentication** – Login & signup with ASP.NET Core Identity.
- 🛡 **Role Management** – Visitor, User, and Admin roles.
- 📩 **Contact Form** – Stores messages directly in the database.
- 📊 **Admin Dashboard** – Manage users, events, and messages.
- 📝 **Ticket Registration** – Currently saves the details to DB.

---

## 📌 Features

### **Public**
- View all events stored in the SQLite database.
- **Search and filter** events for quick navigation.
- Event detail pages display:
  - Event name, image, location, and description.
  - Random recommendations for 3 other events.
- User registration and login via **ASP.NET Core Identity**.
- Contact form to send messages, which are saved to the database.

### **User Roles**
- **Visitor** – Browse events without logging in.
- **User** – Login required; can send messages and register for tickets.
- **Admin** – Full administrative access.

### **Admin Dashboard**  
(Admin only)
- **User Management**:
  - Create new users.
  - Delete existing users.
  - Change passwords.
- **Event Management**:
  - Add, edit, and delete events.
- **Message Management**:
  - View messages submitted through the contact form.

### **Ticket Registration**
- Users can register for tickets via a form.
- Currently **incomplete** – stores ticket registration info in the database but no user dashboard to view registered events yet.

---

## 🛠️ Tech Stack

- **Backend**: ASP.NET Core Razor Pages (C#)
- **Frontend**: HTML, CSS, JavaScript
- **Database**: SQLite with Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **ORM**: Entity Framework Core

---

## ⚙️ Configure the database

2. **Update appsettings.json with your SQLite connection string (if needed)**
3. **Run migrations:**
dotnet ef database update
3. **Run the application**
dotnet run

## Access in browser

If running in Visual Studio, the application will open automatically in your default browser.
The URL will look like https://localhost:xxxx or http://localhost:xxxx (port number may vary).
You can check the exact port in: 
The Visual Studio toolbar (next to the run button), or
Properties/launchSettings.json under "applicationUrl".

## How to run the code

- Download or Clone the repository
- Double click on the .sln file to open it with Visual Studio (or Open Visual Studio and Click "Open Solution")
- In Visual Studio, Click Build menu item 
- Select Clean Solution, then Build Solution 
- Run the code
