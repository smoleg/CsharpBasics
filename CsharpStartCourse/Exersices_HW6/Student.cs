using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_HW6
{
    class Student : IComparable<Student>
    {
        public string firstName;
        public string lastName;
        public string university;
        public string faculty;
        public string department;
        public int age;
        public int course;
        public int group;
        public string city;

        private Student()
        {
        }

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }

        public static Student GetStudent()
        {
            Random r = new Random();

            return new Student(
                firstName: $"Имя_{Guid.NewGuid().ToString().Substring(0, 5)}",
                lastName: $"Фамилия_{Guid.NewGuid().ToString().Substring(0, 5)}",
                university: $"Университет_{Guid.NewGuid().ToString().Substring(0, 5)}",
                faculty: $"Факультет_{Guid.NewGuid().ToString().Substring(0, 5)}",
                department: $"Кафедра_{Guid.NewGuid().ToString().Substring(0, 5)}",
                age: r.Next(17, 26),
                course: r.Next(1, 7),
                group: r.Next(1, 100),
                city: $"Город_{Guid.NewGuid().ToString().Substring(0, 5)}"
            );
        }

        public override string ToString()
        {
            return $"{firstName};{lastName};{university};{faculty};{department};{age};{course};{group};{city}\n";
        }

        public int CompareTo(Student other)
        {
            int compare;

            compare = this.course.CompareTo(other.course);

            if (compare == 0)
            {
                compare = this.age.CompareTo(other.age);
            }

            return compare;
        }
    }
}
