using System.Drawing;
using System.Linq;
using DummyPhotoshop.Data;

namespace DummyPhotoshop
{
    public class BrightnessHistogram
    {
        public int MaxValue { get; set; }
        public void Draw(Photo photo, Graphics gr)
        {
            float wigth = gr.VisibleClipBounds.Width;
            float height = gr.VisibleClipBounds.Height;
            var distribution = new int[256];
            for (int i = 0; i < photo.Height; i++)
                for (int j = 0; j < photo.Width; j++)
                    distribution[photo.GetPixel(j, i).CalcBrightness()]++;

            MaxValue = (int)distribution.Where(x=>x>0).Average()*2;
            float prevX = 0;
            for (int i = 0; i < 256; i++)
            {
                float x = (float)(i + 1) / 256 * wigth;
                float y = (float)distribution[i] / MaxValue * height;
                using (Brush br = new SolidBrush(Color.Black))
                {
                    gr.FillRectangle(br, prevX, 0, x - prevX, y);
                }

                prevX = x;
            }
        }

    }
}