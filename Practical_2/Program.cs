using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            while (true)
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Where are you from?");
                country = Console.ReadLine();

                if (Regex.IsMatch(name, @"^[a-zA-Z]+$") && Regex.IsMatch(country, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("\nWelcome " + name + " from country " + country);
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease enter valid name or country!!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
