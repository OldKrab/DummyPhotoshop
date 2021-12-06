using System.Drawing;
using DummyPhotoshop.Data;

namespace DummyPhotoshop
{
    public static class Extentions
    {
        public static Color GetAverageColor(this Photo photo)
        {
            long r = 0, g = 0, b = 0;
            for (int i = 0; i < photo.Height; i++)
                for (int j = 0; j < photo.Width; j++)
                {
                    var pixel = photo.GetPixel(j, i);
                    r += pixel.R;
                    g += pixel.G;
                    b += pixel.B;
                }

            long cnt = photo.Height * photo.Width;
            return Color.FromArgb((int)(r / cnt), (int)(g / cnt), (int)(b / cnt));
        }

        public static int CalcBrightness(this Color color)
        {
            return (int)(0.299 * color.R + 0.5876 * color.G + 0.114 * color.B);
        }
    }
}