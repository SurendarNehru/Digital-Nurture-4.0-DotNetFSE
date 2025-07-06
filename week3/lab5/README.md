## **Lab 5: Retrieving Data from the Database**

### **Scenario**

The store's dashboard needs to display product information, which is retrieved using EF Core.

### **Objective**

* Use EF Core’s async query methods to retrieve records.
* Display product info in the console.

### **Procedure**

**Step 1: Retrieve All Products**
```
var productsList = await context.Products.ToListAsync();
foreach (var p in productsList)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
```
**Step 2: Find by ID**
```
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");
```
**Step 3: FirstOrDefault with Condition**
```
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");
```
* Resolved `ToListAsync` and `FirstOrDefaultAsync` errors by adding:
```
using Microsoft.EntityFrameworkCore;
```
### **Output**
![Screenshot 2025-07-06 151408](https://github.com/user-attachments/assets/9625b6d2-1e63-4d5a-aaf5-e0fe5d6ecac1)

* Retrieved and displayed product data successfully.
* Demonstrated use of EF Core async LINQ queries for real-time data access.

