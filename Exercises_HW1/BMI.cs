using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_HW1
{
    // Смоляков Егор
    //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

    class BMI
    {
        public static void BMI_calc()
        {
            Console.Write("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double index = weight / Math.Pow(height,2);

            Console.WriteLine($"Ваш ИМТ = {index}");
            Console.ReadLine();
        }
    }
}
