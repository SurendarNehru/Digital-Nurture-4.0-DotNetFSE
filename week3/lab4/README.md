## **Lab 4: Inserting Initial Data into the Database**

### **Scenario**

The store manager wants to seed the system with categories and initial products for operations.

### **Objective**

* Use EF Core to insert data using `AddRangeAsync` and `SaveChangesAsync`.
* Ensure the database is populated with test data.

### **Procedure**
**Step 1: Insert Data in `Program.cs`**

```csharp
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };
var clothing = new Category { Name = "Clothing" };
var stationery = new Category { Name = "Stationery" };

await context.Categories.AddRangeAsync(electronics, groceries, clothing, stationery);

var products = new List<Product>
{
    new Product { Name = "Laptop", Price = 79999, Category = electronics },
    new Product { Name = "Smartphone", Price = 40999, Category = electronics },
    new Product { Name = "Bluetooth Speaker", Price = 2499, Category = electronics },

    new Product { Name = "Rice Bag", Price = 1200, Category = groceries },
    new Product { Name = "Wheat Flour", Price = 438, Category = groceries },
    new Product { Name = "olive Oil", Price = 543, Category = groceries },

    new Product { Name = "Men's Shirt", Price = 799, Category = clothing },
    new Product { Name = "Women's Kurti", Price = 1100, Category = clothing },
    new Product { Name = "Jeans", Price = 1299, Category = clothing },

    new Product { Name = "Note", Price = 50, Category = stationery },
    new Product { Name = "Parker Pen", Price = 120, Category = stationery },
    new Product { Name = "Marker Set", Price = 200, Category = stationery }
};

await context.Products.AddRangeAsync(products);

await context.SaveChangesAsync();

Console.WriteLine("Data inserted successfully");
```
**Step 2: Run the App**
```
dotnet run
```
**Step 3: Verify in SQL Server**

* Checked tables to confirm categories and products were added.

### **Output**
![Screenshot 2025-07-06 143354](https://github.com/user-attachments/assets/65e3c02d-2ac3-46ec-8204-ead713df3c1b)

* Successfully inserted initial data.
* EF Core handled object-to-database translation without raw SQL.
