### **Exercise : 1. Write Testable Code with Moq**

**Scenario:**
You are developing a transaction-based application where email notifications must be sent to users after each operation. However, for testing purposes, you want to **avoid sending real emails** and instead verify that the **email-sending functionality is called correctly**.
The goal is to unit test the `MailSender` class using **NUnit and mocking** to simulate external dependencies.

### **Steps Taken:**

#### **1. Interface Design for Abstraction:**

To support testability, an interface `IEmailService` was created to represent the email-sending behavior.

#### **2. MailSender Implementation:**

The `MailSender` class depends on `IEmailService` and calls it during operations.

#### **3. Creating the Unit Test Project:**

A test class was created using **NUnit** and **Moq** (a mocking library) to simulate the `IEmailService` dependency without sending real emails.
Install required NuGet packages.

### **Output:**
![Screenshot 2025-06-29 224007](https://github.com/user-attachments/assets/b047eac7-6555-4601-9474-c979578bd763)
### **Conclusion:**

This unit test demonstrates how **mocking and dependency injection** can isolate external systems like email services. By verifying method calls and parameters, the `MailSender` class was effectively tested, ensuring **functionality without side effects**. This practice improves **test reliability**, **maintainability**, and enables safer refactoring.

