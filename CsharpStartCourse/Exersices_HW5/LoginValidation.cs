using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exersices_HW5
{

    // Смоляков Егор

    // Создать программу, которая будет проверять корректность ввода логина.
    // Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой


    class LoginValidation
    {
        public void Check()
        {
            char[] login = Array.Empty<char>();
            bool access = false;

            Console.WriteLine("Проверка логина. Обычный способ.");

            while (!access)
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine().ToCharArray();

                if (login.Length < 10 && login.Length > 2)
                {
                    if (!Char.IsDigit(login[0]))
                    {                        
                        foreach (char sym in login)
                        {
                            if (!(Char.IsDigit(sym) || (sym >= 'a' && sym <='z') || (sym >= 'A' && sym <= 'Z')))
                            {
                                Console.WriteLine("Логин содержит некорректные символы.");
                                access = false;
                                break;
                            }
                            else access = true;
                        }
                    }
                    else Console.WriteLine("Первым символом логина не может быть цифра.");
                }
                else Console.WriteLine("Логин не может быть короче двух символов и длиннее десяти.");
            }
            Console.WriteLine("Введен корректный логин.");
        }
    }

    // **с использованием регулярных выражений

    class RegularLoginValidation
    {
        public void Check ()
        {
            Regex regex = new ("^[a-zA-Z]+[a-zA-Z0-9]{1,9}");
            string login;

            Console.WriteLine("\nПроверка логина. Регулярные выражения.");
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
            } while (!regex.IsMatch(login) || login.Length > 10);
            
            Console.WriteLine("Введен корректный логин.");
        }        
    }
}
