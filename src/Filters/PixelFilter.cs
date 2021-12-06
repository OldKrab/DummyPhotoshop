using System.Drawing;
using DummyPhotoshop.Data;
using Photoshop.Data;
using Photoshop.Filters;

namespace DummyPhotoshop.Filters
{
    public abstract class PixelFilter : IFilter 
    {
        public Photo ProcessImage(Photo photo)
        {
            PreProcess(photo);
            var resPhoto = new Photo(photo.Width, photo.Height);
            for (int i = 0; i < photo.Height; i++)
                for (int j = 0; j < photo.Width; j++)
                    resPhoto.SetPixel(j,i, ProcessPixel(photo.GetPixel(j,i)));
            return resPhoto;
        }

        protected virtual void PreProcess(Photo photo)
        {
        }

        protected abstract Color ProcessPixel(Color pixel);

       
    }
}