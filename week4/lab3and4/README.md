### **Assignment – Web API Lab 3 & Lab 4 Combined**

# **Student:** Surendar N
# **Week:** 4
# **Assignment:** Implement advanced Web API features with model binding, filters, and update operations using ASP.NET Core (.NET 8)

---

### **Objectives**

* Demonstrate creation of Web API using custom model class
* Understand and apply `HttpGet`, `HttpPut` with `[FromBody]` binding
* Use custom filters: `Authorization` and `Exception` filters
* Use `ProducesResponseType` to document HTTP status responses
* Test APIs using Swagger UI and Postman

---

### **Tools Used**

* **Operating System:** Windows 10
* **Editor:** Visual Studio Code v9
* **.NET SDK Version:** .NET 8.0
* **API Testing Tools:** Swagger UI, Postman
* **Terminal:** Windows CMD / PowerShell

---

### **Steps Performed**

**Step 1: Created ASP.NET Core Web API Project**
Used the following command to create the project:

```
dotnet new webapi -n WebApiLab3and4
```

This created a standard Web API project with `Program.cs`, `Controllers`, and sample files.

---

**Step 2: Created Custom Model Classes**
Added a `Models` folder and created the following classes:

* **Department.cs** with `Id`, `Name`
* **Skill.cs** with `Id`, `SkillName`
* **Employee.cs** with all properties including nested `Department`, `Skill` list, and `DateOfBirth`

---

**Step 3: Created EmployeeController with Required Endpoints**
Created a controller `EmployeeController` and added:

* `GET /employee/getstandard` to return a static list of employees
* `PUT /employee/{id}` to update employee details based on user input
* `GET /employee/throwexception` to simulate exception for testing

All methods returned appropriate HTTP status codes using `[ProducesResponseType]`.

---

**Step 4: Created and Applied Custom Filters**

* **CustomAuthFilter.cs**

  * Validated presence of `Authorization` header and checked if it includes "Bearer"
  * Returned BadRequest if missing or invalid

* **CustomExceptionFilter.cs**

  * Implemented `IExceptionFilter` to catch unhandled exceptions
  * Logged error messages to `error_log.txt`
  * Returned 500 status code with a generic error message

Filters were registered in `Program.cs` and applied using `[ServiceFilter]`.

---

**Step 5: Configured Swagger UI with Authorization Button**

Modified `Program.cs` to include:

* Swagger security definitions
* Enable Bearer token support
* Register filters and Swagger UI

Ran the project and navigated to `http://localhost:5126/swagger` to test APIs with headers.

---

### **Output Samples**

**GET /employee/getstandard**
Headers:

```
Authorization: Bearer testtoken
```

Response:

```
[
  {
    "id": 1,
    "name": "John",
    "salary": 50000,
    "permanent": true,
    "department": {
      "id": 1,
      "name": "HR"
    },
    "skills": [
      {
        "id": 1,
        "skillName": "C#"
      }
    ],
    "dateOfBirth": "1990-01-01T00:00:00"
  }
]
```

**PUT /employee/1**
Headers:

```
Authorization: Bearer testtoken
Content-Type: application/json
```

Body:

```
{
  "id": 1,
  "name": "Updated John",
  "salary": 60000,
  "permanent": true,
  "department": { "id": 1, "name": "HR" },
  "skills": [{ "id": 1, "skillName": "C#" }],
  "dateOfBirth": "1990-01-01T00:00:00"
}
```

Response:

```
{
  "id": 1,
  "name": "Updated John",
  "salary": 60000,
  ...
}
```

**GET /employee/throwexception**
Response:

```
"An error occurred"
```

Logged in `error_log.txt` as:

```
2025-07-13 22:14:12: This is a test exception.
```

---
## **OUTPUT**
<img width="1920" height="1080" alt="Screenshot 2025-07-13 225850" src="https://github.com/user-attachments/assets/ac4d4e68-8645-49e6-9d43-b63e34b518cb" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 225911" src="https://github.com/user-attachments/assets/d00450fd-7aad-4b2a-8eeb-1db4973bc1e3" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 230539" src="https://github.com/user-attachments/assets/da90903d-4aea-4555-985f-3462be1c9d84" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 231551" src="https://github.com/user-attachments/assets/31a4d629-01d5-49e2-87f6-1f47c1c402a6" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 230548" src="https://github.com/user-attachments/assets/cb038d12-d83a-41e2-9a26-04866c319785" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 231950" src="https://github.com/user-attachments/assets/c32a9799-1cc0-4834-8dd1-3474cc1b10fa" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 231551" src="https://github.com/user-attachments/assets/daefaf4d-a061-43de-a47d-324dd143b1e6" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 230727" src="https://github.com/user-attachments/assets/ded24617-3ca7-4b81-b4bd-defda235b95c" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 231950" src="https://github.com/user-attachments/assets/b934c8c9-64e3-4a3c-b659-8a6f1c196e7f" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 232123" src="https://github.com/user-attachments/assets/67ee3e27-bdda-4540-9ba9-435ef2d6dfc6" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 232626" src="https://github.com/user-attachments/assets/807f41e8-db84-4972-a43c-1314d5ec4b62" />



### **Conclusion**

Successfully created and tested a RESTful Web API using ASP.NET Core (.NET 8) by combining the tasks from Lab 3 and Lab 4. Developed strong understanding of action verbs, model binding, custom filters, error handling, and testing with Swagger UI and Postman. This assignment helped build confidence in developing secure and maintainable APIs in .NET.
