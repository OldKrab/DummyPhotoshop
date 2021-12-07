using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DummyPhotoshop.Data;
using DummyPhotoshop.Filters;
using DummyPhotoshop.Windows;

namespace DummyPhotoshop.src.Windows
{
    public partial class BinarizationWindow : Form
    {
        private Photo _photo;
        private BinarizationFilter _binarizationFilter;
        private MainWindow _mainWindow;
        private BrightnessHistogram _brightnessHistogram;
        public BinarizationWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _photo = mainWindow.Photo;
            _binarizationFilter = new BinarizationFilter();
            _brightnessHistogram = new BrightnessHistogram();
            _mainWindow = mainWindow;
            binarizationTrackbar.Value = 125;
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
       
        private void binarizationTrackbar_ValueChanged(object sender, EventArgs e)
        {
            _binarizationFilter.Threshold = binarizationTrackbar.Value;
            var resPhoto = _binarizationFilter.ProcessImage(_photo);
            _mainWindow.SetPhoto(resPhoto);
        }

        private void histogramBox_Paint(object sender, PaintEventArgs e)
        {
            _brightnessHistogram.Draw(_photo, e.Graphics);
        }
    }
}
