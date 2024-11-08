**Question : 1 :
========================**
Design a system using the Factory Design Pattern that can produce different types of vehicles such as Car, Truck, and Motorcycle. 
The goal is to allow a user to request a specific type of vehicle (e.g., "Car", "Truck") 
and receive an appropriate instance without directly creating the object. The client should not need to know the details of how the vehicle is created.


**Question : 2 :
========================**

Implement a Generic Stack class that can store elements of any data type. The stack should support the following operations and ensure proper error handling:
·       Push, Pop ,Peek, Count, IsEmpty
Key Considerations:
The stack should be generic and able to store elements of any type.
For example, when trying to pop or peek from an empty stack, an appropriate exception should be thrown (e.g., InvalidOperationException).
Dynamic Resizing: The internal storage should dynamically resize if the stack grows too large. For example, you could double the size of the array when the stack is full.
Provide the ability to check the number of elements in the stack at any time and to determine whether the stack is empty.

**Question : 3 :
========================**

Suppose you have a performance-critical C# application that frequently creates and disposes of short-lived objects. 
Implement an object pool to reuse objects instead of creating new instances, which can reduce memory allocations and improve performance.

**Question : 4 :
========================**

Boxing and unboxing :
"Write a C# program that boxes different types of value types (e.g., int, double, char) into an object and then unboxes them back to their original types. Demonstrate any necessary casting."

**Question : 5:
========================**

Create a delegate that takes a string and an int, and returns a string. Instead of creating a named method, use an anonymous method to concatenate the string with the integer."
