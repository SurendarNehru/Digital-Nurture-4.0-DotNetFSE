-- Drop if already exists
DROP PROCEDURE IF EXISTS sp_CountEmployeesByDepartment;

DELIMITER $$

CREATE PROCEDURE sp_CountEmployeesByDepartment (
    IN p_DepartmentID INT
)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END$$

DELIMITER ;

-- Replace 2 with any department ID you want to check
CALL sp_CountEmployeesByDepartment(2);
