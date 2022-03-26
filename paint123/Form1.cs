using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            p = new Painter(panel1.Size);
            //create button for changing width of pen
            
            wid.Location = new Point(1400, 15);
            wid.Size = new Size(50, 50);
            wid.Visible = true;
            wid.Value = 1;
            var_fields[0] = wid;
            wid.Visible = false;
            Controls.Add(wid);

            fill.Location = new Point(1400, 45);
            fill.Size = new Size(20, 20);
            fill.Checked = false;
            fill.Visible = false;
            Controls.Add(fill);

            not_fill.Location = new Point(1430, 45);
            not_fill.Size = new Size(20, 20);
            not_fill.Checked = true;
            not_fill.Visible = false;
            Controls.Add(not_fill);
        }


        public Color main= Color.Black;
        public Color back=Color.White;
        public NumericUpDown[] var_fields = new NumericUpDown[1];
        NumericUpDown wid = new NumericUpDown();
        private Painter p;
        private RadioButton fill = new RadioButton();
        private RadioButton not_fill = new RadioButton();


        private void fill_Click(object sender)
        {
            not_fill.Checked = false;
        }

        private void not_fill_Click(object sender)
        {
            fill.Checked = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            p.Paint(e.Graphics);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            p.ContainerSize = panel1.Size;
            panel1.Refresh();
        }




        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //p.InsType = e.Button == MouseButtons.Left
            //    ? Painter.InstrumentType.PenDrawer
            //    : Painter.InstrumentType.RectFiller;
            if (p.InsType == Painter.InstrumentType.RectDrawer || p.InsType==Painter.InstrumentType.Ell 
                || p.InsType == Painter.InstrumentType.Triangle)
            {
                p.StartDrawing(e.Location, (int)wid.Value, fill.Checked, main,back);
            }
            else
            {
                p.StartDrawing(e.Location, (int)wid.Value,main);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            p.StopDrawing(e.Location);
            panel1.Update();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            p.Draw(e.Location, panel1.CreateGraphics());
        }





        private void ButPencil_Click(object sender, EventArgs e)
        {
            not_fill.Visible = false;
            fill.Visible = false;
            var_fields[0].Visible = false;
            var_fields[0].Value = 1;
            p.InsType = Painter.InstrumentType.PenDrawer;
        }

        private void ButPen_Click(object sender, EventArgs e)
        {
            not_fill.Visible = false;
            fill.Visible = false;
            var_fields[0].Visible = true;
            p.InsType = Painter.InstrumentType.PenDrawer;
            
        }

        private void ButLine_Click(object sender, EventArgs e)
        {
            not_fill.Visible = false;
            fill.Visible = false;
            var_fields[0].Visible = true;
            p.InsType = Painter.InstrumentType.Line;
        }

        

        private void Arrow_Click(object sender, EventArgs e)
        {
            not_fill.Visible = false;
            fill.Visible = false;
            var_fields[0].Visible = true;
            p.InsType = Painter.InstrumentType.Arrow;
        }


        //фигуры с заполнением
        private void Rect_Click(object sender, EventArgs e)
        {
            not_fill.Visible = true;
            fill.Visible = true;
            var_fields[0].Visible = true;
            p.InsType = Painter.InstrumentType.RectDrawer;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            not_fill.Visible = true;
            fill.Visible = true;
            var_fields[0].Visible = true;
            p.InsType = Painter.InstrumentType.Ell;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            not_fill.Visible = true;
            fill.Visible = true;
            var_fields[0].Visible = true;
            p.InsType = Painter.InstrumentType.Triangle;
        }

        private void main_color_Click(object sender, EventArgs e)
        {
            ColorDialog nn = new ColorDialog();
            nn.AllowFullOpen = true;
            nn.ShowHelp = true;

            if (nn.ShowDialog() == DialogResult.OK) 
            {
                main_color.BackColor = nn.Color;
                main = nn.Color;
            };
        }

        private void back_color_Click(object sender, EventArgs e)
        {
            ColorDialog nn = new ColorDialog();
            nn.AllowFullOpen = true;
            nn.ShowHelp = true;

            if (nn.ShowDialog() == DialogResult.OK)
            {
                back_color.BackColor = nn.Color;
                back = nn.Color;
            };
        }
    }
}
