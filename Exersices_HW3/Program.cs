using System;

namespace Exersices_HW3
{
    class Program
    {
        static void Main()
        {
            // Вопрос про использование метода без Static
            //GetNumber ab = new GetNumber();
            //ab.GettingNumber(out a, out value);
            //ab.GettingNumber(out b, out value);

            GetNumber.Summator();                                    // Задание 2. Суммирование нечетных положительных чисел. TryParse

            ComplexStruct compNum1 = new ComplexStruct(12, 5);       // Задание 1. Калькулятор для класса комплексных чисел
            ComplexStruct compNum2 = new ComplexStruct(2, 10);
            ComplexStruct.Calculator(compNum1, compNum2);            
        }
    }
}
