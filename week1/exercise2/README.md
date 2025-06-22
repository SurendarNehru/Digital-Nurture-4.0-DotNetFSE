## Exercise 2: Implementing the Factory Method Pattern
## Scenario:
To support the creation of various types of documents such as Word, PDF, and Excel in a scalable manner, a factory method design was implemented.

## Steps Taken:
## Project Setup:
A console application was initialized under the name FactoryMethodPatternExample to organize the document creation system.

## Defining Document Interfaces:
A common interface was defined for all document types to ensure consistent structure and behavior across implementations.

## Creating Document Types:
Individual classes were implemented for Word, PDF, and Excel documents. Each class provided its own version of the common document operation (e.g., opening a file).

## Developing the Factory Classes:
An abstract factory class was defined with a method for document creation. Subclasses of this factory were then created, each responsible for producing a specific type of document.

## Testing the Factory Workflow:
The system was tested by creating document objects through their respective factories. Each document type was opened to verify that the correct object was created and used.

 ## Output:
 ![FactoryMethod sanz](https://github.com/user-attachments/assets/dba23425-fd7d-4795-a8a9-3553c7b1c556)
 The program successfully created and opened different types of documents using their respective factories.

Demonstrated the power of the Factory Method Pattern in achieving loose coupling and scalability.

