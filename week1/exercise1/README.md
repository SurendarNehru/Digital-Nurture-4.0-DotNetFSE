## Exercise 1: Implementing the Singleton Pattern
 
## Scenario:
To maintain consistent and centralized logging across the application, you are tasked with ensuring that only a single instance of the logging utility class exists during the application's execution.

## Steps Taken:
## 1.Project Initialization:
A new C# console application was created to implement the Singleton design pattern.

## 2.Creating the Singleton Class:
A class named Logger was designed with a private constructor to prevent external instantiation. A private static field was used to hold the single instance of the class.

## 3.Applying Singleton Logic:
A public static method was provided to access the instance. This method ensures that only one Logger object is created and reused throughout the application lifecycle.

## 4.Verifying Singleton Behavior:
A test class was developed to create multiple references to the logger and confirm that all references pointed to the same instance. This validated the correct implementation of the Singleton pattern.

## Output:
![Singleton sanz](https://github.com/user-attachments/assets/d13b174c-e78b-4b5b-a239-5e13caf45ff4)
The Singleton Pattern was successfully implemented, ensuring that all logging activities in the application used a single consistent instance of the Logger class. This design improves resource usage and maintains centralized control over logging.
