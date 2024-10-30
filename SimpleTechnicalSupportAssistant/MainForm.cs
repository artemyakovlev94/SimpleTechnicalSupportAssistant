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

            foreach (var log in Issue.HTTPLogs.Logs.Log)
            {
                int i = dgwHTTPLogging.Rows.Add();
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingSID"].Value = log.SID;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingDate"].Value = log.Date;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingMethod"].Value = log.Method;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingStatusCode"].Value = log.StatusCode;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingDeviceID"].Value = log.DeviceID;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingSession"].Value = log.Session;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingTimestamp"].Value = log.Timestamp;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingURL"].Value = log.URL.url;
                dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingUserName"].Value = log.User.Name;

                using (StreamReader sr = new StreamReader(Path.Combine(TempPath, log.Data.Path, log.Data.Request)))
                    dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingRequestData"].Value = sr.ReadToEnd();

                using (StreamReader sr = new StreamReader(Path.Combine(TempPath, log.Data.Path, log.Data.Response)))
                    dgwHTTPLogging.Rows[i].Cells["dgwHTTPLoggingResponseData"].Value = sr.ReadToEnd();
            }
        }

        private void ResetDataForm()
        {
            ClearTempFolder();

            Issue = new Issue();

            tabControlMain.Visible = false;

            dgwHTTPLogging.Rows.Clear();
            tbHTTPLoggingSearch.Text = string.Empty;
            tbHTTPLoggingRequest.Text = string.Empty;
            tbHTTPLoggingResponse.Text = string.Empty;
        }

        private void dgwHTTPLogging_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var requestData = dgwHTTPLogging.Rows[e.RowIndex].Cells["dgwHTTPLoggingRequestData"].Value;
            if (requestData != null)
                tbHTTPLoggingRequest.Text = requestData.ToString();

            var responseData = dgwHTTPLogging.Rows[e.RowIndex].Cells["dgwHTTPLoggingResponseData"].Value;
            if (responseData != null)
                tbHTTPLoggingResponse.Text = responseData.ToString();
        }

        private void tbHTTPLoggingSearch_TextChanged(object sender, EventArgs e)
        {
            dgwHTTPLogging.ClearSelection();

            if (string.IsNullOrWhiteSpace(tbHTTPLoggingSearch.Text))
                return;

            var values = tbHTTPLoggingSearch.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < dgwHTTPLogging.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = dgwHTTPLogging.Rows[i];

                    if (row.Cells["dgwHTTPLoggingRequestData"].Value.ToString().Contains(value) ||
                        row.Cells["dgwHTTPLoggingResponseData"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                    }
                }
            }
        }
    }
}
