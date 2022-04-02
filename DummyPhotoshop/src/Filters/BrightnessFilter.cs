using System;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Фильтр изменения яркости.
    /// </summary>
    /// <remarks>
    /// Каждая компонента пикселя изменится на <see cref="Coefficient"/>.
    /// </remarks>
    public class BrightnessFilter : PixelFilter
    {
        /// <summary>
        /// Изменение для каждой компоненты пикселя
        /// </summary>
        public int Coefficient { get; set; }

        protected override MyColor ProcessPixel(int x, int y, IPhoto photo)
        {
            MyColor pixel = photo.GetPixel(x, y);
            return new MyColor(
                Math.Clamp(pixel.R + Coefficient, 0, 255),
                Math.Clamp(pixel.G + Coefficient, 0, 255),
                Math.Clamp(pixel.B + Coefficient, 0, 255));
        }
    }
}