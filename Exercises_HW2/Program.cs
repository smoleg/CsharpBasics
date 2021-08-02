using System;

namespace Exercises_HW2
{
    class Program
    {
        static void Main()
        {
            // Смоляков Егор

            Console.WriteLine($"Минимальное из трёх чисел: {MinOfThree.min(120, 135, 84)}");      // Задание 1. Минимальное из трёх чисел
            Console.WriteLine($"Количество знаков в числе: {DigitCount.counter(192324536)}");     // Задание 2. Количество цифр в числе
            Summary.summ();                                                                       // Задание 3. Сумматор
            Authorization.auth_call();                                                            // Задание 4. Авторизация
            GoodNumbers.GN();                                                                     // Задание 6. Подсчет "Хороших" чисел. Реализовано для 1 миллиона. Для 1 миллиарда время выполнения - 4 минуты 30 секунд
        }
    }
}
