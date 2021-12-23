using System;
using System.Drawing;

namespace DummyPhotoshop.Data
{
    public interface IPhoto:  ICloneable
    {
         Bitmap Bitmap { get; }
         int Width { get; }
         int Height { get; }

         void SetPixel(int x, int y, Color colour);
         Color GetPixel(int x, int y);
         Color GetAverageColor();
        
    }
}