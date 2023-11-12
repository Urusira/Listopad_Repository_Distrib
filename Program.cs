using System;

class Program
{
    static void EnterNumber()
    {
    }

    static void CalcArea(int a)
    {
    }

    static void CalcPerim(int a)
    {
    }

    static void Main()
    {
        int switcher = 0, a = 0;

        Console.WriteLine("1. Enter a number");
        Console.WriteLine("2. Calculate the area of an equilateral triangle");
        Console.WriteLine("3. Calculate the perimeter of an equilateral triangle");
        Console.WriteLine("\nPlease enter the number of the desired function: ");

        switcher = Convert.ToInt32(Console.ReadLine());

        switch (switcher)
        {
            case 1:
                {
                    EnterNumber();
                    break;
                }
            case 2:
                {
                    CalcArea(a);
                    break;
                }
            case 3:
                {
                    CalcPerim(a);
                    break;
                }
        }
    }
}

