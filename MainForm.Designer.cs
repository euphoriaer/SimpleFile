namespace SimpleFile
{
    partial class MainForm
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
            SelectFolder = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            Rename = new Button();
            Suffix = new Button();
            Extraction = new Button();
            SuspendLayout();
            // 
            // SelectFolder
            // 
            SelectFolder.Location = new Point(12, 21);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(111, 29);
            SelectFolder.TabIndex = 0;
            SelectFolder.Text = "选择文件夹";
            SelectFolder.UseVisualStyleBackColor = true;
            SelectFolder.Click += SelectFolder_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(627, 23);
            textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(129, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(627, 355);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Rename
            // 
            Rename.Location = new Point(24, 70);
            Rename.Name = "Rename";
            Rename.Size = new Size(75, 23);
            Rename.TabIndex = 3;
            Rename.Text = "重命名";
            Rename.UseVisualStyleBackColor = true;
            // 
            // Suffix
            // 
            Suffix.Location = new Point(24, 99);
            Suffix.Name = "Suffix";
            Suffix.Size = new Size(75, 23);
            Suffix.TabIndex = 4;
            Suffix.Text = "改后缀";
            Suffix.UseVisualStyleBackColor = true;
            // 
            // Extraction
            // 
            Extraction.Location = new Point(24, 128);
            Extraction.Name = "Extraction";
            Extraction.Size = new Size(75, 23);
            Extraction.TabIndex = 5;
            Extraction.Text = "文件提取";
            Extraction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Extraction);
            Controls.Add(Suffix);
            Controls.Add(Rename);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(SelectFolder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectFolder;
        private TextBox textBox1;
        private ListView listView1;
        private Button Rename;
        private Button Suffix;
        private Button Extraction;
    }
}