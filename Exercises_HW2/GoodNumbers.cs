using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW2
{
    class GoodNumbers
    {
        // Смоляков Егор

        // Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        // «Хорошим» называется число, которое делится на сумму своих цифр.
        // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        public static void GN()
        {
            System.DateTime starttime;
            System.DateTime endtime;
            System.TimeSpan runtime;

            starttime = DateTime.Now;
            int count = 0;

            for (long i = 1; i <= 10000000; i++)
            {
                if (i % DigitSum(i) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество \"Хороших\" цифр: {count}");
            endtime = DateTime.Now;
            runtime = endtime - starttime;
            Console.WriteLine($"\nВремя выполнения прогнраммы: {runtime}");
        }


        static long DigitSum(long a)
        {
            long sum = 0;
            do
            {
                sum += a % 10;
                a /= 10;
            } while (a != 0);
            return sum;
        }
    }
}
