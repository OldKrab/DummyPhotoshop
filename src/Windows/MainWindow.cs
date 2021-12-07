using System;
using System.Drawing;
using System.Windows.Forms;
using DummyPhotoshop.Data;
using DummyPhotoshop.Filters;
using DummyPhotoshop.src.Windows;

namespace DummyPhotoshop.Windows
{
    public partial class MainWindow : Form
    {
        public Photo Photo { get; private set; }
        private Photo OriginalPhoto { get;  set; }
        private BrightnessHistogram _brightnessHistogram;
        public MainWindow()
        {
            InitializeComponent();
            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo = new Photo((Bitmap)canvas.Image);
            OriginalPhoto = Photo;
            _brightnessHistogram = new BrightnessHistogram();
        }

        public void SetPhoto(Photo bitmap)
        {
            Photo = bitmap;
            canvas.Image = bitmap.Bitmap;
        }

        private void LoadButtonClicked(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog();
            diag.Filter = @"Files|*.jpg;*.jpeg;*.png";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                OriginalPhoto = new Photo(new Bitmap(diag.FileName));
                SetPhoto(OriginalPhoto);
            }
        }

        private void BrightnessContrastButtonClick(object sender, EventArgs e)
        {
            var backup = Photo;
            var window = new BrightnessContrastWindow(this);
            if (window.ShowDialog() != DialogResult.OK)
                SetPhoto(backup);
        }

        private void RestoreButtonClick(object sender, EventArgs e)
        {
            SetPhoto(OriginalPhoto);
        }

        private void CanvasPaint(object sender, PaintEventArgs e)
        {
           histogramBox.Refresh();
        }

        private void HistogramBoxPaint(object sender, PaintEventArgs e)
        {
            _brightnessHistogram.Draw(Photo, e.Graphics);
        }

        private void BinarizationButtonClick(object sender, EventArgs e)
        {
            var backup = Photo;
            var window = new BinarizationWindow(this);
            if (window.ShowDialog() != DialogResult.OK)
                SetPhoto(backup);
        }

        private void BlackWhiteButtonClick(object sender, EventArgs e)
        {
            var bw = new BlackWhiteFilter();
            SetPhoto(bw.ProcessImage(Photo));
        }

        private void NegativeButtonClick(object sender, EventArgs e)
        {
            var neg = new NegativeFilter();
            SetPhoto(neg.ProcessImage(Photo));
        }

        private void CanvasMouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("click");
        }
    }
}
