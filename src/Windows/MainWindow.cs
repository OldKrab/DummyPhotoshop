using System;
using System.Drawing;
using System.Windows.Forms;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Windows
{
    public partial class MainWindow : Form
    {
        public Bitmap Bitmap { get; private set; }
        private Bitmap OriginalBitmap { get;  set; }
        private BrightnessHistogram _brightnessHistogram;
        public MainWindow()
        {
            InitializeComponent();
            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap = new Bitmap(canvas.Image);
            OriginalBitmap = Bitmap;
            _brightnessHistogram = new BrightnessHistogram();
        }

        public void SetBitmap(Bitmap bitmap)
        {
            Bitmap = bitmap;
            canvas.Image = bitmap;
        }

        private void LoadButtonClicked(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog();
            diag.Filter = @"Files|*.jpg;*.jpeg;*.png";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                OriginalBitmap = new Bitmap(diag.FileName);
                SetBitmap(OriginalBitmap);
            }
        }

        private void brightnessContrastButton_Click(object sender, EventArgs e)
        {
            var backup = Bitmap;
            var window = new BrightnessContrastWindow(this);
            if (window.ShowDialog() != DialogResult.OK)
                SetBitmap(backup);
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            SetBitmap(OriginalBitmap);
        }

        

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
           histogramBox.Refresh();
        }

        private void histogramBox_Paint(object sender, PaintEventArgs e)
        {
            _brightnessHistogram.Draw(new Photo(Bitmap), e.Graphics);
        }
    }
}
