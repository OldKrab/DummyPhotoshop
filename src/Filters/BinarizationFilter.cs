using System.Drawing;

namespace DummyPhotoshop.Filters
{
    public class BinarizationFilter : PixelFilter
    {
        public int Threshold { get; set; }
        public Color LeftColor { get; set; } = Color.Black;
        public Color RightColor { get; set; } = Color.White;
        protected override Color ProcessPixel(Color pixel)
        {
            return pixel.CalcBrightness() > Threshold ? RightColor : LeftColor;
        }
    }
}