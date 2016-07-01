using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Verticalline
    {

        List<Point> pList;

        public Verticalline(int yTop, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
