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
            Controls.Add(wid);

            fill.Location = new Point(1400, 30);
            fill.Size = new Size(50, 50);
            fill.Checked = false;
            Controls.Add(fill);
        }



        public NumericUpDown[] var_fields = new NumericUpDown[1];
        NumericUpDown wid = new NumericUpDown();
        private Painter p;
        private RadioButton fill = new RadioButton();



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
            if (p.InsType == Painter.InstrumentType.RectDrawer)
            {
                p.StartDrawing(e.Location, (int)wid.Value, fill.Checked);
            }
            else
            {
                p.StartDrawing(e.Location, (int)wid.Value);
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
            
            p.InsType = Painter.InstrumentType.PenDrawer;
        }

        private void ButPen_Click(object sender, EventArgs e)
        {
            
            p.InsType = Painter.InstrumentType.PenDrawer;
            
        }

        private void ButLine_Click(object sender, EventArgs e)
        {
            
            p.InsType = Painter.InstrumentType.Line;
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            //Controls.Remove(var_fields[0]);
            p.InsType = Painter.InstrumentType.RectFiller;
        }
    }
}
