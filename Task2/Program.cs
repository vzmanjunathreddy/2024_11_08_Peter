//Generics:
//Implement a Generic Stack class that can store elements of any data type.
//The stack should support the following operations and ensure proper error handling:
//·       Push, Pop, Peek, Count, IsEmpty
//Key Considerations:
//The stack should be generic and able to store elements of any type.
//For example, when trying to pop or peek from an empty stack,
//an appropriate exception should be thrown (e.g., InvalidOperationException).
//Dynamic Resizing: The internal storage should dynamically resize if the stack grows too large.
//For example, you could double the size of the array when the stack is full.
//Provide the ability to check the number of elements in the stack at any time
//and to determine whether the stack is empty.

var stack = new Task2.Stack<string>(5);

Console.WriteLine($"is stack empty? {stack.IsEmpty()}");

for (int i = 0; i<10; i++)
{
    stack.Push(i.ToString());
}

Console.WriteLine($"stack count? {stack.Count()}");

for (int i = 0; i < 10; i++)
{
    var item = stack.Pop();
    Console.WriteLine(item);
}

Console.WriteLine($"stack count? {stack.Count()}");

Console.ReadLine();
stack.Pop();


