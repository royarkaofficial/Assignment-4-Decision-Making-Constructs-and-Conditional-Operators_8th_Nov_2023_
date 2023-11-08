using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");   // Here I have taken the number as user input
            int number = int.Parse(Console.ReadLine());

            if (number > 0) // checking wether the number is greater than 0
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0) // checking wether the number is smaller than 0
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero."); // If the number is 0
            }

            string evenOrOdd = (number % 2 == 0) ? "even" : "odd"; // To check wether the string is even or odd
            Console.WriteLine($"The number is {evenOrOdd}.");
        }
    }
}
