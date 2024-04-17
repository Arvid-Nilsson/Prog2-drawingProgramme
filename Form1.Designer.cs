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
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.btnSizeUp = new System.Windows.Forms.Button();
            this.btnSizeDown = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbxFill = new System.Windows.Forms.CheckBox();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnPenna = new System.Windows.Forms.Button();
            this.btnRektangel = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSizeDown);
            this.groupBox1.Controls.Add(this.btnSizeUp);
            this.groupBox1.Controls.Add(this.tbxSize);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Location = new System.Drawing.Point(29, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Storlek ";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(46, 50);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(51, 20);
            this.tbxSize.TabIndex = 1;
            this.tbxSize.Text = "4";
            this.tbxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSize.TextChanged += new System.EventHandler(this.tbxSize_TextChanged);
            // 
            // btnSizeUp
            // 
            this.btnSizeUp.Location = new System.Drawing.Point(7, 50);
            this.btnSizeUp.Name = "btnSizeUp";
            this.btnSizeUp.Size = new System.Drawing.Size(33, 20);
            this.btnSizeUp.TabIndex = 2;
            this.btnSizeUp.Text = "↑";
            this.btnSizeUp.UseVisualStyleBackColor = true;
            this.btnSizeUp.Click += new System.EventHandler(this.btnSizeUp_Click);
            // 
            // btnSizeDown
            // 
            this.btnSizeDown.Location = new System.Drawing.Point(103, 49);
            this.btnSizeDown.Name = "btnSizeDown";
            this.btnSizeDown.Size = new System.Drawing.Size(33, 20);
            this.btnSizeDown.TabIndex = 3;
            this.btnSizeDown.Text = "\t↓";
            this.btnSizeDown.UseVisualStyleBackColor = true;
            this.btnSizeDown.Click += new System.EventHandler(this.btnSizeDown_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(38, 393);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Välj färg";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cbxFill
            // 
            this.cbxFill.AutoSize = true;
            this.cbxFill.Location = new System.Drawing.Point(35, 160);
            this.cbxFill.Name = "cbxFill";
            this.cbxFill.Size = new System.Drawing.Size(78, 17);
            this.cbxFill.TabIndex = 6;
            this.cbxFill.Text = "Fyll i former";
            this.cbxFill.UseVisualStyleBackColor = true;
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnLine);
            this.gbxTools.Controls.Add(this.btnRektangel);
            this.gbxTools.Controls.Add(this.btnPenna);
            this.gbxTools.Controls.Add(this.cbxFill);
            this.gbxTools.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbxTools.Location = new System.Drawing.Point(29, 43);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Size = new System.Drawing.Size(144, 185);
            this.gbxTools.TabIndex = 7;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Verktyg";
            // 
            // btnPenna
            // 
            this.btnPenna.Location = new System.Drawing.Point(35, 20);
            this.btnPenna.Name = "btnPenna";
            this.btnPenna.Size = new System.Drawing.Size(75, 23);
            this.btnPenna.TabIndex = 7;
            this.btnPenna.Text = "Penna";
            this.btnPenna.UseVisualStyleBackColor = true;
            this.btnPenna.Click += new System.EventHandler(this.btnPenna_Click);
            // 
            // btnRektangel
            // 
            this.btnRektangel.Location = new System.Drawing.Point(35, 70);
            this.btnRektangel.Name = "btnRektangel";
            this.btnRektangel.Size = new System.Drawing.Size(75, 23);
            this.btnRektangel.TabIndex = 8;
            this.btnRektangel.Text = "Rektangel";
            this.btnRektangel.UseVisualStyleBackColor = true;
            this.btnRektangel.Click += new System.EventHandler(this.btnRektangel_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(35, 117);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "linje";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pxbPapper);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxTools.ResumeLayout(false);
            this.gbxTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbPapper;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnSizeDown;
        private System.Windows.Forms.Button btnSizeUp;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cbxFill;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnPenna;
        private System.Windows.Forms.Button btnRektangel;
        private System.Windows.Forms.Button btnLine;
    }
}

