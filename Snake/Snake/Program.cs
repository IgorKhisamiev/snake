using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 33;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);
            Draw(5, 5, '&');

            Console.ReadKey();
        }

        static void Draw(int x1, int y1, char sym1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
        }
    }
}
