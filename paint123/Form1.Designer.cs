
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
            this.ButPencil = new System.Windows.Forms.Button();
            this.ButLine = new System.Windows.Forms.Button();
            this.Rect = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.ButPen = new System.Windows.Forms.Button();
            this.Arrow = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.main_color = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.back_color = new System.Windows.Forms.Button();
            this.panel_with_buttons.SuspendLayout();
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
            this.panel_with_buttons.ColumnCount = 4;
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.panel_with_buttons.Controls.Add(this.ButPencil, 0, 0);
            this.panel_with_buttons.Controls.Add(this.ButLine, 1, 0);
            this.panel_with_buttons.Controls.Add(this.Rect, 1, 1);
            this.panel_with_buttons.Controls.Add(this.Ellipse, 2, 0);
            this.panel_with_buttons.Controls.Add(this.Triangle, 3, 0);
            this.panel_with_buttons.Controls.Add(this.ButPen, 0, 1);
            this.panel_with_buttons.Controls.Add(this.Arrow, 2, 1);
            this.panel_with_buttons.Location = new System.Drawing.Point(12, 12);
            this.panel_with_buttons.Name = "panel_with_buttons";
            this.panel_with_buttons.RowCount = 2;
            this.panel_with_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_with_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_with_buttons.Size = new System.Drawing.Size(161, 69);
            this.panel_with_buttons.TabIndex = 0;
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
            // main_color
            // 
            this.main_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.main_color.Location = new System.Drawing.Point(269, 16);
            this.main_color.Name = "main_color";
            this.main_color.Size = new System.Drawing.Size(31, 29);
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
            this.back_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_color.Location = new System.Drawing.Point(269, 52);
            this.back_color.Name = "back_color";
            this.back_color.Size = new System.Drawing.Size(31, 29);
            this.back_color.TabIndex = 3;
            this.back_color.UseVisualStyleBackColor = false;
            this.back_color.Click += new System.EventHandler(this.back_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 720);
            this.Controls.Add(this.back_color);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.main_color);
            this.Controls.Add(this.panel_with_buttons);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_with_buttons.ResumeLayout(false);
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
    }
}

