using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DummyPhotoshop.Data;
using DummyPhotoshop.Filters;
using Photoshop.Filters;

namespace DummyPhotoshop.Windows
{
    public partial class MainWindow : Form
    {
        public IPhoto Photo { get; private set; }
        public Stack<IPhoto> UndoStack, RedoStack;

        private Bitmap _originalBitmap;
        private BrightnessHistogram _brightnessHistogram;
        public MainWindow()
        {
            InitializeComponent();

             canvas.SizeMode = PictureBoxSizeMode.StretchImage;

            SetPhoto(new Photo(canvas.Width, canvas.Height));
            UndoStack = new Stack<IPhoto>();
            RedoStack = new Stack<IPhoto>();
            UndoStack.Push(Photo);
            _brightnessHistogram = new BrightnessHistogram();
        }

        public void SetPhoto(IPhoto bitmap)
        {
            _originalBitmap = bitmap.Bitmap;
            Photo = bitmap;
            canvas.Image = bitmap.Bitmap;
            canvas.Refresh();
            histogramBox.Refresh();
        }

        public IPhoto ResizePhoto(Bitmap bitmap, Size size)
        {
            return new Photo(new Bitmap(bitmap, size));
        }

        public void AddPhotoToUndo(IPhoto photo)
        {
            UndoStack.Push(photo);
            RedoStack.Clear();
        }

        public void Undo()
        {
            if (UndoStack.Count > 0)
            {
                RedoStack.Push(Photo);
                SetPhoto(UndoStack.Peek());
                UndoStack.Pop();
            }
        }
        public void Redo()
        {
            if (RedoStack.Count > 0)
            {
                UndoStack.Push(Photo);
                SetPhoto(RedoStack.Peek());
                RedoStack.Pop();
            }
        }


        private void LoadButtonClicked(object sender, EventArgs e)
        {
            _isCropped = false;
            var diag = new OpenFileDialog();
            diag.Filter = @"Files|*.jpg;*.jpeg;*.png";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                UndoStack.Clear();
                UndoStack.Push(new Photo(new Bitmap(diag.FileName)));
                SetPhoto(UndoStack.Peek());
            }

        }
        private void OpenFilterWindow(Form window)
        {
            var backup = Photo;
            if (window.ShowDialog() != DialogResult.OK)
                SetPhoto(backup);
            else
                AddPhotoToUndo(backup);

        }

        private void BrightnessContrastButtonClick(object sender, EventArgs e)
        {
            OpenFilterWindow(new BrightnessContrastWindow(this));
        }
        private void BinarizationButtonClick(object sender, EventArgs e)
        {
            OpenFilterWindow(new BinarizationWindow(this));
        }
        private void NoiseButtonClick(object sender, EventArgs e)
        {
            OpenFilterWindow(new AddNoiseWindow(this));
        }
        private void GaussianDenoiseButtonClick(object sender, EventArgs e)
        {
            OpenFilterWindow(new GaussianDenoiseWindow(this));
        }
        private void UniformDenoiseButtonClick(object sender, EventArgs e)
        {
            OpenFilterWindow(new MaskFilterWindow<UniformDenoiseFilter>(this, "Равномерное шумоподавление"));
        }
        private void MedianDenoiseButtonClick(object sender, EventArgs e)
        {
            OpenFilterWindow(new MaskFilterWindow<MedianDenoiseFilter>(this, "Медианное шумоподавление"));
        }

        private void sharpeningButton_Click(object sender, EventArgs e)
        {
            OpenFilterWindow(new SharpeningWindow(this));

        }
        private void ApplyFilter(IFilter filter)
        {
            AddPhotoToUndo(Photo);
            SetPhoto(filter.ProcessImage(Photo));
        }

        private void BlackWhiteButtonClick(object sender, EventArgs e)
        {
            ApplyFilter(new BlackWhiteFilter());
        }

        private void NegativeButtonClick(object sender, EventArgs e)
        {
            ApplyFilter(new NegativeFilter());
        }

        private void embossingButton_Click(object sender, EventArgs e)
        {
            ApplyFilter(new EmbossingFilter());
        }

        private bool _isCropped;
        private Point _startPoint;
        private Rectangle _crop;
        private void CanvasMouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;

        }
        private void CanvasMouseUp(object sender, MouseEventArgs e)
        {
            if (_isCropped)
                Photo = ((PhotoCrop)Photo).CropedPhoto;
            if (_startPoint == e.Location && _isCropped)
            {
                // Click
                _isCropped = false;
            }
            else
            {
                var lu = new Point(Math.Min(_startPoint.X, e.Location.X), Math.Min(_startPoint.Y, e.Location.Y));
                var rd = new Point(Math.Max(_startPoint.X, e.Location.X), Math.Max(_startPoint.Y, e.Location.Y));
                rd.X = Math.Min(rd.X, canvas.Size.Width);
                rd.Y = Math.Min(rd.Y, canvas.Size.Height);
                PointF coef = new PointF((float)Photo.Width / canvas.Size.Width, (float)Photo.Height / canvas.Size.Height);
                var rect = Rectangle.FromLTRB(
                    (int)(lu.X * coef.X),
                    (int)(lu.Y * coef.Y),
                    (int)(rd.X * coef.X),
                    (int)(rd.Y * coef.Y)
                );
                Photo = new PhotoCrop((Photo)Photo, rect);
                _crop = Rectangle.FromLTRB(lu.X, lu.Y, rd.X, rd.Y);
                _isCropped = true;
            }

            canvas.Refresh();
            histogramBox.Refresh();

        }
        private void CanvasPaint(object sender, PaintEventArgs e)
        {
            if (_isCropped)
                e.Graphics.DrawRectangle(new Pen(Color.Black), _crop);
        }
        private void RestoreButtonClick(object sender, EventArgs e)
        {
            while (UndoStack.Count != 1)
                UndoStack.Pop();
            SetPhoto(UndoStack.Peek());
            _isCropped = false;
        }
        private void HistogramBoxPaint(object sender, PaintEventArgs e)
        {
            _brightnessHistogram.Draw(Photo, e.Graphics);
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            Photo = ResizePhoto(_originalBitmap, canvas.Size);
            canvas.Refresh();
            
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && (e.Control))
                Undo();
            else if (e.KeyCode == Keys.Y && (e.Control))
                Redo();
        }
    }
}
