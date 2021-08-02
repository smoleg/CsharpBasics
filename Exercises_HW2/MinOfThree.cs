using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW2
{
    class MinOfThree
    {
        // Смоляков Егор

        // Написать метод, возвращающий минимальное из трёх чисел

        public static int min(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else return c;
        }

    }
}
