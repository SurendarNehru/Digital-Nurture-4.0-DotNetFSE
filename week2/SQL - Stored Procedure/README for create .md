# Exercise :Create a Stored Procedure 

# Scenario:
You are tasked with developing a relational database schema for managing employees and their departments in an organization. The solution should support inserting new employee records using a reusable and secure approach.

# Steps Taken:
1. Database Setup and Cleanup:
To ensure a clean environment, existing tables Employees and Departments were dropped using:

2. Creating the Departments Table:
The Departments table was created to hold static information about each department.

3. Creating the Employees Table:
The Employees table was designed to store employee-specific information:

4. Populating Initial Data:
Static data was inserted into the Departments table. Then, 4 employees were added to the Employees table across different departments:

5. Creating Stored Procedure sp_InsertEmployee:
To simplify and standardize employee insertion, a stored procedure named sp_InsertEmployee was created:

6. Testing the Stored Procedure:
The procedure was tested by inserting a new employee:

7. Verifying the Data:
A SELECT * FROM Employees; query was executed to confirm the new entry and validate the entire setup.

# Output:
![Create a Stored Procedure outupt](https://github.com/user-attachments/assets/2f0786bf-a249-49a6-be2c-d832e4267639)

Conclusion:
This exercise demonstrated effective database design using normalization, foreign key constraints, and modular data operations through stored procedures. This approach improves data integrity, security, and developer productivity in enterprise applications.

