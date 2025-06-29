# Exercise 4: Creating a Stored Procedure to Count Employees by Department

# Scenario:
In a company database, management requires a quick way to view the number of employees in each department for workforce analysis and planning. Rather than manually writing SELECT COUNT(*) queries, a stored procedure is designed to automate this task for any department as needed.

# Steps Taken:
1. Setup and Cleanup:
To avoid conflicts, any existing version of the procedure was dropped:

2. Procedure Definition with Parameters:
A stored procedure named sp_CountEmployeesByDepartment was created.

3. Using the Procedure:
The procedure was called using:
CALL sp_CountEmployeesByDepartment(2);
This returns the total number of employees in DepartmentID 2 (e.g., Finance).

You can easily reuse the same procedure with any department by replacing the argument.

# Output:
![Return Data from a Stored Procedure output](https://github.com/user-attachments/assets/e8c99cd0-a665-4ca6-8228-8ddae0543736)

# Conclusion:
This stored procedure simplifies HR reporting by providing a reusable, centralized way to count employees by department. It enhances productivity, reduces manual query errors, and makes it easier for non-technical users or applications to retrieve key metrics with a simple procedure call.
