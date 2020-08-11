namespace FormAndClass
{
    partial class PictureBoxForm
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
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.pensizeLbl = new System.Windows.Forms.Label();
            this.penSize2Lbl = new System.Windows.Forms.Label();
            this.sayColorLbl = new System.Windows.Forms.Label();
            this.curColorLbl = new System.Windows.Forms.Label();
            this.isFilledLbl = new System.Windows.Forms.Label();
            this.mouseCurPosLbl = new System.Windows.Forms.Label();
            this.fillSubColorBtn = new System.Windows.Forms.Button();
            this.drawHexagonBtn = new System.Windows.Forms.Button();
            this.drawTriangleBtn = new System.Windows.Forms.Button();
            this.drawCircleBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.drawEllipseBtn = new System.Windows.Forms.Button();
            this.drawRectBtn = new System.Windows.Forms.Button();
            this.drawLineBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(818, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Pen (+)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PenPlusBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(818, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Pen (-)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PenMinusBtn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(547, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Undo <--";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(547, 68);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Clear Form";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ClrAllBtn_Click);
            // 
            // pensizeLbl
            // 
            this.pensizeLbl.AutoSize = true;
            this.pensizeLbl.Location = new System.Drawing.Point(824, 13);
            this.pensizeLbl.Name = "pensizeLbl";
            this.pensizeLbl.Size = new System.Drawing.Size(52, 13);
            this.pensizeLbl.TabIndex = 14;
            this.pensizeLbl.Text = "Pen Size:";
            this.pensizeLbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // penSize2Lbl
            // 
            this.penSize2Lbl.AutoSize = true;
            this.penSize2Lbl.Location = new System.Drawing.Point(873, 11);
            this.penSize2Lbl.Name = "penSize2Lbl";
            this.penSize2Lbl.Size = new System.Drawing.Size(0, 13);
            this.penSize2Lbl.TabIndex = 15;
            // 
            // sayColorLbl
            // 
            this.sayColorLbl.AutoSize = true;
            this.sayColorLbl.Location = new System.Drawing.Point(576, 95);
            this.sayColorLbl.Name = "sayColorLbl";
            this.sayColorLbl.Size = new System.Drawing.Size(34, 13);
            this.sayColorLbl.TabIndex = 16;
            this.sayColorLbl.Text = "Color:";
            // 
            // curColorLbl
            // 
            this.curColorLbl.AutoSize = true;
            this.curColorLbl.Location = new System.Drawing.Point(616, 95);
            this.curColorLbl.Name = "curColorLbl";
            this.curColorLbl.Size = new System.Drawing.Size(68, 13);
            this.curColorLbl.TabIndex = 17;
            this.curColorLbl.Text = "Current Color";
            this.curColorLbl.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // isFilledLbl
            // 
            this.isFilledLbl.AutoSize = true;
            this.isFilledLbl.Location = new System.Drawing.Point(628, 8);
            this.isFilledLbl.Name = "isFilledLbl";
            this.isFilledLbl.Size = new System.Drawing.Size(68, 13);
            this.isFilledLbl.TabIndex = 18;
            this.isFilledLbl.Text = "Filled Or Nah";
            // 
            // mouseCurPosLbl
            // 
            this.mouseCurPosLbl.AutoSize = true;
            this.mouseCurPosLbl.Location = new System.Drawing.Point(815, 94);
            this.mouseCurPosLbl.Name = "mouseCurPosLbl";
            this.mouseCurPosLbl.Size = new System.Drawing.Size(39, 13);
            this.mouseCurPosLbl.TabIndex = 19;
            this.mouseCurPosLbl.Text = "Mouse";
            // 
            // fillSubColorBtn
            // 
            this.fillSubColorBtn.Image = global::FormAndClass.Properties.Resources.output_onlinepngtools__4_;
            this.fillSubColorBtn.Location = new System.Drawing.Point(899, 13);
            this.fillSubColorBtn.Name = "fillSubColorBtn";
            this.fillSubColorBtn.Size = new System.Drawing.Size(75, 71);
            this.fillSubColorBtn.TabIndex = 20;
            this.fillSubColorBtn.Text = "Fill Sub Color";
            this.fillSubColorBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.fillSubColorBtn.UseVisualStyleBackColor = true;
            this.fillSubColorBtn.Click += new System.EventHandler(this.FillSubColorBtn_Click);
            // 
            // drawHexagonBtn
            // 
            this.drawHexagonBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.drawHexagonBtn.Image = global::FormAndClass.Properties.Resources.hexag64;
            this.drawHexagonBtn.Location = new System.Drawing.Point(457, 13);
            this.drawHexagonBtn.Name = "drawHexagonBtn";
            this.drawHexagonBtn.Size = new System.Drawing.Size(84, 94);
            this.drawHexagonBtn.TabIndex = 13;
            this.drawHexagonBtn.UseVisualStyleBackColor = false;
            this.drawHexagonBtn.Click += new System.EventHandler(this.HxgnBtn_Click);
            // 
            // drawTriangleBtn
            // 
            this.drawTriangleBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.drawTriangleBtn.Image = global::FormAndClass.Properties.Resources.tr64;
            this.drawTriangleBtn.Location = new System.Drawing.Point(362, 12);
            this.drawTriangleBtn.Name = "drawTriangleBtn";
            this.drawTriangleBtn.Size = new System.Drawing.Size(88, 96);
            this.drawTriangleBtn.TabIndex = 11;
            this.drawTriangleBtn.UseVisualStyleBackColor = false;
            this.drawTriangleBtn.Click += new System.EventHandler(this.TrngleBtn_Click);
            // 
            // drawCircleBtn
            // 
            this.drawCircleBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.drawCircleBtn.Image = global::FormAndClass.Properties.Resources.circle;
            this.drawCircleBtn.Location = new System.Drawing.Point(270, 13);
            this.drawCircleBtn.Name = "drawCircleBtn";
            this.drawCircleBtn.Size = new System.Drawing.Size(86, 95);
            this.drawCircleBtn.TabIndex = 9;
            this.drawCircleBtn.UseVisualStyleBackColor = false;
            this.drawCircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fillBtn.Image = global::FormAndClass.Properties.Resources.output_onlinepngtools__3_;
            this.fillBtn.Location = new System.Drawing.Point(628, 24);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 67);
            this.fillBtn.TabIndex = 5;
            this.fillBtn.UseVisualStyleBackColor = false;
            this.fillBtn.Click += new System.EventHandler(this.DoFillBtn_Click);
            // 
            // button4
            // 
            this.button4.Image = global::FormAndClass.Properties.Resources.output_onlinepngtools;
            this.button4.Location = new System.Drawing.Point(719, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 80);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ColDiag_Click);
            // 
            // drawEllipseBtn
            // 
            this.drawEllipseBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.drawEllipseBtn.Image = global::FormAndClass.Properties.Resources.Ellipse;
            this.drawEllipseBtn.Location = new System.Drawing.Point(175, 13);
            this.drawEllipseBtn.Name = "drawEllipseBtn";
            this.drawEllipseBtn.Size = new System.Drawing.Size(89, 94);
            this.drawEllipseBtn.TabIndex = 3;
            this.drawEllipseBtn.UseVisualStyleBackColor = false;
            this.drawEllipseBtn.Click += new System.EventHandler(this.ElliBtn_Click);
            // 
            // drawRectBtn
            // 
            this.drawRectBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.drawRectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawRectBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.drawRectBtn.Image = global::FormAndClass.Properties.Resources.Rect;
            this.drawRectBtn.Location = new System.Drawing.Point(94, 13);
            this.drawRectBtn.Name = "drawRectBtn";
            this.drawRectBtn.Size = new System.Drawing.Size(75, 94);
            this.drawRectBtn.TabIndex = 2;
            this.drawRectBtn.UseVisualStyleBackColor = false;
            this.drawRectBtn.Click += new System.EventHandler(this.RectBtn_Click);
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.drawLineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.drawLineBtn.Image = global::FormAndClass.Properties.Resources.pencil6464;
            this.drawLineBtn.Location = new System.Drawing.Point(13, 13);
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(75, 94);
            this.drawLineBtn.TabIndex = 1;
            this.drawLineBtn.UseVisualStyleBackColor = false;
            this.drawLineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 324);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // PictureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.fillSubColorBtn);
            this.Controls.Add(this.mouseCurPosLbl);
            this.Controls.Add(this.isFilledLbl);
            this.Controls.Add(this.curColorLbl);
            this.Controls.Add(this.sayColorLbl);
            this.Controls.Add(this.penSize2Lbl);
            this.Controls.Add(this.pensizeLbl);
            this.Controls.Add(this.drawHexagonBtn);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.drawTriangleBtn);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.drawCircleBtn);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.drawEllipseBtn);
            this.Controls.Add(this.drawRectBtn);
            this.Controls.Add(this.drawLineBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PictureBoxForm";
            this.Text = "PictureBoxForm";
            this.Load += new System.EventHandler(this.PictureBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button drawLineBtn;
        private System.Windows.Forms.Button drawRectBtn;
        private System.Windows.Forms.Button drawEllipseBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button drawCircleBtn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button drawTriangleBtn;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button drawHexagonBtn;
        private System.Windows.Forms.Label pensizeLbl;
        private System.Windows.Forms.Label penSize2Lbl;
        private System.Windows.Forms.Label sayColorLbl;
        private System.Windows.Forms.Label curColorLbl;
        private System.Windows.Forms.Label isFilledLbl;
        private System.Windows.Forms.Label mouseCurPosLbl;
        private System.Windows.Forms.Button fillSubColorBtn;
    }
}