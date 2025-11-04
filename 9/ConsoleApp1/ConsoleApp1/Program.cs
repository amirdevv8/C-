using System;

class Program
{
    static void Main()
    {
        int number;
        int position = -1;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"num {i}: ");
            number = int.Parse(Console.ReadLine());

            if (number == 2)
            {
                position = i;
            }
        }

        if (position != -1)
        {
            Console.WriteLine($"position {position}.yes");
        }
        else
        {
            Console.WriteLine("eror");
        }
        Console.ReadKey();
    }
}
