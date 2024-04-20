using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_drawingPrograme
{
    public class pencile : tool
    {
        private bool isDrawing = false;
        private Point previousPoint;

        //Method to start drawing
        public void startDraw(MouseEventArgs e)
        {
            isDrawing = true;                                
            previousPoint = e.Location;
        }

        //Method to stop drawing
        public void endDraw() { 
            isDrawing = false;
        }

        //Method to draw
        public void draw (MouseEventArgs e, Graphics g) {

            if (isDrawing)
            {
                using (g)
                {
                    //Changing the quality to high
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    // Drawing a line from the last mouse position to the new
                    g.DrawLine(pen, previousPoint, e.Location);
                }
                //Saving the current mouse position
                previousPoint = e.Location;

            }

        }
    }
}
