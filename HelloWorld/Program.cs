using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\nWhat is your name? ");
            // var name = Console.ReadLine();
            // var date = DateTime.Now;
            // Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            // Console.Write("\nPress any key to exit...");
            // Console.ReadKey(true);

            // Challenge
            // Console.WriteLine("This is the first line.");
            // Console.WriteLine("This is the second line.");
            // Console.Write("This is ");
            // Console.Write("the third ");
            // Console.Write("line.");

            // Literals
            // Char
            // Console.WriteLine('p');
            // Int
            // Console.WriteLine(21);
            // Decimal
            // Console.WriteLine(21.12m);
            // Bool
            // Console.WriteLine(true);

            // int fahrenheit = 94;
            // decimal celsius = (fahrenheit - 32m) * (5m/9m);
            // Console.WriteLine($"The temperature is {celsius} Celsius");

            // if, else if, else Decision Statements
            // SCOPE - variable has to be declared outside of the {} block
            // to allow access and re assignment inside the blocks.
            // assigns the value from the user input
            // string userValue = Console.ReadLine();
            // string message = "Initial Message";
            // if (userValue == "1") {
            //     message = "You won a new car!";
            // }
            // else if (userValue == "2") {
            //     message = "You won a new boat!";
            // }
            // else {
            //     message = "You won nothing, Loser!";
            // }
            // Console.WriteLine(message);
            // Console.ReadLine();

            // if, else if , else Decision Statements
            // SHORTER - if only one line inside a {} block, the {} can be omitted
            // string userValue = Console.ReadLine();
            // string message = "Initial Message";
            // if (userValue == "1") message = "You won a new car!";
            // else if (userValue == "2") message = "You won a new boat!";
            // else { 
            //     message = "You won nothing, Loser!";
            //     message += " Go home!";
            // }
            // Console.WriteLine(message);

            // if else TERNARY OPERATION
            // string userValue = Console.ReadLine();
            // string message = (userValue == "1") ? "boat" : "strand of hair";
            // Console.WriteLine($"You have won a {message}");
        }
    }
}
