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
            this.pbxPapper = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSizeDown = new System.Windows.Forms.Button();
            this.btnSizeUp = new System.Windows.Forms.Button();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.cDTool = new System.Windows.Forms.ColorDialog();
            this.cbxFill = new System.Windows.Forms.CheckBox();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.lblEllipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRektangel = new System.Windows.Forms.Button();
            this.btnPenna = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeBackgroundImage = new System.Windows.Forms.Button();
            this.gbxBackground = new System.Windows.Forms.GroupBox();
            this.btnChangeBackgroundColor = new System.Windows.Forms.Button();
            this.cDBackground = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPapper)).BeginInit();
            this.gbxTools.SuspendLayout();
            this.gbxBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPapper
            // 
            this.pbxPapper.Location = new System.Drawing.Point(206, 1);
            this.pbxPapper.Name = "pbxPapper";
            this.pbxPapper.Size = new System.Drawing.Size(554, 589);
            this.pbxPapper.TabIndex = 0;
            this.pbxPapper.TabStop = false;
            this.pbxPapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbPapper_Paint);
            this.pbxPapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseDown);
            this.pbxPapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseMove);
            this.pbxPapper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseUp);
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
            // btnSizeDown
            // 
            this.btnSizeDown.Location = new System.Drawing.Point(103, 269);
            this.btnSizeDown.Name = "btnSizeDown";
            this.btnSizeDown.Size = new System.Drawing.Size(33, 20);
            this.btnSizeDown.TabIndex = 3;
            this.btnSizeDown.Text = "\t↓";
            this.btnSizeDown.UseVisualStyleBackColor = true;
            this.btnSizeDown.Click += new System.EventHandler(this.btnSizeDown_Click);
            // 
            // btnSizeUp
            // 
            this.btnSizeUp.Location = new System.Drawing.Point(7, 270);
            this.btnSizeUp.Name = "btnSizeUp";
            this.btnSizeUp.Size = new System.Drawing.Size(33, 20);
            this.btnSizeUp.TabIndex = 2;
            this.btnSizeUp.Text = "↑";
            this.btnSizeUp.UseVisualStyleBackColor = true;
            this.btnSizeUp.Click += new System.EventHandler(this.btnSizeUp_Click);
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(46, 270);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(51, 20);
            this.tbxSize.TabIndex = 1;
            this.tbxSize.Text = "4";
            this.tbxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSize.TextChanged += new System.EventHandler(this.tbxSize_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 245);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Storlek ";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(35, 305);
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
            this.cbxFill.Location = new System.Drawing.Point(35, 345);
            this.cbxFill.Name = "cbxFill";
            this.cbxFill.Size = new System.Drawing.Size(78, 17);
            this.cbxFill.TabIndex = 6;
            this.cbxFill.Text = "Fyll i former";
            this.cbxFill.UseVisualStyleBackColor = true;
            this.cbxFill.CheckedChanged += new System.EventHandler(this.cbxFill_CheckedChanged);
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnSizeDown);
            this.gbxTools.Controls.Add(this.btnColor);
            this.gbxTools.Controls.Add(this.btnCircle);
            this.gbxTools.Controls.Add(this.btnSizeUp);
            this.gbxTools.Controls.Add(this.lblEllipse);
            this.gbxTools.Controls.Add(this.tbxSize);
            this.gbxTools.Controls.Add(this.btnLine);
            this.gbxTools.Controls.Add(this.lblSize);
            this.gbxTools.Controls.Add(this.btnRektangel);
            this.gbxTools.Controls.Add(this.btnPenna);
            this.gbxTools.Controls.Add(this.cbxFill);
            this.gbxTools.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbxTools.Location = new System.Drawing.Point(29, 73);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Size = new System.Drawing.Size(147, 378);
            this.gbxTools.TabIndex = 7;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Verktyg";
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(35, 199);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 11;
            this.btnCircle.Text = "Cirkel";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // lblEllipse
            // 
            this.lblEllipse.Location = new System.Drawing.Point(35, 159);
            this.lblEllipse.Name = "lblEllipse";
            this.lblEllipse.Size = new System.Drawing.Size(75, 23);
            this.lblEllipse.TabIndex = 10;
            this.lblEllipse.Text = "Ellips";
            this.lblEllipse.UseVisualStyleBackColor = true;
            this.lblEllipse.Click += new System.EventHandler(this.lblEllipse_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeBackgroundImage
            // 
            this.btnChangeBackgroundImage.Location = new System.Drawing.Point(35, 29);
            this.btnChangeBackgroundImage.Name = "btnChangeBackgroundImage";
            this.btnChangeBackgroundImage.Size = new System.Drawing.Size(91, 23);
            this.btnChangeBackgroundImage.TabIndex = 9;
            this.btnChangeBackgroundImage.Text = "Bakgrundsbild";
            this.btnChangeBackgroundImage.UseVisualStyleBackColor = true;
            this.btnChangeBackgroundImage.Click += new System.EventHandler(this.btnChangeBackgroundImage_Click);
            // 
            // gbxBackground
            // 
            this.gbxBackground.Controls.Add(this.btnChangeBackgroundColor);
            this.gbxBackground.Controls.Add(this.btnChangeBackgroundImage);
            this.gbxBackground.Location = new System.Drawing.Point(29, 473);
            this.gbxBackground.Name = "gbxBackground";
            this.gbxBackground.Size = new System.Drawing.Size(147, 106);
            this.gbxBackground.TabIndex = 10;
            this.gbxBackground.TabStop = false;
            this.gbxBackground.Text = "Bakgrund";
            // 
            // btnChangeBackgroundColor
            // 
            this.btnChangeBackgroundColor.Location = new System.Drawing.Point(35, 67);
            this.btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            this.btnChangeBackgroundColor.Size = new System.Drawing.Size(91, 23);
            this.btnChangeBackgroundColor.TabIndex = 10;
            this.btnChangeBackgroundColor.Text = "Välj färg";
            this.btnChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.btnChangeBackgroundColor.Click += new System.EventHandler(this.btnChangeBackgroundColor_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.gbxBackground);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbxPapper);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPapper)).EndInit();
            this.gbxTools.ResumeLayout(false);
            this.gbxTools.PerformLayout();
            this.gbxBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPapper;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnSizeDown;
        private System.Windows.Forms.Button btnSizeUp;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cDTool;
        private System.Windows.Forms.CheckBox cbxFill;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnPenna;
        private System.Windows.Forms.Button btnRektangel;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button lblEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangeBackgroundImage;
        private System.Windows.Forms.GroupBox gbxBackground;
        private System.Windows.Forms.Button btnChangeBackgroundColor;
        private System.Windows.Forms.ColorDialog cDBackground;
    }
}

