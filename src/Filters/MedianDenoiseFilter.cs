﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    public class MedianDenoiseFilter : MaskFilter
    {
        protected override void InitMask()
        {
            
        }

        protected override Color ProcessPixel(int x, int y, IPhoto photo)
        {
            Color pixel = photo.GetPixel(x, y);
            int cnt = (2 * Radius + 1) * (2 * Radius + 1);
            List<(Color, double)> pixels = new List<(Color, double)>(cnt);
            for (int i = -Radius; i <= Radius; i++)
                for (int j = -Radius; j <= Radius; j++)
                {
                    var curPixel = photo.ClampGetPixel(x - j, y - i);
                    pixels.Add((curPixel, curPixel.CalcBrightness()));
                }
            pixels.Sort((x, y) => x.Item2.CompareTo(y.Item2));
            return pixels[cnt / 2].Item1;

        }
    }
}