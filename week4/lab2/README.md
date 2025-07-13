### **Assignment 2 – Web API using ASP.NET Core (.NET 8)**

# **Student:** Surendar N
# **Week:** 4
# **Assignment:** Integrate Swagger, Test with Postman, and Modify API Routing

---

### **Objectives**

* Add Swagger support to ASP.NET Core Web API using Swashbuckle.AspNetCore
* Understand the use of `ProducesResponseType` in Web API methods
* Test Web API endpoints using Postman
* Understand request structure, headers, body, and response in Postman
* Use and modify route with the `[Route]` attribute
* Learn the concept of using `ActionName` and `Name` attributes in HTTP methods (conceptual)
* Implement simple Read and Write operations using `GET` and `POST`

---

### **Tools Used**

* **Operating System:** Windows 10
* **Editor:** Visual Studio Code (v9)
* **.NET SDK Version:** 8.0
* **API Testing Tools:** Swagger UI, Postman
* **Terminal:** Windows PowerShell

---

### **Steps Performed**

#### **Step 1: Created Web API Project**

* Used the following command to create the project:

  ```
  dotnet new webapi -n WebApiLab2
  cd WebApiLab2
  ```
* This created a basic Web API template with a default WeatherForecast controller.

#### **Step 2: Installed and Configured Swagger**

* Installed Swashbuckle.AspNetCore NuGet package:

  ```
  dotnet add package Swashbuckle.AspNetCore
  ```

* Added Swagger setup inside `Program.cs`:

  * Used `builder.Services.AddSwaggerGen(...)` to define Swagger metadata
  * Used `app.UseSwagger()` and `app.UseSwaggerUI()` to enable UI

* Launched Swagger UI in browser using:

  ```
  https://localhost:<port>/swagger
  ```

* Verified that title, version, contact details, and default controllers were visible.

#### **Step 3: Created Custom `EmployeeController`**

* Created a new file: `Controllers/EmployeeController.cs`
* Added a simple `GET` method returning:

  ```
  ["Surendar", "Raj", "Priya"]
  ```
* The controller used `[Route("Employee")]` and `[HttpGet]` attributes.
* Used `[ProducesResponseType(StatusCodes.Status200OK)]` to specify response type.
* Tested in Swagger UI using Try it out → Execute

#### **Step 4: Tested in Postman**

* Opened Postman and created a new request:

  * `GET https://localhost:<port>/Employee`
* Verified:

  * Response body showed the employee list
  * Response status was 200 OK

#### **Step 5: Modified Controller Route**

* Changed controller route from `[Route("Employee")]` to `[Route("Emp")]`
* Retested in Postman using:

  ```
  GET https://localhost:<port>/Emp
  ```
* Confirmed it returned the same JSON data successfully

### **OUTPUT**
<img width="1920" height="1080" alt="Screenshot 2025-07-13 214951" src="https://github.com/user-attachments/assets/2b2de5b3-12fe-4fcb-a95b-179ae59fc2f4" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 215129" src="https://github.com/user-attachments/assets/5e68cad8-e9a4-40fa-8f4f-374879d23a71" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 215528" src="https://github.com/user-attachments/assets/415a5d45-4dca-43ca-9f7a-6451a8ef08f0" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 215643" src="https://github.com/user-attachments/assets/15ad9a41-2165-4e78-8ffa-bc950d8a0a2f" />
<img width="1920" height="1080" alt="Screenshot 2025-07-13 215711" src="https://github.com/user-attachments/assets/81a92e66-f8aa-473b-a134-c7aeaac89dfb" />

### **Conclusion**

Successfully completed Lab 2 by integrating Swagger into a .NET 8 Web API project, creating a custom controller for employee data, and testing endpoints using both Swagger UI and Postman. Understood how to document API responses, structure routing, and interact with HTTP clients. This lab laid the groundwork for building more advanced RESTful APIs in future labs.


