using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW1
{
    class Questionnaire
    {
        // Смоляков Егор
        // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        // а) используя склеивание;
        // б) используя форматированный вывод;
        // в) используя вывод со знаком $.

        public static void form ()
        {

            Console.WriteLine("Добрый день!");
            Console.Write("Введите Ваше имя: ");
            string firstname = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string secondname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age  = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ваш рост (в метрах): ");
            double hight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Ваш вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Данные анкеты:");
            //a
            Console.WriteLine("Вас зовут " + firstname + " " + secondname + ", Вам " + age + " лет, Ваш рост - " + hight + " метр(ов), Вы весите " + weight + " килограмм(ов)");

            //b
            Console.WriteLine("Вас зовут {0} {1}, Вам {2} лет, Ваш рост - {3} метр(ов), Вы весите {4} килограмм(ов)", firstname, secondname, age, hight, weight);

            //c
            Console.WriteLine($"Вас зовут {firstname} {secondname}, Вам {age} лет, Ваш рост - {hight} метр(ов), Вы весите {weight} килограмм(ов)") ;


            Console.ReadLine();
        }
        
    }
}
