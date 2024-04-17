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
        protected Pen pen = new Pen(Color.Black, 4);
        protected SolidBrush brush = new SolidBrush(Color.Black);

        protected int _size;
        public Color color { 
            get { return pen.Color; } 
            set { 
                pen.Color = value;
                brush.Color = value;
            }
        }

        public int size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                pen.Width = value;
            }
        }
        
    }
}
