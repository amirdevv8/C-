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
            //امیرمهدی میرفخرایی//
            Console.WriteLine("Enter a Celsius :");  // پیام.

            string input = Console.ReadLine();  // ورودی متن.
            double c = Convert.ToDouble(input);  // به عدد تبدیل.

            double f = (c * 9 / 5) + 32;  // فرمول ساده: ×۱.۸ + ۳۲ (۹/۵=۱.۸).

            Console.WriteLine("Fahrenheit: " + f);  // چاپ.

            Console.ReadLine();  // نگه دار برنامه.
        }
    }
}
