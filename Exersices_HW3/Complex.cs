using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_HW3
{
    class Complex
    {
        public int a, b;

        public Complex(int re, int im)
        {
            a = re;
            b = im;
        }

        public override string ToString()
        {
            return b < 0 ? $"{a} - {-b}i" : $"{a} + {b}i";
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(re: x.a + y.a, im: x.b + y.b);
        }

        public static Complex operator -(Complex x)
        {
            return new Complex(re: -x.a, im: -x.b);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.a - y.a, x.b - y.b);
        }

        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(x.a * y.a - x.b * y.b, x.b * y.a + x.a * y.b);
        }

        public static Complex operator /(Complex x, Complex y)
        {
            return new Complex(Convert.ToInt32(Math.Round((x.a * y.a + x.b * y.b) / (Math.Pow(y.a, 2) + Math.Pow(y.b, 2)))), Convert.ToInt32(Math.Round((x.b * y.a - x.a * y.b) / (Math.Pow(y.a, 2) + Math.Pow(y.b, 2)))));
        }

        public static void Calculator(Complex x, Complex y)
        {
            Console.WriteLine($"Первое число: {x}");
            Console.WriteLine($"Вторрое число: {y}");

            // Вопрос про goto

        S:  Console.Write($"Введите знак для вычисления: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine($"Сумма комплексных чисел: {x + y}");
                    break;

                case "-":
                    Console.WriteLine($"Разность комплексных чисел: {x - y}");
                    break;

                case "*":
                    Console.WriteLine($"Произведение комплексных чисел: {x * y}");
                    break;

                case "/":
                    Console.WriteLine($"Частное комплексных чисел: {x / y}");
                    break;

                default:
                    Console.WriteLine("Вы ввели не знак! Повторите ввод.");
                    goto S;
            }
        }

    }
}
