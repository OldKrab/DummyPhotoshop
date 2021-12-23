using System.Drawing;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class BlackWhiteFilter:PixelFilter
    {
        protected override Color ProcessPixel(int x, int y, IPhoto photo)
        {
            Color pixel = photo.GetPixel(x, y);
            var br = (int)pixel.CalcBrightness();
            return Color.FromArgb(br, br, br);
        }
    }
}