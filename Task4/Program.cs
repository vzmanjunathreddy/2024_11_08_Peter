class Program
{
    delegate string delegate1(string a, int b);

    public static int Main(string[] args)
    {
        //Boxing and unboxing :
        //"Write a C# program that boxes different types of value types (e.g., int, double, char)
        //into an object and then unboxes them back to their original types.
        //Demonstrate any necessary casting."

        int number = 5;

        object obj = number;

        int number2 = (int)obj;

        Console.WriteLine(number2);
        ////////////////////////////////////////////////
        //Create a delegate that takes a string and an int, and returns a string.
        //Instead of creating a named method,
        //use an anonymous method to concatenate the string with the integer."

        delegate1 myMethod = (a, b) => a + b.ToString();

        return 0;
    }
}

