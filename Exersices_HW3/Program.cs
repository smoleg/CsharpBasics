using System;

namespace Exersices_HW3
{
    class Program
    {
        static void Main()
        {
            // Вопрос про использование метода без Static
            // GetNumber ab = new GetNumber();
            // ab.GettingNumber(out a, out value);
            // ab.GettingNumber(out b, out value);

            GetNumber.Summator();                                    // Задание 2. Суммирование нечетных положительных чисел. TryParse

            Complex compNum1 = new Complex(12, 5);       // Задание 1. Калькулятор для класса комплексных чисел
            Complex compNum2 = new Complex(2, 10);
            Complex.Calculator(compNum1, compNum2);            
        }
    }
}
