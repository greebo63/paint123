using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    class PenDrawer : Instrument
    {
        private int _wid;
        public PenDrawer(int wid)
        {
            Pen.Width = wid;
        }
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                Graphics.FromImage(CurrentImage).DrawLine(Pen, (Point)StartPoint, currentPoint);
                g.DrawImage(CurrentImage, 0, 0);
                StartPoint = currentPoint;
            }
        }
    }
}
