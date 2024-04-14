namespace Api
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            textBoxAddVies = new TextBox();
            textBoxViesCountyAdd = new TextBox();
            buttonShowDb = new Button();
            Nip = new Label();
            label1 = new Label();
            viesAllBindingSource = new BindingSource(components);
            textBoxFindName = new TextBox();
            label2 = new Label();
            buttonFind = new Button();
            ((System.ComponentModel.ISupportInitialize)viesAllBindingSource).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(339, 232);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(299, 138);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(45, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 1;
            button1.Text = "Dodaj Dane";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(339, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(449, 214);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBoxAddVies
            // 
            textBoxAddVies.Location = new Point(45, 58);
            textBoxAddVies.Name = "textBoxAddVies";
            textBoxAddVies.Size = new Size(180, 23);
            textBoxAddVies.TabIndex = 3;
            // 
            // textBoxViesCountyAdd
            // 
            textBoxViesCountyAdd.Location = new Point(45, 107);
            textBoxViesCountyAdd.Name = "textBoxViesCountyAdd";
            textBoxViesCountyAdd.Size = new Size(100, 23);
            textBoxViesCountyAdd.TabIndex = 4;
            // 
            // buttonShowDb
            // 
            buttonShowDb.Location = new Point(339, 393);
            buttonShowDb.Name = "buttonShowDb";
            buttonShowDb.Size = new Size(75, 45);
            buttonShowDb.TabIndex = 5;
            buttonShowDb.Text = "Pobierz Dane";
            buttonShowDb.UseVisualStyleBackColor = true;
            buttonShowDb.Click += buttonShowDb_Click;
            // 
            // Nip
            // 
            Nip.AutoSize = true;
            Nip.Location = new Point(47, 34);
            Nip.Name = "Nip";
            Nip.Size = new Size(26, 15);
            Nip.TabIndex = 6;
            Nip.Text = "NIP";
            Nip.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 89);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 7;
            label1.Text = "Kraj";
            // 
            // viesAllBindingSource
            // 
            viesAllBindingSource.DataSource = typeof(ViesAll);
            // 
            // textBoxFindName
            // 
            textBoxFindName.Location = new Point(45, 242);
            textBoxFindName.Name = "textBoxFindName";
            textBoxFindName.Size = new Size(129, 23);
            textBoxFindName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 211);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 9;
            label2.Text = "Znajdź po nazwie";
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(45, 287);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(75, 23);
            buttonFind.TabIndex = 10;
            buttonFind.Text = "Wyszukaj";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFind);
            Controls.Add(label2);
            Controls.Add(textBoxFindName);
            Controls.Add(label1);
            Controls.Add(Nip);
            Controls.Add(buttonShowDb);
            Controls.Add(textBoxViesCountyAdd);
            Controls.Add(textBoxAddVies);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)viesAllBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBoxAddVies;
        private TextBox textBoxViesCountyAdd;
        private Button buttonShowDb;
        private Label Nip;
        private Label label1;
        private BindingSource viesAllBindingSource;
        private TextBox textBoxFindName;
        private Label label2;
        private Button buttonFind;
    }
}
