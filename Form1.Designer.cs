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
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).BeginInit();
            this.gbxTools.SuspendLayout();
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
            this.btnPenna.Location = new System.Drawing.Point(35, 35);
            this.btnPenna.Name = "btnPenna";
            this.btnPenna.Size = new System.Drawing.Size(75, 23);
            this.btnPenna.TabIndex = 1;
            this.btnPenna.Text = "Penna";
            this.btnPenna.UseVisualStyleBackColor = true;
            this.btnPenna.UseWaitCursor = true;
            this.btnPenna.Click += new System.EventHandler(this.btnPenna_Click);
            // 
            // btnRektangel
            // 
            this.btnRektangel.Location = new System.Drawing.Point(35, 88);
            this.btnRektangel.Name = "btnRektangel";
            this.btnRektangel.Size = new System.Drawing.Size(75, 23);
            this.btnRektangel.TabIndex = 2;
            this.btnRektangel.Text = "Rektangel ";
            this.btnRektangel.UseVisualStyleBackColor = true;
            this.btnRektangel.UseWaitCursor = true;
            this.btnRektangel.Click += new System.EventHandler(this.btnRektangel_Click);
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnLine);
            this.gbxTools.Controls.Add(this.btnPenna);
            this.gbxTools.Controls.Add(this.btnRektangel);
            this.gbxTools.Location = new System.Drawing.Point(29, 43);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Size = new System.Drawing.Size(144, 175);
            this.gbxTools.TabIndex = 3;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Verktyg ";
            this.gbxTools.UseWaitCursor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(64, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "starta om";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(35, 137);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "Linie";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.pxbPapper);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).EndInit();
            this.gbxTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbPapper;
        private System.Windows.Forms.Button btnPenna;
        private System.Windows.Forms.Button btnRektangel;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLine;
    }
}

