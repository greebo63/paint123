using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    class Text : Instrument
    {
        public override void Draw(Graphics g, Point currentPoint)
        {
            Font myFont = new Font(FontFamily.GenericSansSerif, 20,
        FontStyle.Regular);
            Graphics.FromImage(CurrentImage).TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            // Draw the string.
            Graphics.FromImage(CurrentImage).DrawString("Hello World", myFont,
                Brushes.Firebrick, 20.0F, 20.0F);
        }
    }
}
