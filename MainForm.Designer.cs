﻿namespace SimpleFile
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
            textFolderPath = new TextBox();
            FilePaths = new ListView();
            Rename = new Button();
            Suffix = new Button();
            Extraction = new Button();
            SelectSuffix = new Button();
            Refresh = new Button();
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
            // textFolderPath
            // 
            textFolderPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textFolderPath.Location = new Point(129, 24);
            textFolderPath.Name = "textFolderPath";
            textFolderPath.Size = new Size(627, 23);
            textFolderPath.TabIndex = 1;
            // 
            // FilePaths
            // 
            FilePaths.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FilePaths.CheckBoxes = true;
            FilePaths.FullRowSelect = true;
            FilePaths.GridLines = true;
            FilePaths.Location = new Point(129, 59);
            FilePaths.Name = "FilePaths";
            FilePaths.Size = new Size(627, 355);
            FilePaths.TabIndex = 2;
            FilePaths.UseCompatibleStateImageBehavior = false;
            FilePaths.View = View.List;
            // 
            // Rename
            // 
            Rename.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Rename.Location = new Point(28, 388);
            Rename.Name = "Rename";
            Rename.Size = new Size(75, 23);
            Rename.TabIndex = 3;
            Rename.Text = "重命名";
            Rename.UseVisualStyleBackColor = true;
            // 
            // Suffix
            // 
            Suffix.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Suffix.Location = new Point(28, 359);
            Suffix.Name = "Suffix";
            Suffix.Size = new Size(75, 23);
            Suffix.TabIndex = 4;
            Suffix.Text = "改后缀";
            Suffix.UseVisualStyleBackColor = true;
            Suffix.Click += Suffix_Click;
            // 
            // Extraction
            // 
            Extraction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Extraction.Location = new Point(28, 330);
            Extraction.Name = "Extraction";
            Extraction.Size = new Size(75, 23);
            Extraction.TabIndex = 5;
            Extraction.Text = "文件提取";
            Extraction.UseVisualStyleBackColor = true;
            Extraction.Click += Extraction_Click;
            // 
            // SelectSuffix
            // 
            SelectSuffix.Location = new Point(28, 59);
            SelectSuffix.Name = "SelectSuffix";
            SelectSuffix.Size = new Size(75, 23);
            SelectSuffix.TabIndex = 6;
            SelectSuffix.Text = "选择后缀";
            SelectSuffix.UseVisualStyleBackColor = true;
            SelectSuffix.Click += SelectSuffix_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(28, 88);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 7;
            Refresh.Text = "刷新";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Refresh);
            Controls.Add(SelectSuffix);
            Controls.Add(Extraction);
            Controls.Add(Suffix);
            Controls.Add(Rename);
            Controls.Add(FilePaths);
            Controls.Add(textFolderPath);
            Controls.Add(SelectFolder);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectFolder;
        private TextBox textFolderPath;
        private ListView FilePaths;
        private Button Rename;
        private Button Suffix;
        private Button Extraction;
        private Button SelectSuffix;
        private Button Refresh;
    }
}