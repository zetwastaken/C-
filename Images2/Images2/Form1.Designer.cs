namespace Images2
{
    partial class Form1
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
            grayscalePictureBox = new PictureBox();
            thresholdPictureBox = new PictureBox();
            negativePictureBox = new PictureBox();
            edgePictureBox = new PictureBox();
            originalPictureBox = new PictureBox();
            OpenImageButton_Click = new Button();
            ProcessImageButton_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)grayscalePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thresholdPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negativePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edgePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // grayscalePictureBox
            // 
            grayscalePictureBox.Location = new Point(321, 12);
            grayscalePictureBox.Name = "grayscalePictureBox";
            grayscalePictureBox.Size = new Size(221, 212);
            grayscalePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            grayscalePictureBox.TabIndex = 0;
            grayscalePictureBox.TabStop = false;
            // 
            // thresholdPictureBox
            // 
            thresholdPictureBox.Location = new Point(567, 12);
            thresholdPictureBox.Name = "thresholdPictureBox";
            thresholdPictureBox.Size = new Size(221, 212);
            thresholdPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            thresholdPictureBox.TabIndex = 1;
            thresholdPictureBox.TabStop = false;
            // 
            // negativePictureBox
            // 
            negativePictureBox.Location = new Point(321, 230);
            negativePictureBox.Name = "negativePictureBox";
            negativePictureBox.Size = new Size(221, 212);
            negativePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            negativePictureBox.TabIndex = 2;
            negativePictureBox.TabStop = false;
            // 
            // edgePictureBox
            // 
            edgePictureBox.Location = new Point(567, 230);
            edgePictureBox.Name = "edgePictureBox";
            edgePictureBox.Size = new Size(221, 212);
            edgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            edgePictureBox.TabIndex = 3;
            edgePictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            originalPictureBox.Location = new Point(12, 12);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(221, 212);
            originalPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            originalPictureBox.TabIndex = 4;
            originalPictureBox.TabStop = false;
            // 
            // OpenImageButton_Click
            // 
            OpenImageButton_Click.Location = new Point(43, 230);
            OpenImageButton_Click.Name = "OpenImageButton_Click";
            OpenImageButton_Click.Size = new Size(139, 76);
            OpenImageButton_Click.TabIndex = 5;
            OpenImageButton_Click.Text = "Load image";
            OpenImageButton_Click.UseVisualStyleBackColor = true;
            OpenImageButton_Click.Click += OpenImageButton_Click_Click;
            // 
            // ProcessImageButton_Click
            // 
            ProcessImageButton_Click.Location = new Point(43, 312);
            ProcessImageButton_Click.Name = "ProcessImageButton_Click";
            ProcessImageButton_Click.Size = new Size(139, 76);
            ProcessImageButton_Click.TabIndex = 6;
            ProcessImageButton_Click.Text = "Process image";
            ProcessImageButton_Click.UseVisualStyleBackColor = true;
            ProcessImageButton_Click.Click += ProcessImageButton_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProcessImageButton_Click);
            Controls.Add(OpenImageButton_Click);
            Controls.Add(originalPictureBox);
            Controls.Add(edgePictureBox);
            Controls.Add(negativePictureBox);
            Controls.Add(thresholdPictureBox);
            Controls.Add(grayscalePictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grayscalePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thresholdPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)negativePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)edgePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox grayscalePictureBox;
        private PictureBox thresholdPictureBox;
        private PictureBox negativePictureBox;
        private PictureBox edgePictureBox;
        private PictureBox originalPictureBox;
        private Button OpenImageButton_Click;
        private Button ProcessImageButton_Click;
    }
}
