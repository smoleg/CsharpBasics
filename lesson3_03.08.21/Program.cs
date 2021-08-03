using System;

namespace lesson3_03._08._21
{
    class Program
    {
        static void Method1 ()
        {
            Console.WriteLine("Автор программы: ");
            Console.ReadLine();
        }

        static void Method2 (string authorName)
        {
            Console.WriteLine($"Автор программы: {authorName}");
            Console.ReadLine();
        }

        static int Method3 ()
        {
            var number1 = 0;
            bool succes = false;

            do
            {
                Console.Write("Введите число: ");
                succes = int.TryParse(Console.ReadLine(), out number1);
            } while (!succes);

            return number1;
        }

        static int Method4(string msg)
        {
            var number1 = 0;
            bool succes = false;

            do
            {
                Console.Write("{msg}");
                succes = int.TryParse(Console.ReadLine(), out number1);
            } while (!succes);

            return number1;
        }

        static void Main()
        {
            Method1();
            Method2("123");
            Method3();
            Method4("Введите число: ");
        }
    }
}
