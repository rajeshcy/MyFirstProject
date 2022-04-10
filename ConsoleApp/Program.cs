using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = new string[6];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "Calculus";
            subjects[4] = "Computer Science";
            subjects[5] = "Algebra";

            int[] marks = new int[6];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 80;
            marks[3] = 55;
            marks[4] = 71;
            marks[5] = 92;

            Console.WriteLine("Marks of Kamal :");
            int total = 0;
            for (int i = 0; i<6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("Total =" + total + "/600 =" + (total * 100 / 600));

         }
    }
}
