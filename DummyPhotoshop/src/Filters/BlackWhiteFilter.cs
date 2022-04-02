using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Черно-белый фильтр.
    /// </summary>
    /// <remarks>
    /// Каждая компонента текущего пикселя становится равна яркости этого пикселя.
    /// <conceptualLink target="catNegative"></conceptualLink>
    /// </remarks>
    public class BlackWhiteFilter:PixelFilter
    {
        protected override MyColor ProcessPixel(int x, int y, IPhoto photo)
        {
            MyColor pixel = photo.GetPixel(x, y);
            var br = (int)pixel.CalcBrightness();
            return new MyColor(br, br, br);
        }
    }
}