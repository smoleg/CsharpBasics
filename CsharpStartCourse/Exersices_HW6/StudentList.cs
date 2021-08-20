using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_HW6
{
    class StudentList : StListActions
    {
        public void FileStudent(string path, int n)
        {
            StringBuilder sb = new();
            sb.Append("firstName;secondName;univercity;faculty;department;age;сourse;group;city\n");
            for (int i = 0; i < n; i++)
            {
                sb.Append(Student.GetStudent());
            }
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        public List<Student> GetList(string path)
        {
            List<Student> StList = new();
            StreamReader sr = new StreamReader(path);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                StList.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
            }
            sr.Close();

            return StList;
        }

        public void Print(List<Student> stList)
        {
            foreach (Student student in stList)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
