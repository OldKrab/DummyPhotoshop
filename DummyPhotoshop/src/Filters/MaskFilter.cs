using System;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Базовый класс для фильтра, который применяет определенную маску к каждому пикселю
    /// </summary>
    public abstract class MaskFilter : PixelFilter 
    {
        /// <summary>
        /// Радиус применяемой маски.
        /// </summary>
        public int Radius { get; set; } = 1;

        /// <summary>
        /// Маска для фильтра.
        /// </summary>
        /// <remarks>
        /// Вычисляется при каждой обработке изображения в методе <see cref="InitMask"/>.
        /// </remarks>
        protected double[,] Mask;

        /// <summary>
        /// Метод для инициализации <see cref="Mask"/>.
        /// </summary>
        /// <remarks>
        /// Вызывается перед каждой обработкой изображения.
        /// <see cref="Mask"/> перед вызовом уже создан и имеет радиус <see cref="Radius"/>.
        /// </remarks>
        protected abstract void InitMask();

        protected override void PreProcess(IPhoto photo)
        {
            Mask = new double[2 * Radius + 1, 2 * Radius + 1];
            InitMask();
        }

        protected override MyColor ProcessPixel(int x, int y, IPhoto photo)
        {
            double r = 0, g = 0, b = 0;
            for (int i = 0; i < 2*Radius+1; i++)
                for (int j = 0; j < 2*Radius+1; j++)
                {
                    var c = Radius;
                    var currPixel = photo.ClampGetPixel(x + j - c, y + i - c);
                    double coef = Mask[i, j];
                    r += currPixel.R * coef;
                    g += currPixel.G * coef;
                    b += currPixel.B * coef;
                }

            return new MyColor(
                Math.Clamp((int)(r), 0, 255),
                Math.Clamp((int)(g), 0, 255),
                Math.Clamp((int)(b), 0, 255)
            );

        }
    }

}