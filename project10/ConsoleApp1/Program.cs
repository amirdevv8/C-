using System;

class Program
{
    static int Multiply(int a, int b)
    {
        if (b == 0)
            return 0;

        if (b < 0)
            return -Multiply(a, -b);


        return a + Multiply(a, b - 1);
    }

    static void Main()
    {
        Console.Write("Enter a one number : ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter a tow number : ");
        int b = int.Parse(Console.ReadLine());

        int result = Multiply(a, b);

        Console.WriteLine("حاصل ضرب = " + result);
        Console.ReadKey();

    }
}
