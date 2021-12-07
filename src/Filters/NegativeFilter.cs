using System.Drawing;

namespace DummyPhotoshop.Filters
{
    public class NegativeFilter:PixelFilter
    {
        protected override Color ProcessPixel(Color pixel)
        {
            return Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
        }
    }
}