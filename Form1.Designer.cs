namespace Prog2_drawingPrograme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pxbPapper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).BeginInit();
            this.SuspendLayout();
            // 
            // pxbPapper
            // 
            this.pxbPapper.Location = new System.Drawing.Point(206, 1);
            this.pxbPapper.Name = "pxbPapper";
            this.pxbPapper.Size = new System.Drawing.Size(561, 597);
            this.pxbPapper.TabIndex = 0;
            this.pxbPapper.TabStop = false;
            this.pxbPapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbPapper_Paint);
            this.pxbPapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseDown);
            this.pxbPapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseMove);
            this.pxbPapper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.pxbPapper);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbPapper;
    }
}

