﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
        
            //Отрисовка рамки         
            Horizontalline upLine = new Horizontalline(0, mapWidth - 2, 0, '+');
            Horizontalline downLine = new Horizontalline(0, mapWidth - 2, mapHeight - 1, '+');
            Verticalline leftLine = new Verticalline(0, mapHeight - 1, 0, '+');
            Verticalline rightLine = new Verticalline(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
       
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
