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
            Console.SetBufferSize(80, 25);
            
            //Отрисовка рамки         
            Horizontalline upLine = new Horizontalline(0, 78, 0, '+');
            upLine.Drow();
            Horizontalline downLine = new Horizontalline(0, 78, 24, '+');
            downLine.Drow();
            Verticalline leftLine = new Verticalline(0, 24, 0, '+');
            leftLine.Drow();
            Verticalline rightLine = new Verticalline(0, 24, 78, '+');
            rightLine.Drow();

            //Отрисовка точки
            Point p = new Point(4, 5, '*');
            p.Draw();

                                  
            Console.ReadLine();
        }
    }
}
