using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //امیرمهدی میرفخرایی

        static void Main(string[] args)
        {
            double number;
            double resulte = 1;

            Console.WriteLine("enter a number ");


            do
            {
                number = double.Parse(Console.ReadLine());
                if (number != 0)
                    resulte *=number;

            } while (number != 0);

            Console.WriteLine("resulte: " + resulte);
            Console.ReadKey();
        }
    }
}
