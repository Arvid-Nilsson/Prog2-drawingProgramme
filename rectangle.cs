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
            firstPoint = point;
            isRectangleing = true;
        }
        public void release(Point secondPoint, Graphics g)
        {
            if (isRectangleing)
            {
                int width = Math.Abs(secondPoint.X - firstPoint.X);
                int height = Math.Abs(secondPoint.Y - firstPoint.Y);
                int x = Math.Min(secondPoint.X, firstPoint.X);
                int y = Math.Min(secondPoint.Y, firstPoint.Y);

                if(fill == false) 
                {
                    g.DrawRectangle(pen, x, y, width, height);
                }
                else
                {
                    g.FillRectangle(brush, x, y, width, height);
                }
                
                

                // Reset the state
                isRectangleing = false;
            }
        }
    }
}
