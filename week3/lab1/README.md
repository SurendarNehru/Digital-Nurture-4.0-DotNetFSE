## **Lab 1: Understanding ORM with a Retail Inventory System**

### **Scenario**

The retail store required a data access layer that simplifies database operations using C# objects. Object-Relational Mapping (ORM) enables developers to work with databases using familiar object-oriented syntax.

### **Objective**

* Understand the concept of ORM.
* Learn how EF Core maps C# classes to relational database tables.
* Set up a new .NET console project and prepare it to use EF Core.

### **Procedure**

**Step 1: What is ORM?**

* ORM (Object-Relational Mapping) translates C# classes into relational tables.
* Benefits include:

  *  Higher productivity
  *  Easier maintenance
  *  Less need for raw SQL queries

**Step 2: EF Core vs EF Framework**

* **EF Core**: Cross-platform, lightweight, modern (supports LINQ, async queries).
* **EF 6 (Framework)**: Windows-only, more mature, but less flexible.

**Step 3: EF Core 8.0 Features**

* JSON column mapping
* Better performance with compiled models
* Support for interceptors and optimized bulk operations

**Step 4: Create .NET Console App**

```
dotnet new console -n RetailInventory
cd RetailInventory
code .
```

**Step 5: Install EF Core Packages**

```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### **Output**
![Screenshot 2025-07-06 141613](https://github.com/user-attachments/assets/7630d93e-df75-46df-8e66-dd06547b6b69)

* Set up a .NET console app using EF Core.
* Understood how ORM and EF Core simplify data access.
* Installed required EF Core packages successfully.

