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
            this.btnPenna = new System.Windows.Forms.Button();
            this.btnRektangel = new System.Windows.Forms.Button();
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
            // btnPenna
            // 
            this.btnPenna.Location = new System.Drawing.Point(31, 28);
            this.btnPenna.Name = "btnPenna";
            this.btnPenna.Size = new System.Drawing.Size(75, 23);
            this.btnPenna.TabIndex = 1;
            this.btnPenna.Text = "Penna";
            this.btnPenna.UseVisualStyleBackColor = true;
            this.btnPenna.Click += new System.EventHandler(this.btnPenna_Click);
            // 
            // btnRektangel
            // 
            this.btnRektangel.Location = new System.Drawing.Point(31, 71);
            this.btnRektangel.Name = "btnRektangel";
            this.btnRektangel.Size = new System.Drawing.Size(75, 23);
            this.btnRektangel.TabIndex = 2;
            this.btnRektangel.Text = "Rektangel ";
            this.btnRektangel.UseVisualStyleBackColor = true;
            this.btnRektangel.Click += new System.EventHandler(this.btnRektangel_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.btnRektangel);
            this.Controls.Add(this.btnPenna);
            this.Controls.Add(this.pxbPapper);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbPapper;
        private System.Windows.Forms.Button btnPenna;
        private System.Windows.Forms.Button btnRektangel;
    }
}

