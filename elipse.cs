using System;
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
    public class ellipse : tool
    {
        private Point firstPoint;
        public bool fill = false;

        //Variable to track the tools state, if the first point is stored
        private bool isEllipsing = false;


        //Method to store the mouse position when mouse is clicked down
        public void click(Point point)
        {
            firstPoint = point;
            isEllipsing = true;
        }
        public void release(Point secondPoint, Graphics g)
        {
            if (isEllipsing)
            {
                //Assigning the width and height to the distance between the 2 points in X and Y directions
                int width = Math.Abs(secondPoint.X - firstPoint.X);
                int height = Math.Abs(secondPoint.Y - firstPoint.Y);

                // Selecting the x and y coordinates from the point that is most up and right
                int x = Math.Min(secondPoint.X, firstPoint.X);
                int y = Math.Min(secondPoint.Y, firstPoint.Y);

                //Creating a ellipse that is either filled or not filled depending on the fill variable
                if (fill == false)
                {
                    g.DrawEllipse(pen, x, y, width, height);
                }
                else
                {
                    g.FillEllipse(brush, x, y, width, height);
                }

                //Reseting the tool 
                isEllipsing = false;
            }
        }
    }
}
