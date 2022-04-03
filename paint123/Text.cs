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
            Brush some = new SolidBrush(Pen.Color);
            Font style = new Font("Arial", Pen.Width);
            RectangleF some1 = new Rectangle();
            some1 = g.ClipBounds;
            g.DrawString(data, style, some, some1.Width, some1.Height);
            g.DrawString(data, style, some, currentPoint);


        }
    }
}
