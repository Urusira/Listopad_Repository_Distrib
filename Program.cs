using System;
class Program
{
    static int EnterNumber(int num_a)
    {
        return num_a;
    }
    static void CalcArea(int num_a)
    {
        if (num_a > 0)
        {
            Console.WriteLine($"\nArea of an equilateral triangle with side A: {(((num_a * num_a) * Math.Sqrt(3)) / 4)}");
        }
        else
        {
            Console.WriteLine("\nError; enter correct A (side of triangle)");
        }
    }
    static void CalcPerim(int num_a)
    {
    }

    static void Main()
    {
        int funcSelect = 0, num_a = 0;
        for ( ; ; )
        {
            Console.WriteLine("\n1. Enter a number A (side of equilateral triangle)");
            Console.WriteLine("2. Calculate the area of an equilateral triangle with side A");
            Console.WriteLine("3. Calculate the perimeter of an equilateral triangle with side A\n");
            Console.Write("Please enter the number of the desired function or 0 if you want to close the app: ");
            funcSelect = int.Parse(Console.ReadLine());
            switch (funcSelect)
            {
                case 0:
                {
                    return;
                }
                case 1:
                {
                    num_a = EnterNumber(num_a);
                    break;
                }
                case 2:
                {
                    CalcArea(num_a);
                    break;
                }
                case 3:
                {
                    CalcPerim(num_a);
                    break;
                }
            }
        }
    }
}

