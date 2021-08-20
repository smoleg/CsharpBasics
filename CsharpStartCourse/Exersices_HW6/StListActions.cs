using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_HW6
{
    class StListActions
    {      

        public void CountCourse(List<Student> stList)
        {
            var subList = from stud in stList
                          where (stud.course == 5 || stud.course == 6)
                          select stud;

            Console.WriteLine($"В списке {subList.Count()} студентов 5 и 6 курсов.");
        }

        public void CountCourseAge(List<Student> stList)
        {
            for (int i = 1; i <= 6; i++)
            {
                var subList = from stud in stList
                              where stud.age >= 18 && stud.age <= 20 && stud.course == i
                              select stud;
                Console.WriteLine($"На {i}-м курсе учится {subList.Count()} студент(а/ов) от 18 до 20 лет.");
            }
        }

        public void SortAge(List<Student> stList)
        {
            stList.Sort();

            Console.WriteLine("Отсортированный список по курсу и возрасту:");           
            
        }
    }
}
