## **Lab 3: Using EF Core CLI to Create and Apply Migrations**

### **Scenario**

To keep the database schema in sync with models, EF Core migrations were used to generate and apply changes to SQL Server.

### **Objective**

* Learn to use EF Core CLI tools.
* Generate a migration based on the models.
* Create the database and schema via EF commands.

### **Procedure**

**Step 1: Install EF Core CLI**
```
dotnet tool install --global dotnet-ef
```
**Step 2: Create Initial Migration**
```
dotnet ef migrations add InitialCreate
```
**Step 3: Apply Migration to Create DB**
```
dotnet ef database update
```
**Step 4: Verify in SQL Server**

* Confirmed that `Products` and `Categories` tables were created successfully in the database.

### **Output**
![Screenshot 2025-07-06 142401](https://github.com/user-attachments/assets/f082929f-0adb-409f-a592-56988d213ca2)

* Created and applied an initial migration.
* EF Core generated SQL schema from the C# models.
* Verified database structure in SQL Server.
