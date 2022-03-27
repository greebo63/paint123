using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint123
{
    class Text : Instrument
    {
        public override void Draw(Graphics g, Point currentPoint)
        {
            Font style = new Font("Arial", Pen.Width);
            g.DrawString(data, style, Brush, currentPoint);


        }
    }
}
