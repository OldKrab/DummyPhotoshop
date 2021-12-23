using System;
using System.Drawing;
using System.Threading.Tasks;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class GaussianDenoiseFilter : MaskFilter
    {
        public double Variance { get; set; } = 1;

        protected override void InitMask()
        {
            for (int i = 0; i < Radius + 1; i++)
                for (int j = i; j < Radius + 1; j++)
                {
                    var value = CalcH(i, j);
                    var c = Radius;
                    _mask[c + i, c + j] = value;
                    _mask[c + i, c - j] = value;
                    _mask[c - i, c + j] = value;
                    _mask[c - i, c - j] = value;
                    _mask[c + j, c + i] = value;
                    _mask[c + j, c - i] = value;
                    _mask[c - j, c + i] = value;
                    _mask[c - j, c - i] = value;
                }

            double hSum = 0;
            for (int i = 0; i <= 2 * Radius; i++)
                for (int j = 0; j <= 2 * Radius; j++)
                    hSum += _mask[i, j];

            double a = 1.0 / hSum;
            for (int i = 0; i < 2 * Radius + 1; i++)
            {
                for (int j = 0; j < 2 * Radius + 1; j++)
                {
                    _mask[i, j] *= a;
                }
            }
        }

        private double CalcH(int x, int y) => Math.Exp(-(x * x + y * y) / (2 * Variance * Variance));

    }
}