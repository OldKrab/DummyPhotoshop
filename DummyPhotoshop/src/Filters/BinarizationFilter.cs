using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Фильтр бинаризации.
    /// </summary>
    /// <remarks>
    /// Если яркость текущего пикселя больше <see cref="Threshold"/>,
    /// то он становится равен <see cref="RightColor"/>, иначе <see cref="LeftColor"/>.
    /// </remarks>
    public class BinarizationFilter : PixelFilter
    {
        /// <summary>
        /// Пороговое значение яркости.
        /// </summary>
        public int Threshold { get; set; }

        /// <summary>
        /// Цвет пикселя, если яркость меньше либо равна <see cref="Threshold"/>.
        /// </summary>
        public MyColor LeftColor { get; set; } = new MyColor(0,0,0);

        /// <summary>
        /// Цвет пикселя, если яркость больше <see cref="Threshold"/>.
        /// </summary>
        public MyColor RightColor { get; set; } =  new MyColor(255,255,255);

        protected override MyColor ProcessPixel(int x, int y, IPhoto photo)
        {
            MyColor pixel = photo.GetPixel(x, y);
            return pixel.CalcBrightness() > Threshold ? RightColor : LeftColor;
        }
    }
}