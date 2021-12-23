using System;
using System.Drawing;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class ContrastFilter:PixelFilter
    {
        public double Coefficient { get; set; } = 1;

        private Color _averageColor;
        protected override void PreProcess(IPhoto photo)
        {
            _averageColor = photo.GetAverageColor();
        }

        protected override Color ProcessPixel(int x, int y, IPhoto photo)
        {
            Color pixel = photo.GetPixel(x, y);
            double c = _averageColor.CalcBrightness();
            return Color.FromArgb(
                Math.Clamp((int) ((pixel.R - c) * Coefficient + c), 0, 255),
                Math.Clamp((int) ((pixel.G - c) * Coefficient + c), 0, 255),
                Math.Clamp((int) ((pixel.B - c) * Coefficient + c), 0, 255)
            );
        }

     
    }
}