using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();
            Console.WriteLine();
            pattern2();
            Console.WriteLine();
            pattern3();
            Console.WriteLine();
            pattern4();
            Console.ReadLine();
        }
        static void pattern1()
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern2()
        {
            int i,j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern3()
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern4()
        {
            int i, j, k;
            for (i = 1; i <=5 ; i++)
            {
                for (k = 5 - i; k > 0; k--)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
