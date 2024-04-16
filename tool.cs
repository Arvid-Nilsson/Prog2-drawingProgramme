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
        public Color color { get { return pen.Color; } set { pen.Color = value; } }
    }
}
