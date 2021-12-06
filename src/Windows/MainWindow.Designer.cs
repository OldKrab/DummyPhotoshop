
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loadButton = new System.Windows.Forms.Button();
            this.brightnessContrastButton = new System.Windows.Forms.Button();
            this.histogramBox = new System.Windows.Forms.PictureBox();
            this.RestoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).BeginInit();
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
            this.canvas.Location = new System.Drawing.Point(86, 67);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(420, 304);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer1.Panel1.Controls.Add(this.canvas);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel2.Controls.Add(this.rightPanel);
            this.splitContainer1.Panel2.Controls.Add(this.RestoreButton);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 450);
            this.splitContainer1.SplitterDistance = 622;
            this.splitContainer1.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.AutoSize = true;
            this.rightPanel.Controls.Add(this.loadButton);
            this.rightPanel.Controls.Add(this.brightnessContrastButton);
            this.rightPanel.Controls.Add(this.histogramBox);
            this.rightPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(412, 450);
            this.rightPanel.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(3, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(405, 30);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Загрузить фото";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButtonClicked);
            // 
            // brightnessContrastButton
            // 
            this.brightnessContrastButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.brightnessContrastButton.Location = new System.Drawing.Point(3, 39);
            this.brightnessContrastButton.Name = "brightnessContrastButton";
            this.brightnessContrastButton.Size = new System.Drawing.Size(405, 30);
            this.brightnessContrastButton.TabIndex = 1;
            this.brightnessContrastButton.Text = "Яркость/Контрасность";
            this.brightnessContrastButton.UseVisualStyleBackColor = true;
            this.brightnessContrastButton.Click += new System.EventHandler(this.brightnessContrastButton_Click);
            // 
            // histogramBox
            // 
            this.histogramBox.BackColor = System.Drawing.Color.White;
            this.histogramBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.histogramBox.Location = new System.Drawing.Point(3, 75);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(405, 213);
            this.histogramBox.TabIndex = 2;
            this.histogramBox.TabStop = false;
            this.histogramBox.Paint += new System.Windows.Forms.PaintEventHandler(this.histogramBox_Paint);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestoreButton.Location = new System.Drawing.Point(6, 408);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(213, 30);
            this.RestoreButton.TabIndex = 2;
            this.RestoreButton.Text = "Восстановить";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel rightPanel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button brightnessContrastButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.PictureBox histogramBox;
    }
}

