using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            textBox1.Visible = true;
            textBox1.Enabled = false;

            //create buttons for changing width of pen

            //wid.Location = new Point(1400, 15);
            // wid.Size = new Size(50, 50);
            wid.Visible = true;
            wid.Value = 1;
            var_fields[0] = wid;
            wid.Visible = true;
            //wid.Anchor = AnchorStyles.Top;
            //wid.Anchor = AnchorStyles.Left;
            //Controls.Add(wid);


            //fill.Location = new Point(1400, 45);
            //fill.Size = new Size(20, 20);
            fill.Checked = false;
            fill.Enabled = false;
            //Controls.Add(fill);

            // not_fill.Location = new Point(1430, 45);
            //not_fill.Size = new Size(20, 20);
            not_fill.Checked = true;
            not_fill.Enabled = false;
            //Controls.Add(not_fill);

            //panel1.Focused = true;
        }

        public bool true_figure=false;
        public bool reverse = false;
        public Color main = Color.Black;
        public Color back = Color.White;
        public NumericUpDown[] var_fields = new NumericUpDown[1];
        //NumericUpDown wid = new NumericUpDown();
        private Painter p;
        //private RadioButton fill = new RadioButton();
        //private RadioButton not_fill = new RadioButton();
        public Color but_color_main
        {
            set
            {
                main_color.BackColor = value;
                main = value;
            }
        }

        public Color but_color_back
        {
            set
            {
                back_color.BackColor = value;
                back = value;
            }
        }


        //private void fill_Click(object sender)
        //{
        //    not_fill.Checked = false;
        //}

        //private void not_fill_Click(object sender)
        //{
        //    fill.Checked = false;
        //}

        //actions with panel
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
            if (true_figure)
            {
                Brush some = new SolidBrush(Color.Black);
                Graphics.FromImage(p._img).FillRectangle(some, 200, 200, 500, 500);
            }
            if (p.InsType == Painter.InstrumentType.Text)
            {

                p.StartDrawing(e.Location, (int)wid.Value, main, textBox1.Text);
            }
            else
            {
                textBox1.Enabled = false;
                if (p.InsType == Painter.InstrumentType.Pipette)
                {
                    if (e.Button == MouseButtons.Left) { main = p.GetColor(e.Location); main_color.BackColor = main; }
                    else
                    {
                        back = p.GetColor(e.Location);
                        back_color.BackColor = back;
                    }
                }
                else
                {
                    if (p.InsType == Painter.InstrumentType.RectDrawer || p.InsType == Painter.InstrumentType.Ell
                        || p.InsType == Painter.InstrumentType.Triangle)
                    {
                        p.StartDrawing(e.Location, (int)wid.Value, fill.Checked, main, back,true_figure);
                    }
                    else
                    {
                        p.StartDrawing(e.Location, (int)wid.Value, reverse ? back : main);
                    }
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (p.InsType != Painter.InstrumentType.Pipette)
            {
                p.StopDrawing(e.Location);
                panel1.Update();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            p.Draw(e.Location, panel1.CreateGraphics());
        }



        //instruments

        private void ButPencil_Click(object sender, EventArgs e)
        {
            reverse = false;
            not_fill.Enabled = false;
            fill.Enabled = false;
            var_fields[0].Enabled = false;
            var_fields[0].Value = 1;
            p.InsType = Painter.InstrumentType.PenDrawer;
        }

        private void ButPen_Click(object sender, EventArgs e)
        {
            reverse = false;
            not_fill.Enabled = false;
            fill.Enabled = false;
            var_fields[0].Enabled = true;
            p.InsType = Painter.InstrumentType.PenDrawer;

        }

        private void ButLine_Click(object sender, EventArgs e)
        {
            reverse = false;
            reverse = false;
            not_fill.Enabled = false;
            fill.Enabled = false;
            var_fields[0].Enabled = true;
            p.InsType = Painter.InstrumentType.Line;
        }



        private void Arrow_Click(object sender, EventArgs e)
        {
            reverse = false;
            not_fill.Enabled = false;
            fill.Enabled = false;
            var_fields[0].Enabled = true;
            p.InsType = Painter.InstrumentType.Arrow;
        }


        //фигуры с заполнением
        private void Rect_Click(object sender, EventArgs e)
        {
            not_fill.Enabled = true;
            fill.Enabled = true;
            var_fields[0].Enabled = true;
            p.InsType = Painter.InstrumentType.RectDrawer;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            not_fill.Enabled = true;
            fill.Enabled = true;
            var_fields[0].Enabled = true;
            p.InsType = Painter.InstrumentType.Ell;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            not_fill.Enabled = true;
            fill.Enabled = true;
            var_fields[0].Enabled = true;
            p.InsType = Painter.InstrumentType.Triangle;
        }

        //other instruments

        private void Pipette_Click(object sender, EventArgs e)
        {
            reverse = false;
            not_fill.Enabled = false;
            fill.Enabled = false;
            var_fields[0].Enabled = false;
            p.InsType = Painter.InstrumentType.Pipette;

        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            not_fill.Enabled = false;
            fill.Enabled = false;
            var_fields[0].Enabled = true;
            reverse = true;
            p.InsType = Painter.InstrumentType.PenDrawer;
        }

        private void but_text_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            var_fields[0].Enabled = true;
            reverse = false;
            //textBox1.Visible = true;
            p.InsType = Painter.InstrumentType.Text;
        }

        //buttons with palette

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





        //buttons change color

        private void yel_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = yel_but.BackColor;
            }
            else
            if (e.Button == MouseButtons.Right)
            {
                but_color_back = yel_but.BackColor;
            }
        }

        private void green_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = green_but.BackColor;
            }

            if (e.Button == MouseButtons.Right)
            {
                but_color_back = green_but.BackColor;
            }
        }

        private void aqua_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = aqua_but.BackColor;
            }
            else

            {
                but_color_back = aqua_but.BackColor;
            }
        }

        private void blue_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = blue_but.BackColor;
            }
            else

            {
                but_color_back = blue_but.BackColor;
            }
        }

        private void fuchsia_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = fuchsia_but.BackColor;
            }
            else

            {
                but_color_back = fuchsia_but.BackColor;
            }
        }

        private void purple_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = purple_but.BackColor;
            }
            else

            {
                but_color_back = purple_but.BackColor;
            }
        }

        private void red_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = red_but.BackColor;
            }
            else

            {
                but_color_back = red_but.BackColor;
            }
        }

        private void skin_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = skin_but.BackColor;
            }
            else

            {
                but_color_back = skin_but.BackColor;
            }
        }

        private void maroon_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = maroon_but.BackColor;
            }
            else

            {
                but_color_back = maroon_but.BackColor;
            }
        }

        private void olive_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = olive_but.BackColor;
            }
            else

            {
                but_color_back = olive_but.BackColor;
            }
        }

        private void teal_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = teal_but.BackColor;
            }
            else

            {
                but_color_back = teal_but.BackColor;
            }
        }

        private void gray_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = gray_but.BackColor;
            }
            else

            {
                but_color_back = gray_but.BackColor;
            }
        }

        private void ocean_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = ocean_but.BackColor;
            }
            else

            {
                but_color_back = ocean_but.BackColor;
            }
        }

        private void pale_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = pale_but.BackColor;
            }
            else

            {
                but_color_back = pale_but.BackColor;
            }
        }

        private void greenyellow_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = greenyellow_but.BackColor;
            }
            else

            {
                but_color_back = greenyellow_but.BackColor;
            }
        }

        private void aquamarine_but_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                but_color_main = aquamarine_but.BackColor;
            }
            else

            {
                but_color_back = aquamarine_but.BackColor;
            }
        } 

        private void save_file_Click(object sender, EventArgs e)
        {
            Stream myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    
                    //myStream.Close();

                    if (saveFileDialog1.FileName != "")
                    {
                        // Saves the Image via a FileStream created by the OpenFile method.
                        System.IO.FileStream fs =
                            (System.IO.FileStream)saveFileDialog1.OpenFile();
                        // Saves the Image in the appropriate ImageFormat based upon the
                        // File type selected in the dialog box.
                        // NOTE that the FilterIndex property is one-based.

                        //p._img.Save("img.png", System.Drawing.Imaging.ImageFormat.Jpeg);
                        p._img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        fs.Close();
                    }
                    }
            }
        }


        //actions with shift

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                true_figure = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (true_figure) true_figure = false;
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Shift)
            {
                true_figure = true;
            }
        }
    }
}
