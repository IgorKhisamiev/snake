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
            Point p1 = new Point(4, 3, '#');
            Point p2 = new Point(3, 3, '#');
            p1.Draw();
            p2.Draw();

            HorizontalLine line = new HorizontalLine(2,8,8,'*');
            line.Drow();

            verticalLine line2 = new verticalLine(3, 4, 12, '$');
            line2.Drow2();

            Console.ReadKey();
        }


    }
}
