using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_30._07._21
{
    class Ex1
    {
        public static void ex1()
        {
            Console.WriteLine(Console.LargestWindowHeight);
            Console.WriteLine(Console.LargestWindowWidth);

            Console.WindowWidth = Console.LargestWindowWidth - 10;
            Console.WindowHeight = Console.LargestWindowHeight - 10;

            int ax = 60, ay = 1;
            int bx = 2, by = 40;
            int cx = 40, cy = 40;

            Console.SetCursorPosition(ax, ay); Console.WriteLine("*");
            Console.SetCursorPosition(bx, by); Console.WriteLine("*");
            Console.SetCursorPosition(cx, cy); Console.WriteLine("*");
        }
        
    }
}
