
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
            this.yel_but = new System.Windows.Forms.Button();
            this.green_but = new System.Windows.Forms.Button();
            this.aqua_but = new System.Windows.Forms.Button();
            this.fuchsia_but = new System.Windows.Forms.Button();
            this.purple_but = new System.Windows.Forms.Button();
            this.red_but = new System.Windows.Forms.Button();
            this.skin_but = new System.Windows.Forms.Button();
            this.maroon_but = new System.Windows.Forms.Button();
            this.olive_but = new System.Windows.Forms.Button();
            this.teal_but = new System.Windows.Forms.Button();
            this.gray_but = new System.Windows.Forms.Button();
            this.ocean_but = new System.Windows.Forms.Button();
            this.pale_but = new System.Windows.Forms.Button();
            this.aquamarine_but = new System.Windows.Forms.Button();
            this.blue_but = new System.Windows.Forms.Button();
            this.greenyellow_but = new System.Windows.Forms.Button();
            this.wid = new System.Windows.Forms.NumericUpDown();
            this.panel_with_buttons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wid)).BeginInit();
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
            this.main_color.Location = new System.Drawing.Point(280, 16);
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
            this.back_color.Location = new System.Drawing.Point(280, 50);
            this.back_color.Name = "back_color";
            this.back_color.Size = new System.Drawing.Size(31, 27);
            this.back_color.TabIndex = 3;
            this.back_color.UseVisualStyleBackColor = false;
            this.back_color.Click += new System.EventHandler(this.back_color_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 66);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Controls.Add(this.yel_but, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.green_but, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.aqua_but, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fuchsia_but, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.purple_but, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.red_but, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.skin_but, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.maroon_but, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.olive_but, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.teal_but, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.gray_but, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.ocean_but, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.pale_but, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.aquamarine_but, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.blue_but, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.greenyellow_but, 8, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(340, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 66);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // yel_but
            // 
            this.yel_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yel_but.Location = new System.Drawing.Point(3, 3);
            this.yel_but.Name = "yel_but";
            this.yel_but.Size = new System.Drawing.Size(31, 27);
            this.yel_but.TabIndex = 4;
            this.yel_but.UseVisualStyleBackColor = false;
            this.yel_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yel_but_MouseDown);
            // 
            // green_but
            // 
            this.green_but.BackColor = System.Drawing.Color.Lime;
            this.green_but.ForeColor = System.Drawing.SystemColors.ControlText;
            this.green_but.Location = new System.Drawing.Point(3, 36);
            this.green_but.Name = "green_but";
            this.green_but.Size = new System.Drawing.Size(31, 27);
            this.green_but.TabIndex = 5;
            this.green_but.UseVisualStyleBackColor = false;
            this.green_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.green_but_MouseDown);
            // 
            // aqua_but
            // 
            this.aqua_but.BackColor = System.Drawing.Color.Aqua;
            this.aqua_but.Location = new System.Drawing.Point(40, 3);
            this.aqua_but.Name = "aqua_but";
            this.aqua_but.Size = new System.Drawing.Size(31, 27);
            this.aqua_but.TabIndex = 6;
            this.aqua_but.UseVisualStyleBackColor = false;
            this.aqua_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aqua_but_MouseDown);
            // 
            // fuchsia_but
            // 
            this.fuchsia_but.BackColor = System.Drawing.Color.Fuchsia;
            this.fuchsia_but.Location = new System.Drawing.Point(77, 3);
            this.fuchsia_but.Name = "fuchsia_but";
            this.fuchsia_but.Size = new System.Drawing.Size(31, 27);
            this.fuchsia_but.TabIndex = 8;
            this.fuchsia_but.UseVisualStyleBackColor = false;
            this.fuchsia_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fuchsia_but_MouseDown);
            // 
            // purple_but
            // 
            this.purple_but.BackColor = System.Drawing.Color.Purple;
            this.purple_but.Location = new System.Drawing.Point(77, 36);
            this.purple_but.Name = "purple_but";
            this.purple_but.Size = new System.Drawing.Size(31, 27);
            this.purple_but.TabIndex = 9;
            this.purple_but.UseVisualStyleBackColor = false;
            this.purple_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.purple_but_MouseDown);
            // 
            // red_but
            // 
            this.red_but.BackColor = System.Drawing.Color.Red;
            this.red_but.Location = new System.Drawing.Point(114, 3);
            this.red_but.Name = "red_but";
            this.red_but.Size = new System.Drawing.Size(31, 27);
            this.red_but.TabIndex = 10;
            this.red_but.UseVisualStyleBackColor = false;
            this.red_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_but_MouseDown);
            // 
            // skin_but
            // 
            this.skin_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skin_but.Location = new System.Drawing.Point(114, 36);
            this.skin_but.Name = "skin_but";
            this.skin_but.Size = new System.Drawing.Size(31, 27);
            this.skin_but.TabIndex = 11;
            this.skin_but.UseVisualStyleBackColor = false;
            this.skin_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skin_but_MouseDown);
            // 
            // maroon_but
            // 
            this.maroon_but.BackColor = System.Drawing.Color.Maroon;
            this.maroon_but.Location = new System.Drawing.Point(151, 3);
            this.maroon_but.Name = "maroon_but";
            this.maroon_but.Size = new System.Drawing.Size(31, 27);
            this.maroon_but.TabIndex = 12;
            this.maroon_but.UseVisualStyleBackColor = false;
            this.maroon_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maroon_but_MouseDown);
            // 
            // olive_but
            // 
            this.olive_but.BackColor = System.Drawing.Color.Olive;
            this.olive_but.Location = new System.Drawing.Point(151, 36);
            this.olive_but.Name = "olive_but";
            this.olive_but.Size = new System.Drawing.Size(31, 27);
            this.olive_but.TabIndex = 13;
            this.olive_but.UseVisualStyleBackColor = false;
            this.olive_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.olive_but_MouseDown);
            // 
            // teal_but
            // 
            this.teal_but.BackColor = System.Drawing.Color.Teal;
            this.teal_but.Location = new System.Drawing.Point(188, 3);
            this.teal_but.Name = "teal_but";
            this.teal_but.Size = new System.Drawing.Size(31, 27);
            this.teal_but.TabIndex = 14;
            this.teal_but.UseVisualStyleBackColor = false;
            this.teal_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.teal_but_MouseDown);
            // 
            // gray_but
            // 
            this.gray_but.BackColor = System.Drawing.Color.Gray;
            this.gray_but.Location = new System.Drawing.Point(188, 36);
            this.gray_but.Name = "gray_but";
            this.gray_but.Size = new System.Drawing.Size(31, 27);
            this.gray_but.TabIndex = 15;
            this.gray_but.UseVisualStyleBackColor = false;
            this.gray_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gray_but_MouseDown);
            // 
            // ocean_but
            // 
            this.ocean_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(107)))), ((int)(((byte)(183)))));
            this.ocean_but.Location = new System.Drawing.Point(226, 3);
            this.ocean_but.Name = "ocean_but";
            this.ocean_but.Size = new System.Drawing.Size(31, 27);
            this.ocean_but.TabIndex = 16;
            this.ocean_but.UseVisualStyleBackColor = false;
            this.ocean_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ocean_but_MouseDown);
            // 
            // pale_but
            // 
            this.pale_but.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pale_but.Location = new System.Drawing.Point(226, 36);
            this.pale_but.Name = "pale_but";
            this.pale_but.Size = new System.Drawing.Size(31, 27);
            this.pale_but.TabIndex = 17;
            this.pale_but.UseVisualStyleBackColor = false;
            this.pale_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pale_but_MouseDown);
            // 
            // aquamarine_but
            // 
            this.aquamarine_but.BackColor = System.Drawing.Color.Aquamarine;
            this.aquamarine_but.Location = new System.Drawing.Point(265, 36);
            this.aquamarine_but.Name = "aquamarine_but";
            this.aquamarine_but.Size = new System.Drawing.Size(31, 27);
            this.aquamarine_but.TabIndex = 19;
            this.aquamarine_but.UseVisualStyleBackColor = false;
            this.aquamarine_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aquamarine_but_MouseDown);
            // 
            // blue_but
            // 
            this.blue_but.BackColor = System.Drawing.Color.Blue;
            this.blue_but.Location = new System.Drawing.Point(40, 36);
            this.blue_but.Name = "blue_but";
            this.blue_but.Size = new System.Drawing.Size(31, 27);
            this.blue_but.TabIndex = 7;
            this.blue_but.UseVisualStyleBackColor = false;
            this.blue_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blue_but_MouseDown);
            // 
            // greenyellow_but
            // 
            this.greenyellow_but.BackColor = System.Drawing.Color.GreenYellow;
            this.greenyellow_but.Location = new System.Drawing.Point(265, 3);
            this.greenyellow_but.Name = "greenyellow_but";
            this.greenyellow_but.Size = new System.Drawing.Size(31, 27);
            this.greenyellow_but.TabIndex = 18;
            this.greenyellow_but.UseVisualStyleBackColor = false;
            this.greenyellow_but.MouseDown += new System.Windows.Forms.MouseEventHandler(this.greenyellow_but_MouseDown);
            // 
            // wid
            // 
            this.wid.Location = new System.Drawing.Point(1081, 15);
            this.wid.Name = "wid";
            this.wid.Size = new System.Drawing.Size(150, 27);
            this.wid.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 720);
            this.Controls.Add(this.wid);
            this.Controls.Add(this.back_color);
            this.Controls.Add(this.main_color);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_with_buttons);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_with_buttons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wid)).EndInit();
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
        private System.Windows.Forms.Button yel_but;
        private System.Windows.Forms.Button green_but;
        private System.Windows.Forms.Button aqua_but;
        private System.Windows.Forms.Button fuchsia_but;
        private System.Windows.Forms.Button purple_but;
        private System.Windows.Forms.Button red_but;
        private System.Windows.Forms.Button skin_but;
        private System.Windows.Forms.Button maroon_but;
        private System.Windows.Forms.Button olive_but;
        private System.Windows.Forms.Button teal_but;
        private System.Windows.Forms.Button gray_but;
        private System.Windows.Forms.Button ocean_but;
        private System.Windows.Forms.Button pale_but;
        private System.Windows.Forms.Button greenyellow_but;
        private System.Windows.Forms.Button aquamarine_but;
        private System.Windows.Forms.Button blue_but;
        private System.Windows.Forms.NumericUpDown wid;
    }
}

