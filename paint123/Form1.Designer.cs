
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
            this.ButPen = new System.Windows.Forms.Button();
            this.ButLine = new System.Windows.Forms.Button();
            this.Rect = new System.Windows.Forms.Button();
            this.panel_with_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 624);
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
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.38358F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.61642F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.panel_with_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 611F));
            this.panel_with_buttons.Controls.Add(this.ButPencil, 0, 0);
            this.panel_with_buttons.Controls.Add(this.ButPen, 0, 1);
            this.panel_with_buttons.Controls.Add(this.ButLine, 1, 0);
            this.panel_with_buttons.Controls.Add(this.Rect, 1, 1);
            this.panel_with_buttons.Location = new System.Drawing.Point(12, 12);
            this.panel_with_buttons.Name = "panel_with_buttons";
            this.panel_with_buttons.RowCount = 2;
            this.panel_with_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_with_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_with_buttons.Size = new System.Drawing.Size(1373, 66);
            this.panel_with_buttons.TabIndex = 0;
            // 
            // ButPencil
            // 
            this.ButPencil.Location = new System.Drawing.Point(3, 3);
            this.ButPencil.Name = "ButPencil";
            this.ButPencil.Size = new System.Drawing.Size(30, 27);
            this.ButPencil.TabIndex = 0;
            this.ButPencil.Text = "pencil";
            this.ButPencil.UseVisualStyleBackColor = true;
            this.ButPencil.Click += new System.EventHandler(this.ButPencil_Click);
            // 
            // ButPen
            // 
            this.ButPen.Location = new System.Drawing.Point(3, 36);
            this.ButPen.Name = "ButPen";
            this.ButPen.Size = new System.Drawing.Size(30, 27);
            this.ButPen.TabIndex = 1;
            this.ButPen.Text = "2";
            this.ButPen.UseVisualStyleBackColor = true;
            this.ButPen.Click += new System.EventHandler(this.ButPen_Click);
            // 
            // ButLine
            // 
            this.ButLine.Location = new System.Drawing.Point(39, 3);
            this.ButLine.Name = "ButLine";
            this.ButLine.Size = new System.Drawing.Size(29, 27);
            this.ButLine.TabIndex = 2;
            this.ButLine.Text = "3";
            this.ButLine.UseVisualStyleBackColor = true;
            this.ButLine.Click += new System.EventHandler(this.ButLine_Click);
            // 
            // Rect
            // 
            this.Rect.Location = new System.Drawing.Point(39, 36);
            this.Rect.Name = "Rect";
            this.Rect.Size = new System.Drawing.Size(29, 27);
            this.Rect.TabIndex = 3;
            this.Rect.Text = "r";
            this.Rect.UseVisualStyleBackColor = true;
            this.Rect.Click += new System.EventHandler(this.Rect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 720);
            this.Controls.Add(this.panel_with_buttons);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_with_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panel_with_buttons;
        private System.Windows.Forms.Button ButPencil;
        private System.Windows.Forms.Button ButPen;
        private System.Windows.Forms.Button ButLine;
        private System.Windows.Forms.Button Rect;
    }
}

