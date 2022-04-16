using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = City.ReadCities();
            Console.WriteLine("unsorted cities ------");
            City.DisplayCities(cities);
            City.SortCities(cities);
            Console.WriteLine();
            Console.WriteLine("sorted cities ------");
            City.DisplayCities(cities);
            Console.WriteLine( City.FindCity(cities, "Surat"));

        }

    }
}
