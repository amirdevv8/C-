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

            //امیرمهدی میرفخرایی    
            int n = 7; 
            int width = n; 

            for (int i = 0; i < n; i++)
            {
                // --- حرف I ---
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == n - 1) 
                        Console.Write('*');
                    else
                    {
                        int center = width / 2;
                        if (j == center) Console.Write('*'); 
                        else Console.Write(' ');
                    }
                }

                
                Console.Write(new string(' ', 3));

                // --- حرف H ---
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == width - 1 || i == n / 2) // دو ستون کناری یا خط میانی
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }

              
                Console.Write(new string(' ', 3));

                // --- حرف E ---
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || i == 0 || i == n / 2 || i == n - 1) 
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}