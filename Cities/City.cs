using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    internal class City
    {
        public static string[] ReadCities()
        {
            string citiesName = "D:\\wipro\\.net\\cities.txt";
            return System.IO.File.ReadAllLines(citiesName);
        }

        public static void DisplayCities(string[] cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }

        public static void SortCities(string[] cities)
        {
            for (int i = 0; i < cities.Length - 1; i++)
            {
                for (int j = 0; j < cities.Length; j++)
                    if (string.Compare(cities[i], cities[j]) > 0)
                    {
                        string temp = cities[i];
                        cities[i] = cities[j];
                        cities[j] = temp;
                    }
            }
        }

        public static int FindCity(string[] cities, string city)
        {
            SortCities(cities);

            int minNum = 0;
            int maxNum = cities.Length - 1;

            int foundElem = -1;

            while (minNum <= maxNum && foundElem == -1)
            {
                int mid = (minNum + maxNum) / 2;

                if (city.Equals(cities[mid], StringComparison.OrdinalIgnoreCase))
                {
                    foundElem = ++mid;
                    break;
                }
                else if (city.CompareTo(cities[mid]) < 0)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return foundElem;
        }

    }
}
