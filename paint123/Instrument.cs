using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    public abstract class Instrument
    {
        private Pen _pen=new Pen(Color.Black, 1);
        private Brush _brush= new SolidBrush(Color.Black);
        public bool? fill;
        public string data;
        protected Point? StartPoint { get; set; }
        public Pen Pen
        {
            get => _pen;
            set => _pen = value;
        }

        public Brush Brush
        {
            get => _brush;
            set => _brush = value;
        }

        protected Image? CurrentImage;

        public void Start(Point location, Image currentImage,int wid, Color main)
        {
            Pen.Width = wid;
            CurrentImage = currentImage;
            StartPoint = location;
            _pen.Color = main;
        }

        public void Start(Point location, Image currentImage, int wid, Color main, string text)
        {
            Pen.Width = wid;
            CurrentImage = currentImage;
            StartPoint = location;
            _pen.Color = main;
            data = text;
        }

        public void Start(Point location, Image currentImage, int wid, bool _fill, Color main, Color back)
        {
            fill = _fill;
            Pen.Width = wid;
            _pen.Color = main;
            _brush = new SolidBrush(back);
            CurrentImage = currentImage;
            StartPoint = location;
        }

        public void Stop()
        {
            StartPoint = null;
        }
        public abstract void Draw(Graphics g, Point currentPoint);

        protected Rectangle GetRectangle(Point p1, Point p2)
        {
            var xMin = Math.Min(p1.X, p2.X);
            var xMax = Math.Max(p1.X, p2.X);
            var yMin = Math.Min(p1.Y, p2.Y);
            var yMax = Math.Max(p1.Y, p2.Y);
            return new Rectangle(xMin, yMin, xMax - xMin, yMax - yMin);
        }
    }
}
