using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // امیرمهدی میرفخرایی
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            if (number % 7 == 0)
            {
                Console.WriteLine("yes");
                Console.ReadKey();
            }
            else
            {
                int result = number * 3;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
