﻿using System;
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
                Rectangle some = new Rectangle();
                some = true_figure ? GetRectangle((Point)StartPoint, currentPoint,true_figure) : GetRectangle((Point)StartPoint, currentPoint);
                Point[] var = new Point[3];
                var[0] = (Point)StartPoint;
                if (currentPoint.X > ((Point)StartPoint).X)
                {
                    if (((Point)StartPoint).Y > currentPoint.Y)
                    {
                        var[1] = new Point(((Point)StartPoint).X + some.Width / 2, ((Point)StartPoint).Y - some.Height);
                    }
                    else var[1] = new Point(((Point)StartPoint).X + some.Width / 2, ((Point)StartPoint).Y + some.Height);
                }
                else 
                {
                    if (((Point)StartPoint).Y > currentPoint.Y)
                    {
                        var[1] = new Point(((Point)StartPoint).X - some.Width / 2, ((Point)StartPoint).Y - some.Height);
                    }
                    else var[1] = new Point(((Point)StartPoint).X - some.Width / 2, ((Point)StartPoint).Y + some.Height);
                }

                if (currentPoint.X > ((Point)StartPoint).X)
                {
                    var[2] = new Point(some.Width + ((Point)StartPoint).X, ((Point)StartPoint).Y);
                }
                else var[2] = new Point(-some.Width + ((Point)StartPoint).X, ((Point)StartPoint).Y);
                if ((bool)fill)
                {
                    g.FillPolygon(Brush, var);
                }
                g.DrawPolygon(Pen, var);
            }
        }
    }
}
