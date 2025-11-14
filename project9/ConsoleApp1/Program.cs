using System;

class Program
{
 
    static double Perimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    
    static double Area(double a, double b, double c)
    {
        double s = (a + b + c) / 2; 
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static void Main()
    {
        Console.Write("Enter a one number : ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter a tow number : ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter a end number : ");
        double c = double.Parse(Console.ReadLine());

        double perimeter = Perimeter(a, b, c);
        double area = Area(a, b, c);

        Console.WriteLine("perimeter = " + perimeter);
        Console.WriteLine("area = " + area);
        Console.ReadKey();

    }
    
        }

