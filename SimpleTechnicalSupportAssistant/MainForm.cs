using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Xml.Serialization;
using SimpleTechnicalSupportFiles;
using static SimpleTechnicalSupportFiles.FileIssue;
using static SimpleTechnicalSupportFiles.FileHTTPLogs;

namespace SimpleTechnicalSupportAssistant
{
    public partial class MainForm : Form
    {
        private string TempPath;
        private Issue Issue;

        public MainForm()
        {
            InitializeComponent();

            InitTempFolder();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearTempFolder();
        }

        private void InitTempFolder()
        {
            try
            {
                ResetDataForm();

                Process currentProcess = Process.GetCurrentProcess();

                string[] paths = { Path.GetTempPath(), currentProcess.ProcessName };
                string tempPath = Path.Combine(paths);

                DirectoryInfo dirInfo = new DirectoryInfo(tempPath);

                TempPath = dirInfo.FullName;

                if (dirInfo.Exists)
                    ClearTempFolder();
                else
                    dirInfo.Create();
            }
            catch (Exception e)
            {
                TempPath = string.Empty;
                MessageBox.Show(e.Message);
            }
        }

        private void ClearTempFolder()
        {
            if (string.IsNullOrEmpty(TempPath))
                return;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(TempPath);

                if (dirInfo.Exists)
                {
                    var tempFiles = dirInfo.EnumerateFiles("*", SearchOption.AllDirectories);
                    foreach (var tempFile in tempFiles)
                    {
                        tempFile.Delete();
                        if (!tempFile.Directory.EnumerateFileSystemInfos().Any())
                            tempFile.Directory.Delete();
                    }

                    foreach (var dirTemp in dirInfo.EnumerateDirectories())
                        dirTemp.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExtractArchiveToTempFolder(string filePath)
        {
            using (ZipArchive archive = ZipFile.Open(filePath, ZipArchiveMode.Read, Encoding.UTF8))
                archive.ExtractToDirectory(TempPath);
        }

        private void обращениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            ResetDataForm();

            try
            {
                ExtractArchiveToTempFolder(openFileDialog.FileName);

                FileInfo fileInfo = new FileInfo(Path.Combine(TempPath, GetNameIssueFile()));

                if (!fileInfo.Exists)
                {
                    MessageBox.Show("В архиве отсутствует файл обращения");
                }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Issue));

                    using (FileStream fs = new FileStream(fileInfo.FullName, FileMode.OpenOrCreate))
                        Issue = serializer.Deserialize(fs) as Issue;

                    LoadDataForm();
                }
            }
            catch (Exception ex) { 
                ResetDataForm(); 
                MessageBox.Show(ex.Message); 
            }
        }

        private void логированиеHTTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            ResetDataForm();

            try
            {
                ExtractArchiveToTempFolder(openFileDialog.FileName);

                FileInfo fileInfo = new FileInfo(Path.Combine(TempPath, GetNameHTTPLogFile()));

                if (!fileInfo.Exists)
                {
                    MessageBox.Show("В архиве отсутствует файл логирования HTTP запросов");
                }
                else
                {

                    Issue.HTTPLogs = new HTTPLogs();

                    XmlSerializer serializer = new XmlSerializer(typeof(FileHTTPLogs.Logs));

                    using (FileStream fs = new FileStream(fileInfo.FullName, FileMode.OpenOrCreate))
                        Issue.HTTPLogs.Logs = serializer.Deserialize(fs) as FileHTTPLogs.Logs;

                    LoadDataForm();
                }
            }
            catch (Exception ex) { 
                ResetDataForm(); 
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetDataForm();
        }

        private void LoadDataForm()
        {
            tabControlMain.Visible = true;

        }

        private void ResetDataForm()
        {
            ClearTempFolder();

            Issue = new Issue();

            tabControlMain.Visible = false;
        }
    }
}
