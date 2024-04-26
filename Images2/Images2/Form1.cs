using System.Drawing;

namespace Images2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Bitmap temp1,temp2,temp3,temp4;
        private void OpenImageButton_Click_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Update originalPictureBox.Image on the UI thread
                    originalPictureBox.Invoke(new Action(() =>
                    {
                        originalPictureBox.Image = new Bitmap(openFileDialog.FileName);
                        temp4 = new Bitmap(openFileDialog.FileName);
                        temp1 = new Bitmap(openFileDialog.FileName);
                        temp2 = new Bitmap(openFileDialog.FileName);
                        temp3 = new Bitmap(openFileDialog.FileName);

                    }));
                }
            }
        }

        private void ProcessImageButton_Click_Click(object sender, EventArgs e)
        {
            Thread[] threads = new Thread[4];
            if (originalPictureBox.Image != null)
            {
                // Clear previous images
                ClearProcessedImages();

                // Perform image processing using threads


                threads[0] = new Thread(() => ProcessImage(temp4, grayscalePictureBox, ImageProcessingType.Grayscale));
                threads[1] = new Thread(() => ProcessImage(temp1, thresholdPictureBox, ImageProcessingType.Threshold));
                threads[2] = new Thread(() => ProcessImage(temp2, negativePictureBox, ImageProcessingType.Negative));
                threads[3] = new Thread(() => ProcessImage(temp3, edgePictureBox, ImageProcessingType.EdgeDetection));
                foreach (Thread t in threads)
                {
                    t.Start();
                }
                foreach (Thread t in threads)
                {
                    t.Join();
                }

                    
                
   
            }
            else
            {
                MessageBox.Show("Please open an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void ClearProcessedImages()
        {
            grayscalePictureBox.Image = null;
            thresholdPictureBox.Image = null;
            negativePictureBox.Image = null;
            edgePictureBox.Image = null;
        }

        private void ProcessImage(Bitmap originalImage, PictureBox pictureBox, ImageProcessingType processingType)
        {
            Bitmap processedImage = null;

            switch (processingType)
            {
                case ImageProcessingType.Grayscale:
                    processedImage = ConvertToGrayscale((Bitmap)originalImage);
                    break;
                case ImageProcessingType.Threshold:
                    processedImage = ApplyThreshold((Bitmap)originalImage);
                    break;
                case ImageProcessingType.Negative:
                    processedImage = ApplyNegativeTransformation((Bitmap)originalImage);
                    break;
                case ImageProcessingType.EdgeDetection:
                    processedImage = DetectEdges((Bitmap)originalImage);
                    break;
            }
            pictureBox.Image = processedImage;
        }

        private Bitmap ConvertToGrayscale(Bitmap originalImage)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    int grayValue = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    processedImage.SetPixel(x, y, grayColor);
                }
            }

            return processedImage;
        }

        private Bitmap ApplyThreshold(Bitmap originalImage)
        {
            // Dummy implementation: simply setting a fixed threshold value
            int threshold = 128;
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    int grayValue = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    Color newColor = grayValue >= threshold ? Color.White : Color.Black;
                    processedImage.SetPixel(x, y, newColor);
                }
            }

            return processedImage;
        }

        private Bitmap ApplyNegativeTransformation(Bitmap originalImage)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processedImage.SetPixel(x, y, newColor);
                }
            }

            return processedImage;
        }

        private Bitmap DetectEdges(Bitmap originalImage)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 1; x < originalImage.Width - 1; x++)
            {
                for (int y = 1; y < originalImage.Height - 1; y++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    Color neighborPixel = originalImage.GetPixel(x + 1, y + 1);
                    int edgeValue = Math.Abs(pixel.R - neighborPixel.R);
                    Color edgeColor = Color.FromArgb(edgeValue, edgeValue, edgeValue);
                    processedImage.SetPixel(x, y, edgeColor);
                }
            }

            return processedImage;
        }

    }

    enum ImageProcessingType
    {
        Grayscale,
        Threshold,
        Negative,
        EdgeDetection
    }
}
