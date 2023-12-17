using System;

/**
    @mainpage Проект Listopad_Repository_v3 для выполнения второго задания в лабораторной работе №3 по курсу Проектирование программного обеспечения
	@file		Program.cs
	@brief		Файл с кодом программы, вычисляющей заданный треугольник
	@copyright	ВоГУ
	@author		Листопад В.Ю.
	@date		12-11-2023
	@version	1.0.1
\par Содержит класс:
	@ref Program
*/

/// Класс с консольным приложением
/** Содержит функции рассчёта площади и периметра треугольника
 */
class Program
{
    /// Функция для ввода переменной num_a
    /** Выводит сообщение, с бросьбой ввести длину стороны треугольника, получает число на вход и возвращает
    \param num_a Длина стороны треугольника
    @return num_a Сторона треугольника, введённая с клавиатуры
    */
    static int EnterNumber(int num_a)
    {
        Console.WriteLine("\nPlease, enter A: ");
        num_a = Convert.ToInt32(Console.ReadLine());
        return num_a;
    }

    /// Функция для рассчёта площади треугольника
    /** Выводит сообщение с рассчитанной внутри него площадью треугольника
    \param num_a Длина стороны треугольника
    */
    static void CalcArea(int num_a)
    {
        if (num_a > 0)
        {
            Console.WriteLine($"\nArea of an equilateral triangle with side A: {(((num_a * num_a) * Math.Sqrt(3)) / 4)}\n");
        }
        else
        {
            Console.WriteLine("\nError; enter correct A (side of triangle)");
        }
    }

    /// Функция для рассчёта периметра треугольника
    /** Выводит сообщение с рассчитанным внутри него периметром треугольника
    \param num_a Длина стороны треугольника
    */
    static void CalcPerim(int num_a)
    {
        Console.WriteLine("\nPerimeter of an equilateral triangle with side A: " + num_a * 3 + "\n");
    }
    static void Main()
    {
        int funcSelect = 0; ///< Выбор_в_меню
        int num_a = 0;      ///< Длина_стороны_треугольника

        /**
         @brief Консольное меню выбора функции
         В цикле идёт выбор от 1 до 3 функции, ноль используется для выхода из программы.
         Меню реализовано на основе свич-кейса
         */
        for ( ; ; )
        {
            Console.WriteLine("\n1. Enter a number A (side of equilateral triangle)");  /// Первый вариант в меню
            Console.WriteLine("2. Calculate the area of an equilateral triangle with side A");  /// Второй вариант в меню
            Console.WriteLine("3. Calculate the perimeter of an equilateral triangle with side A\n");   /// Третий вариант в меню
            Console.Write("Please enter the number of the desired function or 0 if you want to close the app: ");   /// Предложение выхода
            funcSelect = int.Parse(Console.ReadLine()); /// Получение числа, вводимого с клавиатуры
            /**
             @brief Меню выбора
             В зависимости от введённого ранее числа, выполняется соответствующий сценарий
             */
            switch (funcSelect)
            {
                /// Ноль просто выключает программу
                case 0:
                {
                    return;
                }
                /// Вызывает первую функцию с параметром num_a
                /**
                \param num_a Длина стороны треугольника
                В переменную num_a помещает новое значение, которое получает функция EnterNumber.
                */
                case 1:
                {
                    num_a = EnterNumber(num_a);
                    break;
                }
                /// Вызывает вторую функцию с параметром num_a
                /**
                \param num_a Длина стороны треугольника
                Вызывает функцию рассчёта площади треугольника со стороной, определённой в параметре num_a.
                В функции сразу выводится результат рассчёта.
                */
                case 2:
                {
                    CalcArea(num_a);
                    break;
                    }
                /// Вызывает третью функцию с параметром num_a
                /**
                \param num_a Длина стороны треугольника
                Вызывает функцию рассчёта периметра треугольника со стороной, определённой в параметре num_a.
                В функции сразу выводится результат рассчёта.
                */
                case 3:
                {
                    CalcPerim(num_a);
                    break;
                }
            }
        }
    }
}

