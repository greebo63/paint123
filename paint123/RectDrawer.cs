using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    class RectDrawer : Instrument
    {
        //private bool fill;

        //public RectDrawer(bool fill = false)
        //{
        //    this.fill = fill;
        //}

        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                //g.DrawImage(CurrentImage, 0, 0);
                if ((bool)fill)
                {
                    g.FillRectangle(Brush, GetRectangle((Point)StartPoint, currentPoint));
                   if (true_figure)
                    {
                        g.FillRectangle(Brush, GetRectangle((Point)StartPoint, currentPoint,true_figure));
                        //g.FillRectangle(Brush, ((Point)StartPoint).X, ((Point)StartPoint).Y, ((Point)StartPoint).X-currentPoint.X, ((Point)StartPoint).X - currentPoint.X);
                        // g.FillRectangle(Brush, GetRectangle(((Point)StartPoint).X, ((Point)StartPoint).Y, currentPoint.X,currentPoint.Y));
                    }
                    else g.FillRectangle(Brush, GetRectangle((Point)StartPoint, currentPoint));
                }
                if (true_figure)
                {
                    g.DrawRectangle(Pen, GetRectangle((Point)StartPoint, currentPoint,true_figure));
                }
                else
                    g.DrawRectangle(Pen, GetRectangle((Point)StartPoint, currentPoint));
            }
        }
    }
}
