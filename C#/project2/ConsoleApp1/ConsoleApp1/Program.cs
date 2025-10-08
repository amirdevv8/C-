using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass  // اسم کلاس ساده. همه کد توش می‌ره.
    {
        static void Main()  // این تابع اول اجرا می‌شه. بدون آرگومان.
        {
            Console.WriteLine("hi enter a number:");  // چاپ پیام.

            string input = Console.ReadLine();  // ورودی رو به عنوان متن بخون.
            double r = Convert.ToDouble(input);  // متن رو به عدد تبدیل کن.

            double masahat = 3.14 * r * r;  // مساحت: π رو 3.14 بگیریم (ساده!).
            double mohit = 2 * 3.14 * r;    // محیط: ساده‌تر از Math.PI.

            Console.WriteLine("masahat: " + masahat);  // چاپ نتیجه بدون فرمت پیچیده.
            Console.WriteLine("mohit: " + mohit);

            Console.ReadLine();  // منتظر بمون تا Enter بزنی.
        }
    }
}
