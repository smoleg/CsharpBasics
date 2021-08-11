using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exersises_HW4
{
    // Смоляков Егор

    // Задача 1
    // Дан целочисленный массив из 20 элементов.
    // Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    // Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    // В данной задаче под парой подразумевается два подряд идущих элемента массива.

    // Задача 2
    // Реализуйте задачу 1 в виде статического класса StaticClass;
    // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    // б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    // в)* Добавьте обработку ситуации отсутствия файла на диске.

    static class StaticClass
    {
        public static void InitRandArray(int[] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10001,10001);
            }           
        }

        public static void Print (int[] arr)
        {
            Console.WriteLine("Элементы массива:");
            foreach (int a in arr)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public static void PairCount (int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine($"\nКоличество искомых пар: {count}");
        }

        public static int[] ArrayFromFile (string path)
        {
            int[] arr = Array.Empty<int>();
            string[] substr;

            try
            {
                StreamReader sr = new StreamReader(path);
                substr = sr.ReadLine().Split(' ');
                arr = new int[substr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(substr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            return arr;
        }
    }
}
