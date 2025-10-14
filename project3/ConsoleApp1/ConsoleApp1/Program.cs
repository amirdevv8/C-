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
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // چک کردن شرط
            if (number < 10 && number % 2 == 0)
            {
                Console.WriteLine("true");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadKey();


            }
        }
    }
}
