**Assignment – JWT Authentication in ASP.NET Core Web API (.NET 9)**

**Student**: Surendar N
**Week**: 5
**Assignment**: Implement Authentication and Role-Based Authorization using JWT in a .NET Core Web API

---

### Objectives

* Understand how JWT (JSON Web Token) works for stateless authentication
* Implement user login and secure token generation in Web API
* Add role-based authorization using JWT claims
* Protect endpoints using `[Authorize]` and `[Authorize(Roles = "...")]` attributes
* Test authenticated routes using Swagger UI and Postman

---

### Tools Used

* **Operating System**: Windows 10
* **Editor**: Visual Studio Code
* **.NET SDK Version**: 9
* **API Testing Tool**: Postman
* **Terminal**: PowerShell

---

### Steps Performed

**Step 1: Created Web API Project**

* Used the command `dotnet new webapi -n Jwtapi` to create a new Web API project
* Opened the project in Visual Studio Code

**Step 2: Added AuthenticateController**

* Created a controller named `AuthenticateController`
* Added a `Login` endpoint that accepts username and password
* Validated hardcoded credentials (admin/password)
* Generated a JWT token if login is valid
* Added `GenerateJwtToken` method to include claims like `Name` and `Role`

**Step 3: Configured appsettings.json**

* Added JWT configuration keys like Key, Issuer, Audience, DurationInMinutes under the "Jwt" section

```
"Jwt": {
  "Key": "MySecretKey12345678",
  "Issuer": "YourIssuer",
  "Audience": "YourAudience",
  "DurationInMinutes": "60"
}
```

**Step 4: Configured Authentication in Program.cs**

* Configured JWT authentication with `AddAuthentication()` and `AddJwtBearer()`
* Used TokenValidationParameters to validate the token

**Step 5: Created AdminController with Role-Based Access**

* Created `AdminController` with an endpoint `/api/admin/dashboard`
* Secured the endpoint using `[Authorize(Roles = "Admin")]`
* Only users with the role `Admin` can access this endpoint

---

### Output 

<img width="1920" height="1080" alt="Screenshot 2025-07-20 223238" src="https://github.com/user-attachments/assets/84a4f6fe-6b92-40d6-a449-2c450f36d434" />
<img width="1920" height="1080" alt="Screenshot 2025-07-20 221113" src="https://github.com/user-attachments/assets/0f5ce941-db2b-440a-995a-cbea18c8992f" />
<img width="1920" height="1080" alt="Screenshot 2025-07-20 221125" src="https://github.com/user-attachments/assets/95f7c6b2-3f15-4fde-8322-c347dc98e291" />
<img width="1920" height="1080" alt="Screenshot 2025-07-20 222456" src="https://github.com/user-attachments/assets/83493dbd-e15c-4aa4-9125-d5d0dc969486" />
<img width="1920" height="1080" alt="Screenshot 2025-07-20 222603" src="https://github.com/user-attachments/assets/5e030626-a2d2-40ac-9337-ac93af44634c" />
<img width="1920" height="1080" alt="Screenshot 2025-07-20 222624" src="https://github.com/user-attachments/assets/ab881e2c-5f9c-440b-8236-cc5193a8725a" />


### Conclusion

Successfully created a secure login system using JWT in ASP.NET Core Web API. Implemented token generation, user validation, and protected admin routes using role-based authorization. Tested all scenarios using Postman and Swagger. This exercise laid the foundation for implementing secure APIs in microservices architecture.

