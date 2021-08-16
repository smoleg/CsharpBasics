using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exersices_HW5
{
    // Смоляков Егор
    // Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    // а) Вывести только те слова сообщения, которые содержат не более n букв.
    // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    // в) Найти самое длинное слово сообщения.
    // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

    static class Message
    {
        public static void NWord(string message, int n)
        {
            string[] words = message.Split(' ');
            Console.WriteLine($"Исходное выражение:\n{message}");

            Console.WriteLine($"\nСлова, содержащие не более {n} букв:");
            foreach (string w in words)
            {
                if (w.Length <= n) Console.Write(w + " ");
            }
        }

        public static void RemoveWord(string message, char sym)
        {
            string[] words = message.Split(' ');
            string regexp = @$"[*{sym}]";

            Console.WriteLine($"Исходное выражение:\n{message}");
            Console.WriteLine($"Удаление по последнему символу: {sym}");

            foreach (string w in words)
            {
                if (Regex.IsMatch(w, regexp))
                {
                    words = words.Where(val => val != w).ToArray();
                }
            }

            message = string.Join(' ', words);
            Console.WriteLine($"\nНовое выражение:\n{message}");
        }

        public static void LongestW(string message)
        {
            int maxL = 0;
            string[] words = message.Split(' ');

            Console.WriteLine($"Исходное выражение:\n{message}");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > words[maxL].Length) maxL = i;
            }

            Console.WriteLine($"Самое длинное слово сообщения: {words[maxL]}");
        }

        public static void SBLongWords(string message)
        {
            int maxL = 0;
            string[] words = message.Split(' ');
            StringBuilder sb = new();

            Console.WriteLine($"Исходное выражение:\n{message}");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxL) maxL = words[i].Length;
            }

            foreach (string w in words)
            {
                if (w.Length == maxL)
                {
                    sb.Append(w + " ");
                }
            }

            Console.WriteLine($"Выражение из самых длинных слов:\n{sb.ToString()}");
        }
    }
}
