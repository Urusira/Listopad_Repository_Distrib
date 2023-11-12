using System;
class Program
{
    static int EnterNumber(int num_a)
    {
        Console.WriteLine("\n\nPlease, enter A: ");
        num_a = Convert.ToInt32(Console.ReadLine());
        return num_a;
    }
    static void CalcArea(int num_a)
    {
    }
    static void CalcPerim(int num_a)
    {
    }
    static void Main()
    {
        int funcSelect = 0, num_a = 0;
        for (; ; )
        {
            Console.WriteLine("1. Enter a number");
            Console.WriteLine("2. Calculate the area of an equilateral triangle");
            Console.WriteLine("3. Calculate the perimeter of an equilateral triangle\n\nPlease enter the number of the desired function or enter 0 for close app: ");
            funcSelect = Convert.ToInt32(Console.ReadLine());
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

