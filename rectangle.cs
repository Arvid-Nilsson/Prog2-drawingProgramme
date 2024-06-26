﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_drawingPrograme
{
    public class rectangle : tool
    {
        private Point firstPoint;
        private bool isRectangleing = false;
        public bool fill = false;

        public void click(Point point)
        {
            //Store the mouses position  
            firstPoint = point;
            isRectangleing = true;
        }
        public void release(Point secondPoint, Graphics g)
        {
            //Create rectangle
            if (isRectangleing)
            {
                //Assigning the width and height to the distance between the 2 points in X and Y directions
                int width = Math.Abs(secondPoint.X - firstPoint.X);
                int height = Math.Abs(secondPoint.Y - firstPoint.Y);

                // Selecting the x and y coordinates from the point that is most up and right
                int x = Math.Min(secondPoint.X, firstPoint.X);
                int y = Math.Min(secondPoint.Y, firstPoint.Y);

                //Creating a rectangle that is either filled or not filled depending on the fill variable
                if(fill == false) 
                {
                    g.DrawRectangle(pen, x, y, width, height);
                }
                else
                {
                    g.FillRectangle(brush, x, y, width, height);
                }
               
                //Reseting the tool
                isRectangleing = false;
            }
        }
    }
}
