using System;
using System.Windows.Forms;
using DummyPhotoshop.Data;
using DummyPhotoshop.Filters;

namespace DummyPhotoshop.Windows
{
    public partial class BrightnessContrastWindow : Form
    {
        private Photo _photo;
        private BrightnessFilter _brightnessFilter;
        private ContrastFilter _contrastFilter;
        private MainWindow _mainWindow;
        private double _contrastMultiplier = 0.01;
        private double _maxContrast = 5;
        public BrightnessContrastWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _photo = new Photo(mainWindow.Bitmap);
            _brightnessFilter = new BrightnessFilter();
            _contrastFilter = new ContrastFilter();
            contrastTrackbar.Minimum = 0;
            contrastTrackbar.Maximum = (int)(_maxContrast / _contrastMultiplier);
            contrastTrackbar.Value = (int)(1 / _contrastMultiplier);

            brightnessTextBox.Text = brightnessTrackbar.Value.ToString();
            contrastTextBox.Text = GetCurrentContrast().ToString();
            _mainWindow = mainWindow;
            mainWindow.SetBitmap(_photo.Bitmap);
        }

        private double GetCurrentContrast()
        {
            return contrastTrackbar.Value * _contrastMultiplier;
        }
        private void brightnessTrackbar_ValueChanged(object sender, EventArgs e)
        {
            brightnessTextBox.Text = brightnessTrackbar.Value.ToString();
            _brightnessFilter.Coefficient = brightnessTrackbar.Value;
            var resPhoto = _brightnessFilter.ProcessImage(_photo);
            _mainWindow.SetBitmap(resPhoto.Bitmap);
        }
        private void contrastTrackbar_ValueChanged(object sender, EventArgs e)
        {
            contrastTextBox.Text = GetCurrentContrast().ToString();
            _contrastFilter.Coefficient = GetCurrentContrast();
            var resPhoto = _contrastFilter.ProcessImage(_photo);
            _mainWindow.SetBitmap(resPhoto.Bitmap);
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
