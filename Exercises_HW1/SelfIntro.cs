using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW1
{
    class SelfIntro
    {
        // Смоляков Егор
        // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        // б) *Сделать задание, только вывод организовать в центре экрана.
        // в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).


        public static void info()
        {
            
            //a
            Console.WriteLine("Смоляков Егор, Москва");
            Console.ReadLine();

            //b
            Console.SetBufferSize(120, 120);
            Console.SetCursorPosition(60, 60);
            Console.WriteLine("Смоляков Егор, Москва");
            Console.ReadLine();

        }

            //c
        public static void info_C(int x, int y, string str)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(str);
            Console.ReadLine();
        }
    }
}
