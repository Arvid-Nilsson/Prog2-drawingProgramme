using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_drawingPrograme
{
    public class line : tool
    {
        private Point firstPoint;
        bool isMakingLine = false;

        //Storing the first point
        public void click(Point point)
        {
            firstPoint = point;
            isMakingLine = true;
        }
        public void release(Point secondPoint, Graphics g)
        {
            if (isMakingLine)
            {
                //Defining the x and y positions of both endpoints of the line
                float x1 = firstPoint.X;
                float x2 = secondPoint.X;
                float y1 = firstPoint.Y;
                float y2 = secondPoint.Y;

                //Drawing the line
                g.DrawLine(pen, x1, y1, x2, y2);

                //Reseting the tools state
                isMakingLine = false;
            }
        }
    }
}
