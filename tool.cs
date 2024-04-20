using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_drawingPrograme
{
    public class tool
    {
        //Creating a pen and brush for all tools
        protected Pen pen = new Pen(Color.Black, 4);
        protected SolidBrush brush = new SolidBrush(Color.Black);

        protected int _size;
        public Color color { 
            //If pen and brush have the same color which they should always have returning it 
            get { 
                if(pen.Color == brush.Color)
                {
                    return pen.Color;
                }
                else
                {
                    return Color.Black;
                }
            } 
            set { 
                //Set the pen and brush color to the assign value
                pen.Color = value;
                brush.Color = value;
            }
        }

        public int size
        {
            get
            {
                //Return the encapsulated variable _size
                return _size;
            }
            set
            {
                //Set the encapsulated variable _size and change the pens width
                _size = value;
                pen.Width = value;
            }
        }
        
    }
}
