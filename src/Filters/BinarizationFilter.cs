using System.Drawing;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class BinarizationFilter : PixelFilter
    {
        public int Threshold { get; set; }
        public Color LeftColor { get; set; } = Color.Black;
        public Color RightColor { get; set; } = Color.White;

        protected override Color ProcessPixel(int x, int y, IPhoto photo)
        {
            Color pixel = photo.GetPixel(x, y);
            return pixel.CalcBrightness() > Threshold ? RightColor : LeftColor;
        }
    }
}