# Smart Meal Distribution System (SPPG)

A desktop application built with **C# Windows Forms** and **SQL Server** for managing daily operations of a Smart Meal Distribution Center (SPPG).

The system supports employee management, raw material inventory, recipient schools, kitchen requirements, supplier orders, production monitoring, distribution tracking, reporting, and user profile management.

---

## Features

### Dashboard
- Summary cards for:
  - Employees
  - Raw Materials
  - Schools
  - Orders
  - Order Status Breakdown
  - Distribution Status

### Employee Management
- Create, Read, Update, Delete (CRUD)
- Search by employee name or position

### Raw Material Management
- CRUD operations
- Search functionality
- Category and unit selection

### Recipient School Management
- CRUD operations
- Search by school name

### Kitchen Requirements
- CRUD operations
- Linked to raw materials

### Supplier Orders
- CRUD operations
- Order workflow:
  - Pending
  - Processing
  - Completed
- Status badges with color indicators

### Production & Distribution Monitoring
- CRUD operations
- Production status tracking
- Distribution status tracking
- Date and status filtering

### Reports
- Raw Material Reports
- Kitchen Requirement Reports
- Supplier Order Reports
- Distribution Reports
- Date filtering support

### User Profile
- Display currently logged-in user information

### Authentication
- Login
- Logout

---

## Project Structure

```text
SPPG/
│
├── SPPG.sln
│
├── SPPG/
│   ├── App.config
│   ├── Program.cs
│   │
│   ├── Helpers/
│   │   ├── Database
│   │   ├── Session
│   │   ├── UiTheme
│   │   └── UiHelper
│   │
│   ├── Forms/
│   │   ├── FormLogin
│   │   ├── FormMain
│   │   └── Edit Dialogs
│   │
│   └── UserControls/
│       ├── Dashboard
│       ├── Employees
│       ├── RawMaterials
│       ├── Schools
│       ├── KitchenRequirements
│       ├── SupplierOrders
│       ├── Monitoring
│       ├── Reports
│       └── Profile
│
├── Database/
│   └── database.sql
│
└── README.md
```

---

## Technology Stack

| Component | Technology |
|------------|------------|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI | Windows Forms |
| Database | SQL Server |
| Data Access | ADO.NET (System.Data.SqlClient) |
| Architecture | UserControl-based navigation |

---

## Requirements

### Software

- Windows 10 / 11
- Visual Studio 2022
  - Workload: **.NET Desktop Development**
- .NET Framework 4.7.2
- SQL Server (one of the following):
  - SQL Server LocalDB
  - SQL Server Express
  - SQL Server Standard / Enterprise

### Recommended

SQL Server LocalDB

```text
(localdb)\MSSQLLocalDB
```

---

## Database Setup

### 1. Create Database

Open SQL Server Management Studio (SSMS) or Azure Data Studio.

Run:

```text
Database/database.sql
```

The script will:

- Drop existing database (if available)
- Create database
- Create tables
- Insert sample data

---

### 2. Configure Connection String

Open:

```text
SPPG/App.config
```

Update the connection string if needed:

```xml
<add name="SPPGDb"
     connectionString="Data Source=YOUR_SERVER;Initial Catalog=SPPGDb;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

Examples:

```text
(localdb)\MSSQLLocalDB
```

```text
.\SQLEXPRESS
```

```text
localhost
```

---

## Running the Application

1. Open the solution in Visual Studio 2022.
2. Ensure the database has been created successfully.
3. Verify the connection string.
4. Press:

```text
F5
```

or

```text
Ctrl + F5
```

to run the application.

---

## Default Login Accounts

### Operator

| Field | Value |
|---------|---------|
| Username | petugas |
| Password | petugas123 |

### Supervisor

| Field | Value |
|---------|---------|
| Username | supervisor |
| Password | supervisor123 |

---

## User Roles

### Operator

Responsible for operational data entry and maintenance.

Accessible modules:

- Dashboard
- Employees
- Raw Materials
- Schools
- Kitchen Requirements
- Supplier Orders
- Profile

Permissions:

- Create
- Edit
- Delete
- Update Order Status

---

### Supervisor

Responsible for monitoring and validation.

Accessible modules:

- Dashboard
- Supplier Orders
- Production & Distribution Monitoring
- Reports
- Profile

Permissions:

- View operational data
- Validate order status
- Validate production status
- Validate distribution status

---

## Troubleshooting

### Unable to Connect to Database

Check the following:

- SQL Server or LocalDB is running
- Database script has been executed
- Connection string is correct

### Verify LocalDB

```bash
sqllocaldb info
```

```bash
sqllocaldb start MSSQLLocalDB
```

### Reset Database

Simply run:

```text
Database/database.sql
```

again.

The script will recreate the database and seed data automatically.

---

## License

This project is provided for educational and demonstration purposes.
