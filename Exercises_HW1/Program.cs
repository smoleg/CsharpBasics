using System;

namespace Exercises_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Смоляков Егор
            Questionnaire.form();                                   // Задание 1. Анкета
            BMI.BMI_calc();                                         // Задание 2. ИМТ
            Distance.distance_varA();                               // Задание 3. Расстояние. Вариант а
            Distance.distance_varB(12.43, 34.2, 43.235, 78.12);     // Задание 3. Расстояние. Вариант б
            ExchangeValues.exchange();                              // Задание 4. Обмен значений
            SelfIntro.info();                                       // Задание 5. Вывод на консоль. Варианты а и б
            SelfIntro.info_C(50,50, "Егор Смоляков, Москва");       // Задание 5. Вывод на консоль. Вариант в
        }
    }
}
