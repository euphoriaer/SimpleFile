using Krypton.Toolkit;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SimpleFile
{
    public partial class MainForm : Form
    {
        private string folderPath;
        private string fileSuffix;

        public MainForm()
        {
            InitializeComponent();
            textFolderPath.KeyDown += FolderPathChange;
            FilePaths.KeyDown += ALLSelect;
        }

        private void ALLSelect(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < FilePaths.Items.Count; i++)
                {
                    FilePaths.Items[i].Checked = true;
                }
            }
        }

        public string FolderPath
        {
            get
            {
                return folderPath;
            }

            set
            {
                Debug.WriteLine(value);
                folderPath = value;
            }
        }

        public string FileSuffix
        {
            get
            {
                return fileSuffix;
            }

            set
            {
                Debug.WriteLine(value);
                fileSuffix = value;
            }
        }

        private void FolderPathChange(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FolderPath = textFolderPath.Text;
                RefreshFiles();
            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            bool isOK;
            FolderPath = DialogTools.OpenFolder(out isOK);
            if (!isOK)
            {
                return;
            }

            textFolderPath.Text = FolderPath.ToString();
            RefreshFiles();
        }

        private async void SelectSuffix_Click(object sender, EventArgs e)
        {
            FileSuffix = KryptonInputBox.Show("��׺��");
            Debug.WriteLine(FileSuffix);
            RefreshFiles();
        }

        private void Suffix_Click(object sender, EventArgs e)
        {
            var tarSuffix = KryptonInputBox.Show("��׺��");
            ProgressBar.Value = 0;
            var selectFilesPaths = GetSelectFiles();
            for (int i = 0; i < selectFilesPaths.Count; i++)
            {
                ProgressBar.Value++;
                FileInfo file = new FileInfo(selectFilesPaths[i]);
                if (!file.Exists)
                {
                    continue;
                }
                var targetFilePath = file.FullName;
                var extension = Path.GetExtension(file.FullName);
                var name = Path.GetFileNameWithoutExtension(file.FullName);
                var dirName = Path.GetDirectoryName(file.FullName);
                var tarPath = Path.Combine(dirName, name) + $".{tarSuffix}";
                if (File.Exists(tarPath))
                {
                    continue;
                }
                file.MoveTo(tarPath);

            }
            MessageBox.Show("���");
            RefreshFiles();
        }

        private void RefreshFiles()
        {
            ProgressBar.Value = 0;
            var files = GetConditionFiles();
            FilePaths.Items.Clear();
            for (int i = 0; i < files.Count; i++)
            {
                FilePaths.Items.Add(files[i].FullName);
            }
        }

        private List<FileInfo> GetConditionFiles()
        {
            List<FileInfo> filesList = new List<FileInfo>();
            if (string.IsNullOrEmpty(folderPath))
            {
                return new List<FileInfo>();
            }
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            if (string.IsNullOrEmpty(FileSuffix))
            {
                FileSuffix = "*";
            }
            var files = directory.GetFiles($"*.{FileSuffix}", SearchOption.AllDirectories);

            filesList.AddRange(files);

            return filesList;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private List<string> GetSelectFiles()
        {
            List<string> paths = new List<string>();

            for (int i = 0; i < FilePaths.Items.Count; i++)
            {
                if (FilePaths.Items[i].Checked)
                {
                    paths.Add(FilePaths.Items[i].Text);
                }
            }
            ProgressBar.Maximum = paths.Count;
            return paths;
        }
        private void Rename_Click(object sender, EventArgs e)
        {
            var reName = KryptonInputBox.Show("����");
            ProgressBar.Value = 0;
            var selectFilesPaths = GetSelectFiles();
            for (int i = 0; i < selectFilesPaths.Count; i++)
            {
                ProgressBar.Value++;
                FileInfo file = new FileInfo(selectFilesPaths[i]);
                if (!file.Exists)
                {
                    continue;
                }
                var targetFilePath = file.FullName;
                var extension = Path.GetExtension(file.FullName);
                var dirName = Path.GetDirectoryName(file.FullName);
                var tarPath = Path.Combine(dirName, reName) + i.ToString() + extension;

                file.MoveTo(tarPath);

            }
            MessageBox.Show("���");
            RefreshFiles();
        }

        private void Extraction_Click(object sender, EventArgs e)
        {
            bool isOK;
            var targetFolderPath = DialogTools.OpenFolder(out isOK);
            if (!isOK)
            {
                return;
            }

            ProgressBar.Value = 0;
            var selectFilesPaths = GetSelectFiles();
            for (int i = 0; i < selectFilesPaths.Count; i++)
            {
                ProgressBar.Value++;
                FileInfo file = new FileInfo(selectFilesPaths[i]);
                if (!file.Exists)
                {
                    continue;
                }

                var targetFilePath = file.FullName;
                var extension = Path.GetExtension(file.FullName);
                var name = Path.GetFileNameWithoutExtension(file.FullName);
                var tarPath = Path.Combine(targetFolderPath, name) + extension;

                if (tarPath == selectFilesPaths[i])
                {
                    continue;
                }

                if (File.Exists(tarPath))
                {
                    tarPath = Path.Combine(targetFolderPath, name) + "_" + Path.GetRandomFileName() + extension;
                }
                file.MoveTo(tarPath);

            }
            MessageBox.Show("���");
            RefreshFiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            var selectFilesPaths = GetSelectFiles();
            for (int i = 0; i < selectFilesPaths.Count; i++)
            {
                ProgressBar.Value++;
                FileInfo file = new FileInfo(selectFilesPaths[i]);
                if (!file.Exists)
                {
                    continue;
                }

                string input = Path.GetFileNameWithoutExtension(file.FullName);

                // ʹ��������ʽƥ�����з����ġ�����ĸ�ͷ����ֵ��ַ�
                string pattern = @"[^\u4e00-\u9fa5\p{L}\p{N}]";

                // �滻ƥ�䵽���ַ�Ϊ���ַ���
                string result = Regex.Replace(input, pattern, "");

                Console.WriteLine(result);  // ���: �������HelloWorld1234

                var targetFilePath = file.FullName;
                var extension = Path.GetExtension(file.FullName);
                var dirName = Path.GetDirectoryName(file.FullName);
                var tarPath = Path.Combine(dirName, result)+extension;

                file.MoveTo(tarPath);

            }
            MessageBox.Show("���");
            RefreshFiles();
        }
    }
}