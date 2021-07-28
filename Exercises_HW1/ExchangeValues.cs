using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW1
{
    class ExchangeValues
    {
        public static void exchange()
        {
            // Смоляков Егор
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            int a = 134;
            int b = 15;
            int t;

            //a

            Console.WriteLine("Вариант а");
            Console.WriteLine($"Значение первого числа: {a}");
            Console.WriteLine($"Значение второго числа: {b}");
            Console.WriteLine("\nОбмен");

            t = a;
            a = b;
            b = t;

            Console.WriteLine($"\nЗначение первого числа: {a}");
            Console.WriteLine($"Значение второго числа: {b}");

            //b

            Console.WriteLine("\n\nВариант б");
            Console.WriteLine($"Значение первого числа: {a}");
            Console.WriteLine($"Значение второго числа: {b}");
            Console.WriteLine("\nОбмен");

            a = a - b;
            b = b + a;
            a = b - a;

            Console.WriteLine($"\nЗначение первого числа: {a}");
            Console.WriteLine($"Значение второго числа: {b}");

            Console.ReadLine();
        }
    }
}
