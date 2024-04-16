using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_drawingPrograme
{
    
    public partial class Form1 : Form
    {
        public int toolused = 0;
        public pencile Pencile = new pencile();
        public rectangle Rectangle = new rectangle();
        public line Line = new line();

        // Deklarera en bitmap för att lagra ritområdet
        private Bitmap drawingSurface = new Bitmap(800, 600);
        public Form1()
        {
            InitializeComponent();

            // Kör metoden för att skapa ett ritområdet genom att rensa det till vit färg
            InitializeDrawingSurface();
    }

        // Metod för att skapa ett ritområde genom att rensa det till vit färg.
        private void InitializeDrawingSurface()
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.White);
            }
        }

        // Händelsehanterare som aktiveras när användaren klickar ned musknappen för att börja rita.
        private void pxbPapper_MouseDown(object sender, MouseEventArgs e)
        {
            switch (toolused)
            {
                case 0:
                    Pencile.startDraw(e);
                    break;
                case 1:
                    Rectangle.click(e.Location);
                    break;
                case 2:
                    Line.click(e.Location);
                    break;
            }

        }

        // Händelsehanterare som aktiveras när användaren rör musen och ritningen pågår.
        private void pxbPapper_MouseMove(object sender, MouseEventArgs e)
        {
            switch(toolused )
            {
                case 0:
                    Pencile.draw(e, Graphics.FromImage(drawingSurface));
                    break;
                case 1:
                    break;
                case 2:
                    break; 
            }
            pxbPapper.Invalidate();
        }

        // Händelsehanterare som aktiveras när användaren släpper musknappen.
        private void pxbPapper_MouseUp(object sender, MouseEventArgs e)
        {
            switch (toolused)
            {
                case 0:
                    Pencile.endDraw();
                    break;
                case 1:
                    Rectangle.release(e.Location, Graphics.FromImage(drawingSurface));
                    break;
                case 2:
                    Line.release(e.Location, Graphics.FromImage(drawingSurface));
                    break;
            }
        }

        private void pxbPapper_Paint(object sender, PaintEventArgs e)
        {
            // Rita ritområdet på PictureBox
            e.Graphics.DrawImage(drawingSurface, Point.Empty);
        }

        private void btnPenna_Click(object sender, EventArgs e)
        {
            toolused = 0;
        }

        private void btnRektangel_Click(object sender, EventArgs e)
        {
            toolused = 1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.White);
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            toolused = 2;
        }
    }
}


    