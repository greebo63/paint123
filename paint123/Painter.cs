using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    public class Painter
    {
        public enum InstrumentType
        {
            PenDrawer,
            Line,
            RectDrawer,
            Ell,
            Arrow,
            Triangle,
            Text,
            Pipette,
            
        }

        private Image? _img;
        private readonly List<Instrument> _ins = new();
        public InstrumentType InsType
        {
            get;
            set;
        }

        private Size _containerSize;
        public Size ContainerSize
        {
            get => _containerSize;
            set
            {
                _containerSize = value;
                var img = new Bitmap(_containerSize.Width, _containerSize.Height, PixelFormat.Format24bppRgb);
                Graphics.FromImage(img).Clear(Color.White);
                var ig = Graphics.FromImage(img);
                if (_img is not null)
                    ig.DrawImage(this._img, 0, 0);
                _img = img;
            }
        }
        public Painter( Size containerSize)
        {
            ContainerSize = containerSize;
            _ins.Add(new PenDrawer());
            _ins.Add(new Line());
            _ins.Add(new RectDrawer());
            _ins.Add(new Ellipse());
            _ins.Add(new Arrow());
            _ins.Add(new Triangle());
            _ins.Add(new Text());
        }


        public Color GetColor(Point cur)
        {
            return ((Bitmap)_img).GetPixel(cur.X,cur.Y);
        }
        public void Paint(Graphics g)
        {
            if (_img is not null)
            {
                g.DrawImage(_img, 0, 0);
            }
        }

        public void StartDrawing(Point location,int wid, Color main)
        {
            if (_img is not null)
            {
                _ins[(int)InsType].Start(location, (Image)_img, wid, main);
            }
        }

        public void StartDrawing(Point location, int wid, bool _fill, Color main, Color back)
        {
            if (_img is not null)
            {
                _ins[(int)InsType].Start(location, (Image)_img, wid, _fill, main, back);
            }
        }

        public void StopDrawing(Point location)
        {
            if (_img is not null)
            {
                var ig = Graphics.FromImage(_img);
                _ins[(int)InsType].Draw(ig, location);
            }
            _ins[(int)InsType].Stop();
        }

        public void Draw(Point location, Graphics tempG)
        {
            var bg =
                BufferedGraphicsManager.Current.Allocate(
                    tempG,
                    Rectangle.Ceiling(tempG.VisibleClipBounds)
                );
            if (_img is not null)
                bg.Graphics.DrawImage(_img, 0, 0);
            else 
            
                bg.Graphics.Clear(Color.White);
            if (InsType != InstrumentType.Pipette)
            {
                _ins[(int)InsType].Draw(bg.Graphics, location);
                bg.Render(tempG);
            }
            //bg.Dispose();
        }
    }
}
