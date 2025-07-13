**Assignment 5 – Web API with JWT Authentication and CORS**
# **Student:** Surendar N
# **Week:** 5
# **Assignment:** Secure Web API using JWT Token Authentication and CORS

---

### **Objectives**

* Enable CORS for accessing Web API from a local frontend application
* Implement JWT-based authentication using Bearer tokens
* Secure Web API endpoints using the `[Authorize]` attribute and roles
* Learn how to configure authentication and authorization in `Program.cs`
* Use `AuthController` to generate JWT tokens with claims
* Test token-based access and role filtering via Postman
* Handle unauthorized and expired token scenarios
* Learn token structure, claims, and validation flow

---

### **Tools Used**

* **Operating System:** Windows 10
* **Editor:** Visual Studio Code (v9)
* **.NET SDK Version:** 8.0
* **API Testing Tool:** Postman
* **Terminal:** Windows Command Prompt / PowerShell

---

### **Steps Performed**

**Step 1: Created a Web API Project**
Used the following command:

```
dotnet new webapi -n WebApiLab5
```

This generated a starter Web API project with default structure and Swagger enabled.

---

**Step 2: Installed Required Packages**
Installed the following NuGet packages to support authentication and Swagger:

* Microsoft.AspNetCore.Authentication.JwtBearer
* Microsoft.IdentityModel.Tokens
* Microsoft.AspNetCore.Cors
* Swashbuckle.AspNetCore

---

**Step 3: Enabled CORS in Program.cs**
Added a CORS policy called `AllowLocalhost` to allow requests from local frontend (Angular/React).

---

**Step 4: Configured JWT Authentication**
Added authentication setup in `Program.cs` using `AddAuthentication` and `AddJwtBearer`.
Used a secret key (`mysuperdupersecretkey1234567890!!`) with HMAC SHA256 algorithm.

---

**Step 5: Created AuthController**
Created `AuthController` to generate a JWT token using the `GenerateJSONWebToken()` method.

* Token includes role `"Admin"` and a short expiration time (2–5 mins).
* Token is returned from `GET /Auth` endpoint.
* Token includes claims: `UserId` and `Role`.

---

**Step 6: Protected EmployeeController**

* Used `[Authorize(Roles = "Admin,POC")]` to restrict access
* Endpoint `GET /Employee` returns a list of hardcoded employees
* Access allowed only if valid token with correct role is present in the request

---

**Step 7: Tested API with Postman**

**GET /Auth**: Received valid JWT token
**GET /Employee** with token: Success (200 OK)
**GET /Employee** without token: 401 Unauthorized
**GET /Employee** with invalid token: 401 Unauthorized
**GET /Employee** after token expiry: 401 Unauthorized
**GET /Employee** with wrong role: 401 Unauthorized

--
# **OUTPUT**
<img width="1920" height="1080" alt="Screenshot 2025-07-14 002125" src="https://github.com/user-attachments/assets/27ea0c2c-bc5e-481a-8230-16ce860e9fdb" />
<img width="1920" height="1080" alt="Screenshot 2025-07-14 002214" src="https://github.com/user-attachments/assets/a3d1312b-f834-457e-bdd6-674e2042eccd" />
<img width="1920" height="1080" alt="Screenshot 2025-07-14 002300" src="https://github.com/user-attachments/assets/8c4dde26-7c4f-4ffe-ae23-20239abee9b0" />
<img width="1920" height="1080" alt="Screenshot 2025-07-14 002641" src="https://github.com/user-attachments/assets/3b1fc14d-09e7-4eef-8114-cec9388b66e4" />


### **Conclusion**

Successfully created and secured a Web API using JWT Token Authentication and CORS in ASP.NET Core 8.
Tested all cases including valid, missing, expired, and invalid tokens.
Learned how claims, roles, and HTTP status codes work with JWT.
This hands-on forms a solid base for secure enterprise Web API development.
