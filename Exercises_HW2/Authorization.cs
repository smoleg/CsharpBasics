using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW2
{
    // Смоляков Егор

    // Реализовать метод проверки логина и пароля.
    // На вход метода подается логин и пароль.
    // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    // С помощью цикла do while ограничить ввод пароля тремя попытками.


    class Authorization
    {
        static bool auth ()
        {
            string login, pwd;
            int counter = 1;
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pwd = Console.ReadLine();

                if ((login == "root") && (pwd == "GeekBrains"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Ошибка авторизации!");
                    counter++;
                }

            } while (counter <= 3);
            return false;            
        }
        
        public static void auth_call ()
        {
            if (auth())
            {
                Console.WriteLine("Доступ разрешен!");
            }
            else Console.WriteLine("Превышено максимальное количество попыток входа. Доступ в систему запрещен!");
        }
    }
}
