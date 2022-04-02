using System.Threading.Tasks;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Базовый класс для фильтра, который обрабатывает каждый пиксель.
    /// </summary>

    public abstract class PixelFilter : IFilter
    {
        public IPhoto ProcessImage(IPhoto photo)
        {

            PreProcess(photo);
            var resPhoto = (IPhoto)photo.Clone();
            int maxThreads = 42;
            Parallel.For(0, maxThreads, thread =>
            {
                int from = thread * photo.Height / maxThreads;
                int to = (thread + 1) * photo.Height / maxThreads;
                for (int i = from; i < to; i++)
                for (int j = 0; j < photo.Width; j++)
                    resPhoto.SetPixel(j, i, ProcessPixel(j, i, photo));
            });
            return resPhoto;
        }

        /// <summary>
        /// Предварительные действия перед обработкой.
        /// </summary>
        /// <param name="photo">Обрабатываемое изображение</param>
        protected virtual void PreProcess(IPhoto photo)
        {
        }

        /// <summary>
        /// Функция для обработки одного пикселя.
        /// </summary>
        /// <param name="x">X-координата пикселя</param>
        /// <param name="y">Y-координата пикселя</param>
        /// <param name="photo">Обрабатываемое изображение</param>
        /// <returns>Вычисленный пиксель</returns>
        protected abstract MyColor ProcessPixel(int x, int y, IPhoto photo);

    }
}

