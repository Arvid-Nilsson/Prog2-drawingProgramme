using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_drawingPrograme
{
    
    public partial class Form1 : Form
    {
        //Int to store the current tool used 0 = Pencile, 1 = Rectangle, 2 = Line, 3 = Ellipse, 4 = Circle
        public int toolused = 0;

        //Creating objects of the tools
        public pencile Pencile = new pencile();
        public rectangle Rectangle = new rectangle();
        public line Line = new line();
        public ellipse Ellipse = new ellipse();
        public circle Circle = new circle();
        

        // Create a bitmap to store the drawings sufrace
        private Bitmap drawingSurface = new Bitmap(554, 589);
        
        public Form1()
        {
            InitializeComponent();

            //Create the drawing surface by setting it to white
            InitializeDrawingSurface();
    }

        //Method to create drawing surface by setting it to white
        private void InitializeDrawingSurface()
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.White);
            }
        }
        private void pxbPapper_Paint(object sender, PaintEventArgs e)
        {
            // Drawing drawingsurface on pbxPapper
            e.Graphics.DrawImage(drawingSurface, Point.Empty);
        }

        //Event that triggers when mouse button is pressed
        private void pxbPapper_MouseDown(object sender, MouseEventArgs e)
        {
            //Run the code click code for each tool
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
                case 3:
                    Ellipse.click(e.Location);
                    break;
                case 4:
                    Circle.click(e.Location);
                    break;
            }

        }

        //Event that triggers when mouse is moved
        private void pxbPapper_MouseMove(object sender, MouseEventArgs e)
        {
            //Drawing with the pen if it is selected
            if(toolused == 0)
            {
                Pencile.draw(e, Graphics.FromImage(drawingSurface));
            }
            pbxPapper.Invalidate();
        }

        //Event that triggers when mouse button is relesed
        private void pxbPapper_MouseUp(object sender, MouseEventArgs e)
        {
            //Running the code for mouse relese in each tool
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
                case 3:
                    Ellipse.release(e.Location, Graphics.FromImage(drawingSurface));
                    break;
                case 4:
                    Circle.release(e.Location, Graphics.FromImage(drawingSurface));
                    break;
            }
        }

        
        //Event to reset drawing surface
        private void btnReset_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawingSurface))
            {
                g.Clear(Color.White);
            }
        }

        
        //Event to change the tools size when the textbox is uppdated
        private void tbxSize_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                //Changing the text size if the size is greater than 0 otherwise setting it to 1
                int tempSize = int.Parse(tbxSize.Text);
                if (tempSize > 0)
                {
                    Pencile.size = tempSize;
                    Rectangle.size = tempSize;
                    Line.size = tempSize;
                }
                else
                {
                    tbxSize.Text = "1";
                }
            }
            catch {
               
            }
            
        }

        //Event for button to increase the text size
        private void btnSizeUp_Click(object sender, EventArgs e)
        {
            tbxSize.Text = (int.Parse(tbxSize.Text) + 1).ToString();
        }

        //Event for button to decrease the text size
        private void btnSizeDown_Click(object sender, EventArgs e)
        {
            tbxSize.Text = (int.Parse(tbxSize.Text) - 1).ToString();
        }

        //Event to change the tools color
        private void btnColor_Click(object sender, EventArgs e)
        {
            //Opening the color dialogue 
            if(cDTool.ShowDialog() == DialogResult.OK)
            {
                //Set the tools colors to the color selected
                Pencile.color = cDTool.Color;
                Rectangle.color = cDTool.Color;
                Line.color = cDTool.Color;
                Ellipse.color = cDTool.Color;
                Circle.color = cDTool.Color;
            }
        }

        //Event to change if shapes fill
        private void cbxFill_CheckedChanged(object sender, EventArgs e)
        {
            Rectangle.fill = cbxFill.Checked;
            Ellipse.fill = cbxFill.Checked;
            Circle.fill = cbxFill.Checked;
        }

        //Event to change tool to penncile
        private void btnPenna_Click(object sender, EventArgs e)
        {
            toolused = 0;
        }

        //Event to change the tool to Rectangle
        private void btnRektangel_Click(object sender, EventArgs e)
        {
            toolused = 1;
        }

        //Event to change the tool to Line
        private void btnLine_Click(object sender, EventArgs e)
        {
            toolused = 2;
        }

        //Event to change the tool to ellipse
        private void lblEllipse_Click(object sender, EventArgs e)
        {
            toolused = 3;
        }

        //Event to change the tool to circle
        private void btnCircle_Click(object sender, EventArgs e)
        {
            toolused = 4;
        }

        //Event to save the drawing surface to pnd
        private void button1_Click(object sender, EventArgs e)
        {
            // Creating a dialogue window to select save location and name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Saving the picture as png
                drawingSurface.Save(saveFileDialog.FileName, ImageFormat.Png);
            }

        }

        //Event to load background image
        private void btnChangeBackgroundImage_Click(object sender, EventArgs e)
        {
            // Creating a dialogue box to select background image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files (*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // load the selected image
                Bitmap loadedImage = new Bitmap(openFileDialog.FileName);

                // Scale the picture to the drawing surface
                Bitmap scaledImage = new Bitmap(pbxPapper.Width, pbxPapper.Height);
                using (Graphics g = Graphics.FromImage(scaledImage))
                {
                    g.DrawImage(loadedImage, 0, 0, pbxPapper.Width, pbxPapper.Height);
                }

                // making the drawing surface the image
                drawingSurface = scaledImage;
                pbxPapper.Image = drawingSurface;
            }
        }

        private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            
        }
    }
}


    