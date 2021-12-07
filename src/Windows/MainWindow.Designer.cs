
namespace DummyPhotoshop.Windows
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.brightnessContrastButton = new System.Windows.Forms.Button();
            this.histogramBox = new System.Windows.Forms.PictureBox();
            this.binarizationButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.negativeButton = new System.Windows.Forms.Button();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Default;
            this.canvas.Image = ((System.Drawing.Image)(resources.GetObject("canvas.Image")));
            this.canvas.Location = new System.Drawing.Point(91, 46);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(623, 442);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPaint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseDown);
            // 
            // brightnessContrastButton
            // 
            this.brightnessContrastButton.Location = new System.Drawing.Point(8, 250);
            this.brightnessContrastButton.Name = "brightnessContrastButton";
            this.brightnessContrastButton.Size = new System.Drawing.Size(217, 30);
            this.brightnessContrastButton.TabIndex = 1;
            this.brightnessContrastButton.Text = "Яркость/Контрасность";
            this.brightnessContrastButton.UseVisualStyleBackColor = true;
            this.brightnessContrastButton.Click += new System.EventHandler(this.BrightnessContrastButtonClick);
            // 
            // histogramBox
            // 
            this.histogramBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox.BackColor = System.Drawing.Color.White;
            this.histogramBox.Location = new System.Drawing.Point(8, 46);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(468, 198);
            this.histogramBox.TabIndex = 2;
            this.histogramBox.TabStop = false;
            this.histogramBox.Paint += new System.Windows.Forms.PaintEventHandler(this.HistogramBoxPaint);
            // 
            // binarizationButton
            // 
            this.binarizationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.binarizationButton.Location = new System.Drawing.Point(259, 250);
            this.binarizationButton.Name = "binarizationButton";
            this.binarizationButton.Size = new System.Drawing.Size(217, 30);
            this.binarizationButton.TabIndex = 3;
            this.binarizationButton.Text = "Бинаризация";
            this.binarizationButton.UseVisualStyleBackColor = true;
            this.binarizationButton.Click += new System.EventHandler(this.BinarizationButtonClick);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadButton.Location = new System.Drawing.Point(130, 8);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(220, 32);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Загрузить фото";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButtonClicked);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RestoreButton.Location = new System.Drawing.Point(130, 507);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(220, 30);
            this.RestoreButton.TabIndex = 2;
            this.RestoreButton.Text = "Восстановить";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButtonClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.canvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 545);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.negativeButton);
            this.panel2.Controls.Add(this.blackWhiteButton);
            this.panel2.Controls.Add(this.RestoreButton);
            this.panel2.Controls.Add(this.binarizationButton);
            this.panel2.Controls.Add(this.histogramBox);
            this.panel2.Controls.Add(this.brightnessContrastButton);
            this.panel2.Controls.Add(this.loadButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(793, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(484, 545);
            this.panel2.TabIndex = 2;
            // 
            // negativeButton
            // 
            this.negativeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.negativeButton.Location = new System.Drawing.Point(259, 286);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(217, 30);
            this.negativeButton.TabIndex = 5;
            this.negativeButton.Text = "Инверсия";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.NegativeButtonClick);
            // 
            // blackWhiteButton
            // 
            this.blackWhiteButton.Location = new System.Drawing.Point(8, 286);
            this.blackWhiteButton.Name = "blackWhiteButton";
            this.blackWhiteButton.Size = new System.Drawing.Size(217, 30);
            this.blackWhiteButton.TabIndex = 4;
            this.blackWhiteButton.Text = "Черное-белое";
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.BlackWhiteButtonClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button brightnessContrastButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.PictureBox histogramBox;
        private System.Windows.Forms.Button binarizationButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.Button negativeButton;
    }
}

