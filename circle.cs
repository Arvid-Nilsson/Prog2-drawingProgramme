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
    public class circle : tool
    {
        private Point firstPoint;
        private bool isCircling = false;
        public bool fill = false;


        //Stor the position of the center of the circle
        public void click(Point point)
        {
            firstPoint = point;
            isCircling = true;
        }
        public void release(Point secondPoint, Graphics g)
        {
            if (isCircling)
            {
                //Defining variables for the distance between the point
                int distanceY = Math.Abs(secondPoint.Y - firstPoint.Y);
                int distanceX = Math.Abs(secondPoint.X - firstPoint.X);

                //Calculating the diameter of the circle by using the pytagrean thearum 
                int diameter = 2 * Convert.ToInt32(Math.Sqrt(Math.Pow(distanceY, 2) + Math.Pow(distanceX, 2)));

                //Calculating the position of the circle
                int x = firstPoint.X - (diameter/2);
                int y = firstPoint.Y - (diameter/2);

                //Creating a circle that is either filled or not filled depending on the fill variable
                if (fill == false)
                {
                    g.DrawEllipse(pen, x, y, diameter, diameter);
                }
                else
                {
                    g.FillEllipse(brush, x, y, diameter, diameter);
                }

                //Reset the tools state
                isCircling = false;
            }
        }
    }
}
