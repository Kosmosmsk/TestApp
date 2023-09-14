using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintTable()
        {
            for (int i = 2; i < 10; i = i + 1)
            {
                for(int j = 1; j < 11; j = j + 1)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    //Console.WriteLine();
                }

                Console.WriteLine();
            }
            
        }

        static void samsing()
        {
            Console.WriteLine(15.0/23.0);
        }

        static void Main(string[] args)
        {
            samsing();

            Console.WriteLine();

            PrintTable();
            //double x = 15;
            //double y = 23;
            //Console.WriteLine(x / y);
            //bool lol = false;
            //if (!lol) // lol == false 
            //{
            //    Console.WriteLine("lol = false");

            //}
            //if (lol) // lol == true
            //{
            //    Console.WriteLine("lol = true");
            //}
            //Console.WriteLine("hello world");
            //Console.WriteLine("some code\n\n\n\n"); // /n убирает строку
            //Console.WriteLine("hello slava");
            Console.Read();
        }
    }
}

