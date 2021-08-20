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

            // Задание а
            students.CountCourse(studentList);
            Console.WriteLine();

            // Задание б
            students.CountCourseAge(studentList);
            Console.WriteLine();

            // Задание в + г*
            students.SortAge(studentList);
            students.Print(studentList);
        }
    }
}
