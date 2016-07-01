using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
             Point p1 = new Point(1, 3, '*');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw();

            Horizontalline line = new Horizontalline(5, 10, 8, '+');
            line.Drow();

            Verticalline vLine = new Verticalline(10, 17, 15, 'x');
            vLine.Drow();
                        
            Console.ReadLine();
        }
    }
}
