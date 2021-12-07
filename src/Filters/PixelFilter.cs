using System;
using System.Drawing;
using System.Threading.Tasks;
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
           
            int maxThreads = 12;
            Parallel.For(0, maxThreads, thread =>
            {
                int from = thread * photo.Height / maxThreads;
                int to = (thread + 1) * photo.Height / maxThreads;
                for (int i = from; i < to; i++)
                    for (int j = 0; j < photo.Width; j++)
                        resPhoto.SetPixel(j, i, ProcessPixel(photo.GetPixel(j, i)));
            });


            return resPhoto;
        }

        protected virtual void PreProcess(Photo photo)
        {
        }

        protected abstract Color ProcessPixel(Color pixel);


    }
}