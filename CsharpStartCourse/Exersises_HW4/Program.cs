using System;

namespace Exersises_HW4
{
    class Program
    {
        static void Main()
        {
            // Смоляков Егор

            int[] arr = new int[20];                                    // Задача 1, Задача 2
            StaticClass.InitRandArray(arr);
            StaticClass.Print(arr);
            StaticClass.PairCount(arr);

            Console.WriteLine();                                        // Задача 2. Пункт в
            string path = "array.txt";
            int[] arr2 = StaticClass.ArrayFromFile(path);
            StaticClass.Print(arr2);
        }
    }
}
