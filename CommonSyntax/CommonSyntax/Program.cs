using System;
using System.Collections.Generic;

namespace CommonSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args.Length == 0 ? "World" : args[0];
            Console.WriteLine($"Hello {name}!");

            //Conditional
            //Console.WriteLine("Please input a number: ");
            //string input = Console.ReadLine();
            //string message = "";
            //if (input == "1")
            //{
            //    message = "You won!";
            //}
            //else if (input == "2")
            //{
            //    message = "It's a draw!";
            //}
            //else
            //{
            //    message = "You lost!";
            //}
            //Console.WriteLine(message);
            //Console.ReadKey();

            // Ternary Conditional
            //Console.WriteLine("Please input a number between 1 and 2: ");
            //string input = Console.ReadLine();
            //string message = input == "1" ? "You won!" : "You lost!";
            //Console.WriteLine(message);

            // For Loop (Iteration)
            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(i);

            //    //if((i % 2) == 0)
            //    //{
            //    //    Console.WriteLine(i);
            //    //}

            //    // Exit out of the loop
            //    if (i == 4)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }

            //}
            //Console.ReadLine();


            // Arrays

            /*
            int[] nums = new int[5];
            // int - type of data inside the array
            // [] - tells that it will hold an array
            // int[5] - tells the LENGTH of the array

            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;

            Console.WriteLine(nums[2]);
            Console.WriteLine(nums.Length);
            Console.ReadLine();
            */

            // Initialize the array on creation
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            //string[] names = new string[] { "Bob", "John", "Sally" };

            // iterate through an array using the for loop
            //for (int i = 0; i < names.Length; i++ )
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();

            // iterate through an array using the forEach loop
            // being name as the value of arr in each iteration
            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            // make an array out of the value of a variable.
            // reverse the elements in the array
            // then print the output in the console.
            //string quote = "Do unto others what you want other do unto you.";

            //char[] letters = quote.ToCharArray();
            //Array.Reverse(letters);
            //foreach (char let in letters)
            //{
            //    Console.Write(let);
            //}
            //Console.ReadLine();

            // Floats
            // float num1 = 21.12f;
            // float num2 = 12.21f;
            // double sum = num1 + num2;

            // Doubles
            // double num1 = 21.12;
            // double num2 = 12.21;
            // double sum = num1 + num2;
            // Console.WriteLine(sum);

            // Sum of Arrays
            // implicitly telling compiler that a new array is being created with doubles inside
            // double[] nums = new[] {12.2, 10.3, 4.5};

            // LIST
            var grades = new List<double>() {12.2, 10.3, 4.5};
            grades.Add(56.5);
            var sum = 0.0;
            var numOfGrades = grades.Count;

            // For loop
            // for (int i = 0; i < nums.Length; i++) 
            // {
            //     sum += nums[i];
            // }

            // FOREACH loop
            foreach(var num in grades) 
            {
                sum += num;
            }
            var ave = sum / numOfGrades;
            Console.WriteLine($"Your sum is {sum}");
            Console.WriteLine($"Your average is {ave}");

            // METHODS - calling
            HelloWord();
        }

        // METHODS
        private static void HelloWord()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello World() function called.");
        }
    }
}
