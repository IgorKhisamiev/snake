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
            //int x1 = 33;
            //int y1 = 3;
            //char sym1 = '*';

            Point p1= new Point();
            Point p2 = new Point();
            Point p3 = new Point(4,3,'#');
            //p1.sym = '*';
            //p1.x = 3;
            //p1.y = 5;
            p3.Draw();

            //p1.Draw(2, 3, '%');


            //p2.Draw(5, 5, '&');
            
            //Draw(x1, y1, sym1);
            //Draw(5, 5, '&');

            Console.ReadKey();
        }

        //static void Draw(int x1, int y1, char sym1)
        //{
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    Console.SetCursorPosition(x1, y1);
        //    Console.Write(sym1);
        //}
    }
}
