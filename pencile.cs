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

        public void startDraw(MouseEventArgs e)
        {
            isDrawing = true;                                
            previousPoint = e.Location;
        }
        public void endDraw() { 
            isDrawing = false;
        }
        public void draw (MouseEventArgs e, Graphics g) {

            if (isDrawing)
            {
                using (g)
                {
                    // Rita en linje från föregående musposition till nuvarande musposition med den svarta pennan
                    g.DrawLine(pen, previousPoint, e.Location);
                }
                previousPoint = e.Location;

                // Uppdatera PictureBox för att visa de ändringar som gjorts på ritområdet

            }

        }
    }
}
