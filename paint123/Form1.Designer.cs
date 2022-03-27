
namespace paint123
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_with_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Pipette = new System.Windows.Forms.Button();
            this.ButPencil = new System.Windows.Forms.Button();
            this.ButLine = new System.Windows.Forms.Button();
            this.Rect = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.ButPen = new System.Windows.Forms.Button();
            this.Arrow = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.but_text = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.main_color = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.back_color = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.panel_with_buttons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 604);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panel_with_buttons
            // 
            this.panel_with_buttons.ColumnCount = 5;
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.panel_with_buttons.Controls.Add(this.Pipette, 3, 1);
            this.panel_with_buttons.Controls.Add(this.ButPencil, 0, 0);
            this.panel_with_buttons.Controls.Add(this.ButLine, 1, 0);
            this.panel_with_buttons.Controls.Add(this.Rect, 1, 1);
            this.panel_with_buttons.Controls.Add(this.Ellipse, 2, 0);
            this.panel_with_buttons.Controls.Add(this.Triangle, 3, 0);
            this.panel_with_buttons.Controls.Add(this.ButPen, 0, 1);
            this.panel_with_buttons.Controls.Add(this.Arrow, 2, 1);
            this.panel_with_buttons.Controls.Add(this.Eraser, 4, 0);
            this.panel_with_buttons.Controls.Add(this.but_text, 4, 1);
            this.panel_with_buttons.Location = new System.Drawing.Point(12, 12);
            this.panel_with_buttons.Name = "panel_with_buttons";
            this.panel_with_buttons.RowCount = 2;
            this.panel_with_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_with_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_with_buttons.Size = new System.Drawing.Size(204, 69);
            this.panel_with_buttons.TabIndex = 0;
            // 
            // Pipette
            // 
            this.Pipette.Location = new System.Drawing.Point(123, 38);
            this.Pipette.Name = "Pipette";
            this.Pipette.Size = new System.Drawing.Size(30, 29);
            this.Pipette.TabIndex = 4;
            this.Pipette.Text = "p";
            this.Pipette.UseVisualStyleBackColor = true;
            this.Pipette.Click += new System.EventHandler(this.Pipette_Click);
            // 
            // ButPencil
            // 
            this.ButPencil.Location = new System.Drawing.Point(3, 3);
            this.ButPencil.Name = "ButPencil";
            this.ButPencil.Size = new System.Drawing.Size(30, 29);
            this.ButPencil.TabIndex = 0;
            this.ButPencil.Text = "pencil";
            this.ButPencil.UseVisualStyleBackColor = true;
            this.ButPencil.Click += new System.EventHandler(this.ButPencil_Click);
            // 
            // ButLine
            // 
            this.ButLine.Location = new System.Drawing.Point(43, 3);
            this.ButLine.Name = "ButLine";
            this.ButLine.Size = new System.Drawing.Size(30, 29);
            this.ButLine.TabIndex = 2;
            this.ButLine.Text = "3";
            this.ButLine.UseVisualStyleBackColor = true;
            this.ButLine.Click += new System.EventHandler(this.ButLine_Click);
            // 
            // Rect
            // 
            this.Rect.Location = new System.Drawing.Point(43, 38);
            this.Rect.Name = "Rect";
            this.Rect.Size = new System.Drawing.Size(30, 29);
            this.Rect.TabIndex = 3;
            this.Rect.Text = "r";
            this.Rect.UseVisualStyleBackColor = true;
            this.Rect.Click += new System.EventHandler(this.Rect_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(83, 3);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(30, 29);
            this.Ellipse.TabIndex = 4;
            this.Ellipse.Text = "e";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(123, 3);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(30, 29);
            this.Triangle.TabIndex = 6;
            this.Triangle.Text = "t";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // ButPen
            // 
            this.ButPen.Location = new System.Drawing.Point(3, 38);
            this.ButPen.Name = "ButPen";
            this.ButPen.Size = new System.Drawing.Size(30, 29);
            this.ButPen.TabIndex = 1;
            this.ButPen.Text = "2";
            this.ButPen.UseVisualStyleBackColor = true;
            this.ButPen.Click += new System.EventHandler(this.ButPen_Click);
            // 
            // Arrow
            // 
            this.Arrow.Location = new System.Drawing.Point(83, 38);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(30, 29);
            this.Arrow.TabIndex = 5;
            this.Arrow.Text = "a";
            this.Arrow.UseVisualStyleBackColor = true;
            this.Arrow.Click += new System.EventHandler(this.Arrow_Click);
            // 
            // Eraser
            // 
            this.Eraser.Location = new System.Drawing.Point(163, 3);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(30, 29);
            this.Eraser.TabIndex = 7;
            this.Eraser.Text = "e";
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // but_text
            // 
            this.but_text.Location = new System.Drawing.Point(163, 38);
            this.but_text.Name = "but_text";
            this.but_text.Size = new System.Drawing.Size(30, 29);
            this.but_text.TabIndex = 8;
            this.but_text.Text = "t";
            this.but_text.UseVisualStyleBackColor = true;
            this.but_text.Click += new System.EventHandler(this.but_text_Click);
            // 
            // main_color
            // 
            this.main_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_color.Location = new System.Drawing.Point(3, 3);
            this.main_color.Name = "main_color";
            this.main_color.Size = new System.Drawing.Size(31, 27);
            this.main_color.TabIndex = 1;
            this.main_color.UseVisualStyleBackColor = false;
            this.main_color.Click += new System.EventHandler(this.main_color_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1460, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // back_color
            // 
            this.back_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_color.Location = new System.Drawing.Point(3, 36);
            this.back_color.Name = "back_color";
            this.back_color.Size = new System.Drawing.Size(31, 27);
            this.back_color.TabIndex = 3;
            this.back_color.UseVisualStyleBackColor = false;
            this.back_color.Click += new System.EventHandler(this.back_color_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(893, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 66);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Controls.Add(this.main_color, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.back_color, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.button12, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.button13, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.button14, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.button15, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.button16, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(340, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 66);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(40, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 27);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(40, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 27);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(77, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 27);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(77, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 27);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Fuchsia;
            this.button5.Location = new System.Drawing.Point(114, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 27);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(114, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 27);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(151, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 27);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(151, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 27);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Maroon;
            this.button9.Location = new System.Drawing.Point(188, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 27);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Olive;
            this.button10.Location = new System.Drawing.Point(188, 36);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(31, 27);
            this.button10.TabIndex = 13;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Teal;
            this.button11.Location = new System.Drawing.Point(225, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 27);
            this.button11.TabIndex = 14;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gray;
            this.button12.Location = new System.Drawing.Point(225, 36);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 27);
            this.button12.TabIndex = 15;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(107)))), ((int)(((byte)(183)))));
            this.button13.Location = new System.Drawing.Point(263, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(31, 27);
            this.button13.TabIndex = 16;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button14.Location = new System.Drawing.Point(263, 36);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(31, 27);
            this.button14.TabIndex = 17;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.GreenYellow;
            this.button15.Location = new System.Drawing.Point(302, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(31, 27);
            this.button15.TabIndex = 18;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Aquamarine;
            this.button16.Location = new System.Drawing.Point(302, 36);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(31, 27);
            this.button16.TabIndex = 19;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_with_buttons);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_with_buttons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panel_with_buttons;
        private System.Windows.Forms.Button ButPencil;
        private System.Windows.Forms.Button ButPen;
        private System.Windows.Forms.Button ButLine;
        private System.Windows.Forms.Button Rect;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Arrow;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button main_color;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button back_color;
        private System.Windows.Forms.Button Pipette;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.Button but_text;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button4;
    }
}

