using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW1
{
    class Distance
    {
        // Смоляков Егор
        // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        //a
        public static void distance_varA()
        {
            double x1, y1, x2, y2, r;
            x1 = 23;
            y1 = 16;
            x2 = 31.5;
            y2 = 0.46;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:F2}",r);
            Console.ReadLine();
        }

        //b
        public static void distance_varB(double x1, double y1, double x2, double y2)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:F2}", r);
            Console.ReadLine();
        }
    }
}
