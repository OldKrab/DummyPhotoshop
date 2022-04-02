using System;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Фильтр изменения контрастности.
    /// </summary>
    /// <remarks>
    /// Каждая компонента цвета пикселя вычисляется по формуле:\n
    /// <event cref="Exception">This event is raised to let the user know
    /// something happened.</event>
    /// \f$ x = (x - b) * c + b \f$,\n
    /// где b - средняя яркость изображения,\n
    ///     с - <see cref="Coefficient"/>.
    /// </remarks>
    public class ContrastFilter:PixelFilter
    {
        /// <summary>
        /// Коэффициент изменения контрастности
        /// </summary>
        public double Coefficient { get; set; } = 1;

        private MyColor _averageColor;

        protected override void PreProcess(IPhoto photo)
        {
            _averageColor = photo.GetAverageColor();
        }

        protected override MyColor ProcessPixel(int x, int y, IPhoto photo)
        {
            MyColor pixel = photo.GetPixel(x, y);
            double b = _averageColor.CalcBrightness();
            return new MyColor(
                Math.Clamp((int) ((pixel.R - b) * Coefficient + b), 0, 255),
                Math.Clamp((int) ((pixel.G - b) * Coefficient + b), 0, 255),
                Math.Clamp((int) ((pixel.B - b) * Coefficient + b), 0, 255)
            );
        }

     
    }
}