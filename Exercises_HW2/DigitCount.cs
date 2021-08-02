using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW2
{
    class DigitCount
    {
        // Смоляков Егор

        // Написать метод подсчета количества цифр числа

        public static int counter(int a)
        {
            int count = 1;

            while (a % 10 != a)
            {
                a = (a - a % 10) / 10;
                count++;
            }
            return count;
        }
    }
}
