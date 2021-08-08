using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_HW3
{
    class GetNumber
    {
        public static void GettingNumber(out int number, out string value, string msg = "Введите число: ")
        {
            number = 0;
            value = string.Empty;
            bool success = false;

            do
            {
                Console.Write(msg);
                value = Console.ReadLine();
                success = int.TryParse(value, out number);
            } while (!success);

        }


        // Смоляков Егор
        // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        // Требуется подсчитать сумму всех нечётных положительных чисел.
        // Сами числа и сумму вывести на экран, используя tryParse

        // Вопрос про Message IDE0059 Unnecessary assignment of a value to 'number'	
        // Вопрос про TryParse для вывода суммы.
        // Вопрос про условие для While

        public static void Summator()
        {
            int number;
            string value = string.Empty;
            int sum = 0;
            bool success = false;

            do
            {
                Console.Write("Введите число: ");
                value = Console.ReadLine();
                success = int.TryParse(value, out number);
                if (number % 2 == 1 && number > 0)
                {
                    sum += number;
                }
            } while (!success || number != 0);
            Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");
        }
    }
}
