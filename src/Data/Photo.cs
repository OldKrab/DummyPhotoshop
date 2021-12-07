
using System.Drawing;
using System.IO;
using DummyPhotoshop.Data;

namespace Photoshop.Data
{
    //public class Photo
    //{
    //    public Photo(int height, int width)
    //    {
    //        Height = height;
    //        Width = width;
    //        Data = new Pixel[height, width];
    //    }

    //    public Pixel this[int i, int j]
    //    {
    //        get => Data[i, j];
    //        set => Data[i, j] = value;
    //    }

    //    public Photo ToBitmap()
    //    {
    //        Photo bmp = new Photo(Width, Height);
    //        for (int i = 0; i < Height; i++)
    //            for (int j = 0; j < Width; j++)
    //                bmp.SetPixel(j, i, Color.FromArgb(Data[i, j].R, Data[i, j].G, Data[i, j].B));
    //        return bmp;
    //    }

    //    public static Photo FromBitmap(Photo bmp)
    //    {
    //        Photo photo = new Photo(bmp.Height, bmp.Width);
    //        for (int i = 0; i < photo.Height; i++)
    //        for (int j = 0; j < photo.Width; j++)
    //        {
    //            var pixel = bmp.GetPixel(j, i);
    //            photo[i, j] = new Pixel {R = pixel.R, G = pixel.G, B = pixel.B};
    //        }
    //        return photo;
    //    }

    //    public int Width { get; }
    //    public int Height { get; }
    //    public Pixel[,] Data { get; }
    //}
}