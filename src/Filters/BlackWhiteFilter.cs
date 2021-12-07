using System.Drawing;

namespace DummyPhotoshop.Filters
{
    public class BlackWhiteFilter:PixelFilter
    {
        protected override Color ProcessPixel(Color pixel)
        {
            var br = (int)pixel.CalcBrightness();
            return Color.FromArgb(br, br, br);
        }
    }
}