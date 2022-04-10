using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConvertToSeconds(5);
            //Console.WriteLine("To find area of a triangle");

            //Console.Write("Enter side: ");
            //float side = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter height: ");
            //float height = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine($"Area of a triangle with side {side} and height {height} is {AreaOfTriangle(side, height)}");

            //Invoke if sum is less than 100
            //IsSumlessThanHundred(10, 90);
            //IsSumlessThanHundred(99, 0);
            //IsSumlessThanHundred(100, 1);

            //Console.Write("Enter number 1: ");
            //int n1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Enter number 2: ");
            //int n2 = Convert.ToInt16(Console.ReadLine());

            //IsSumlessThanHundred(n1,n2);

            // Shuffling name of a person
            //NameShuffle("Rajesh Yandigeri");
            //NameShuffle("Donald Trump");

            //demo  factorial
            int number = Convert.ToInt16(Console.ReadLine());

            do
            {
                number = Convert.ToInt16(Console.ReadLine());
                if (number <= 0) 
                {
                    Console.WriteLine("To calculate factorial please enter a positive integer");
                }
            }
            while (number <= 0);

            Console.WriteLine($"{number}1 = {Factorial(number)}");


        }
        /// <summary>
        /// Calculate the factorial of a passed number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static long Factorial(int number)
        {
            //  non recursive way
            long factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;

            //recursive way
            if (number > 0)
                return number * Factorial(number - 1);
            
            return 1;
        }


        static void ConvertToSeconds(int minutes)
        {
            Console.WriteLine($"{minutes} minutes equals {minutes * 60} seconds");
        }

        static double AreaOfTriangle(float side, float height)
        {
            return (double)(side * height / 2);
        }
        /// <summary>
        /// Checks if the sum of two numbers is less than 100 or not
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void IsSumlessThanHundred(int number1, int number2)
        {
            if (number1 + number2 < 100)
                Console.WriteLine($"{number1} + {number2} is LESS THAN 100");
            else
                Console.WriteLine($"{number1} + {number2} is GREATER THAN 100");

        }

        /// <summary>
        /// Accepts a string of a person's first and last name and returns a string with first and last name swaped
        /// Assumption : There will be only one space between first and last name
        /// </summary>
        /// <param name="fullName"></param>
        static void NameShuffle(string fullName)
        {
            string[] nameArray = fullName.Split(' ');
            Console.WriteLine($"\"{fullName}\" --> {nameArray[1]} {nameArray[0]}");

            int spacePosition = fullName.IndexOf(' ');

            Console.WriteLine($"\"{fullName}\" -->{fullName.Substring(spacePosition+1)} {fullName.Substring(0, spacePosition)}");
        }

    }
}