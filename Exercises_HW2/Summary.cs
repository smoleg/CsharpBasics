using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW2
{
    // Смоляков Егор

    // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел

    class Summary
    {
        public static void summ()
        {
            int a;
            int sum = 0;
            do
            {
                Console.Write("Введите число. 0 завершает ввод: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0 && a % 2 == 1)
                {
                    sum += a;
                }
            } while (a != 0);
            Console.WriteLine($"Сумма введенных положительных нечетных чисел: {sum}");
        }
    }
}
