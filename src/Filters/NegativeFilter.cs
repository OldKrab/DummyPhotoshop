using System.Drawing;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class NegativeFilter:PixelFilter
    {
        protected override Color ProcessPixel(int x, int y, IPhoto photo)
        {
            Color pixel = photo.GetPixel(x, y);
            return Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
        }
    }
}