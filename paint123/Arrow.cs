using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    class Arrow :Instrument
    {
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                
                Pen.CustomEndCap = new AdjustableArrowCap(10, 10);
                g.DrawLine(Pen, (Point)StartPoint, currentPoint);
            }
        }
    }
}
