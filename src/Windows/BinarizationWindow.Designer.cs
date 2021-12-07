
namespace DummyPhotoshop.src.Windows
{
    partial class BinarizationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.histogramBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.binarizationTrackbar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarizationTrackbar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // histogramBox
            // 
            this.histogramBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.histogramBox.BackColor = System.Drawing.Color.White;
            this.histogramBox.Location = new System.Drawing.Point(10, 2);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(481, 158);
            this.histogramBox.TabIndex = 3;
            this.histogramBox.TabStop = false;
            this.histogramBox.Paint += new System.Windows.Forms.PaintEventHandler(this.histogramBox_Paint);
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton.Location = new System.Drawing.Point(523, 53);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CancelButton.Size = new System.Drawing.Size(106, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(523, 12);
            this.okButton.Margin = new System.Windows.Forms.Padding(6);
            this.okButton.Name = "okButton";
            this.okButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.okButton.Size = new System.Drawing.Size(106, 29);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Применить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // binarizationTrackbar
            // 
            this.binarizationTrackbar.AutoSize = false;
            this.binarizationTrackbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.binarizationTrackbar.Location = new System.Drawing.Point(0, 163);
            this.binarizationTrackbar.Margin = new System.Windows.Forms.Padding(0);
            this.binarizationTrackbar.Maximum = 255;
            this.binarizationTrackbar.Name = "binarizationTrackbar";
            this.binarizationTrackbar.Size = new System.Drawing.Size(502, 38);
            this.binarizationTrackbar.TabIndex = 6;
            this.binarizationTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.binarizationTrackbar.Value = 100;
            this.binarizationTrackbar.ValueChanged += new System.EventHandler(this.binarizationTrackbar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.histogramBox);
            this.panel1.Controls.Add(this.binarizationTrackbar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 201);
            this.panel1.TabIndex = 7;
            // 
            // BinarizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 216);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "BinarizationWindow";
            this.Text = "Бинаризация";
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarizationTrackbar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox histogramBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar binarizationTrackbar;
        private System.Windows.Forms.Panel panel1;
    }
}