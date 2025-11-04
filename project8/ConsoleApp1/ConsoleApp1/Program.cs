using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//amirmahdi mirfakhraei
            int number;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"number {i} enter a number : ");
                number = int.Parse(Console.ReadLine());


                if (number % 2 == 0)
                    Console.WriteLine("even.");
                else
                    Console.WriteLine("odd");

                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
