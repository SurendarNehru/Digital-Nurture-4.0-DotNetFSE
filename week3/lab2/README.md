## **Lab 2: Setting Up the Database Context for a Retail Store**

### **Scenario**

The retail store needs a system to store and manage product and category data using SQL Server. A `DbContext` is used to handle connections and object mappings.

### **Objective**

* Define entity models and relationships.
* Configure `AppDbContext` to map to SQL Server.
* Prepare the system for EF Core database operations.

### **Procedure**

**Step 1: Create `Product` and `Category` classes.**

* Defined `Product` and `Category` classes.
* Relationship:

  * One `Category` → Many `Products`
  * One `Product` → One `Category`

**Step 2: Create `AppDbContext` Class**
```csharp
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
public class AppDbContext : DbContext {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=Retail.db");
    }
}
```
### **Output**
![Screenshot 2025-07-06 142150](https://github.com/user-attachments/assets/33729de7-8d34-41d8-89b9-ec1c90922e4e)

* Models and relationships defined.
* `DbContext` configured and ready to manage SQL Server database interaction.
