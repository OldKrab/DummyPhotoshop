﻿using System;
using System.Drawing;
using DummyPhotoshop.Data;
using Photoshop.Filters;

namespace DummyPhotoshop.Filters
{
    public class BrightnessFilter : PixelFilter
    {
        public int Coefficient { get; set; }

        protected override Color ProcessPixel(int x, int y, IPhoto photo)
        {
            Color pixel = photo.GetPixel(x, y);
            return Color.FromArgb(
                Math.Clamp(pixel.R + Coefficient, 0, 255),
                Math.Clamp(pixel.G + Coefficient, 0, 255),
                Math.Clamp(pixel.B + Coefficient, 0, 255));
        }
    }
}