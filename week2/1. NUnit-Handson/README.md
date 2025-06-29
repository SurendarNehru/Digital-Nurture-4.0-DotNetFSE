### **Exercise 5: Unit Testing a Calculator Library Using NUnit**

**Scenario:**
You are working on a core utility called `CalcLibrary` that performs basic arithmetic operations such as addition, subtraction, multiplication, and division. To ensure the reliability and correctness of this utility, unit tests are implemented using the **NUnit framework**.

### **Steps Taken:**

#### **1. Project Initialization:**

A C# solution was created with two projects:

**`CalcLibrary`**: Contains methods for arithmetic operations.
**`CalcLibrary.Tests`**: A test project using **NUnit** to validate the functionality of `CalcLibrary`.

#### **2. Creating the Calculator Class (`CalcLibrary`):**

A class named `Calculator` was defined with the following methods:

#### **3. Writing Unit Tests in NUnit (`CalcLibrary.Tests`):**

A test class `CalculatorTests` was created to test each method in isolation using `[TestCase]` attributes for multiple input values.

#### **4. Running the Tests:**

Tests were executed using the **Test Explorer** in Visual Studio. All test cases passed, including handling of exceptions.

### **Output:**
![Nunit](https://github.com/user-attachments/assets/9e1c197d-5709-4677-9d9b-582c0a5b6a3f)

### **Conclusion:**

The use of NUnit enabled **automated and isolated testing** of `CalcLibrary`. This ensures that individual methods work as expected and allows for **regression-free development** in future updates. The structure also promotes **test-driven development (TDD)** practices in the project.

