using System;
using System.Collections.Generic;

namespace Exersices_HW6
{
    class Program
    {
        static void Main()
        {
            string path = "studs.csv";
            int n = 100;

            // Формируем файл со списком из 100 студентов
            StudentList students = new();
            students.FileStudent(path, n);

            // Заполняем коллекцию студентов
            List<Student> studentList = new();
            studentList = students.GetList(path);

            // Задание а Подсчитать количество студентов учащихся на 5 и 6 курсах;
            students.CountCourse(studentList);
            Console.WriteLine();

            // Задание б Подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся
            students.CountCourseAge(studentList);
            Console.WriteLine();

            // Задание в + г* Отсортировать список по курсу и возрасту студента
            students.SortAge(studentList);
            students.Print(studentList);
        }
    }
}
