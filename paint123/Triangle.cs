using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    class Triangle : Instrument
    {
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                //g.DrawImage(CurrentImage, 0, 0);
                Point[] var = new Point[3];
                var[0] = (Point)StartPoint;
                var[1] = new Point(currentPoint.X - (currentPoint.X - ((Point)StartPoint).X) / 2, currentPoint.Y);
                var[2] = new Point( currentPoint.X,((Point)StartPoint).Y);
                //var[2] = new Point(0, 0);
                if ((bool)fill)
                {
                    g.FillPolygon(Brush, var);
                }
                g.DrawPolygon(Pen, var);
            }
        }
    }
}
