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
            Console.SetBufferSize(80, 25);

            //отрисовка рамки

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            verticalLine leftLine = new verticalLine(0, 0, 24, '+');
            verticalLine rightLine = new verticalLine(78, 0, 24, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            // draw point

            Point p = new Point(4, 5, '*');
            //p.Draw();

            //создаем класс snake

            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();


            
            Console.ReadKey();
        }


    }
}
