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
            //امیرمهدی میرفخرایی
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("shanbe");
                    break;
                case 2:
                    Console.WriteLine("yek shanbe");
                    break;
                case 3:
                    Console.WriteLine("do shanbe");
                    break;
                case 4:
                    Console.WriteLine("3 shanbe");
                    break;
                case 5:
                    Console.WriteLine("4 shanbe");
                    break;
                case 6:
                    Console.WriteLine("5 shanbe");
                    break;
                case 7:
                    Console.WriteLine("gomeh");
                    break;
                default:
                    Console.WriteLine("END!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
