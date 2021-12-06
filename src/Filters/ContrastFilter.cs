using System;
using System.Drawing;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class ContrastFilter:PixelFilter
    {
        public double Coefficient { get; set; }

        private Color _averageColor;
        protected override void PreProcess(Photo photo)
        {
            _averageColor = photo.GetAverageColor();
        }

        protected override Color ProcessPixel(Color pixel)
        {
            int c = _averageColor.CalcBrightness();
            //return Color.FromArgb(
            //    Math.Clamp((int) ((pixel.R - c) * Coefficient + c), 0, 255),
            //    Math.Clamp((int) ((pixel.G - c) * Coefficient + c), 0, 255),
            //    Math.Clamp((int) ((pixel.B - c) * Coefficient + c), 0, 255)
            //    );
            return Color.FromArgb(
                Math.Clamp((int) ((pixel.R - _averageColor.R) * Coefficient + _averageColor.R), 0, 255),
                Math.Clamp((int) ((pixel.G - _averageColor.G) * Coefficient +_averageColor.G), 0, 255),
                Math.Clamp((int) ((pixel.B - _averageColor.B) * Coefficient + _averageColor.B), 0, 255)
            );
        }
    }
}