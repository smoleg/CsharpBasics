using System;

namespace Exersices_HW5
{
    class Program
    {
        static void Main()
        {
            LoginValidation lv = new();                    // Задание 1. Обычная проверка
            lv.Check();
            Console.ReadLine();

            RegularLoginValidation rlv = new();            // Задание 1. Регулярные выражения
            rlv.Check();
            Console.ReadLine();

            Message.NWord("apple wisdom independensy wether loyalty mother", 6);        // Задание 2. Пункт 1
            Console.WriteLine(); Console.ReadLine();

            Message.RemoveWord("sdfsj ahsdgj erdfd asdarr1 asdj", 'j');                 // Задание 2. Пункт 2
            Console.WriteLine(); Console.ReadLine();

            Message.LongestW("apple wisdom independensy wether loyalty mother");        // Задание 2. Пункт 3
            Console.WriteLine(); Console.ReadLine();

            Message.SBLongWords("first second third fourth fifth");                     // Задание 2. Пункт 4
        }
    }
}
