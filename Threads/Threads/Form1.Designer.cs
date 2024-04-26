namespace Threads
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
            sizeNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            coresNumericUpDown = new NumericUpDown();
            resultTextBox = new RichTextBox();
            multiplyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)sizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coresNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // sizeNumericUpDown
            // 
            sizeNumericUpDown.Location = new Point(22, 42);
            sizeNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            sizeNumericUpDown.Name = "sizeNumericUpDown";
            sizeNumericUpDown.Size = new Size(120, 23);
            sizeNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 1;
            label1.Text = "Size of Array";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 2;
            label2.Text = "Cores";
            // 
            // coresNumericUpDown
            // 
            coresNumericUpDown.Location = new Point(22, 101);
            coresNumericUpDown.Name = "coresNumericUpDown";
            coresNumericUpDown.Size = new Size(120, 23);
            coresNumericUpDown.TabIndex = 3;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(233, 212);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(301, 193);
            resultTextBox.TabIndex = 4;
            resultTextBox.Text = "";
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(61, 235);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(75, 23);
            multiplyButton.TabIndex = 5;
            multiplyButton.Text = "Calculate";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(multiplyButton);
            Controls.Add(resultTextBox);
            Controls.Add(coresNumericUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sizeNumericUpDown);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sizeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)coresNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown sizeNumericUpDown;
        private Label label1;
        private Label label2;
        private NumericUpDown coresNumericUpDown;
        private RichTextBox resultTextBox;
        private Button multiplyButton;
    }
}
