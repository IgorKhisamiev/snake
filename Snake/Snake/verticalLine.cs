using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class verticalLine
    {
        List<Point> pList2;
        public verticalLine(int x, int yUp, int yDown, char sym)
        {
            pList2 = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList2.Add(p);
            }

        }

        public void Drow2()
        {
            foreach (Point p in pList2)
            {
                p.Draw();
            }




        }
    }
}


