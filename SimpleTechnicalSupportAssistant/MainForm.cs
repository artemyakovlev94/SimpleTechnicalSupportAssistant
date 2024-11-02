using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using System.Xml.Serialization;
using SimpleTechnicalSupportFiles;
using static SimpleTechnicalSupportFiles.FileIssue;
using static SimpleTechnicalSupportFiles.FileHTTPLogs;
using static SimpleTechnicalSupportFiles.RegistrionLog;

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
            this.Text = this.Text + " " + Application.ProductVersion;
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
                        tempFile.Delete();

                    foreach (var dirTemp in dirInfo.EnumerateDirectories())
                        dirTemp.Delete(true);
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

        private void LoadDataForm()
        {
            PagesMain.Visible = true;

            ListViewItem listViewItem = new ListViewItem();
            ListViewGroup LVGroup = new ListViewGroup();

            if (Issue.Environment != null)
            {
                if (Issue.Environment.Platform != null)
                {
                    LVGroup = LVMain.Groups["Platform"];

                    listViewItem = LVMain.Items.Add("Тип");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Platform.Type);

                    listViewItem = LVMain.Items.Add("Версия");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Platform.Version);
                }

                if (Issue.Environment.Configuration != null)
                {
                    LVGroup = LVMain.Groups["Configuration"];

                    listViewItem = LVMain.Items.Add("Наименование");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.Name);

                    listViewItem = LVMain.Items.Add("Синоним");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.Synonym);

                    listViewItem = LVMain.Items.Add("Идентификатор интернет поддержки");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.SupportID);

                    listViewItem = LVMain.Items.Add("Редакция");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.Edition);

                    listViewItem = LVMain.Items.Add("Версия");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.Version);

                    listViewItem = LVMain.Items.Add("Версия БСП");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.VersionSSL);

                    listViewItem = LVMain.Items.Add("Режим совместимости");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.CompatibilityMode);

                    listViewItem = LVMain.Items.Add("Код языка");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.LanguageCode);

                    listViewItem = LVMain.Items.Add("Публикация выполнена");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.Published.ToString());

                    listViewItem = LVMain.Items.Add("Файловая база");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.IsFileDB.ToString());

                    listViewItem = LVMain.Items.Add("Идентификатор БД");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.IDFileDB);

                    listViewItem = LVMain.Items.Add("Базовая версия");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Configuration.IsBasicVersion.ToString());

                    if (Issue.Environment.Configuration.SeparationData != null)
                    {
                        LVGroup = LVMain.Groups["SeparationData"];

                        listViewItem = LVMain.Items.Add("Доступно");
                        listViewItem.Group = LVGroup;
                        listViewItem.SubItems.Add(Issue.Environment.Configuration.SeparationData.Available.ToString());

                        listViewItem = LVMain.Items.Add("Включено");
                        listViewItem.Group = LVGroup;
                        listViewItem.SubItems.Add(Issue.Environment.Configuration.SeparationData.Enabled.ToString());
                    }

                    if (Issue.Environment.Configuration.DIB != null)
                    {
                        LVGroup = LVMain.Groups["DIB"];

                        listViewItem = LVMain.Items.Add("Распределенная");
                        listViewItem.Group = LVGroup;
                        listViewItem.SubItems.Add(Issue.Environment.Configuration.DIB.IsNodeDIB.ToString());

                        listViewItem = LVMain.Items.Add("Распределенная с фильтром");
                        listViewItem.Group = LVGroup;
                        listViewItem.SubItems.Add(Issue.Environment.Configuration.DIB.IsNodeDIBWithFilter.ToString());

                        listViewItem = LVMain.Items.Add("Требуется обновление");
                        listViewItem.Group = LVGroup;
                        listViewItem.SubItems.Add(Issue.Environment.Configuration.DIB.AnUpdateIsRequired.ToString());
                    }

                    if (Issue.Environment.Configuration.Subsystems != null)
                    {
                        ListViewItem LVSubsystemsItem = new ListViewItem();
                        ListViewGroup LVSubsystemsGroup = LVSubsystems.Groups["Subsystems"];

                        foreach (EnvironmentConfigurationSubsystem subsystem in Issue.Environment.Configuration.Subsystems.Subsystem)
                        {
                            LVSubsystemsItem = LVSubsystems.Items.Add(subsystem.Name);
                            LVSubsystemsItem.Group = LVSubsystemsGroup;
                            LVSubsystemsItem.SubItems.Add(subsystem.Version);
                            LVSubsystemsItem.SubItems.Add(subsystem.SupportID);
                            LVSubsystemsItem.SubItems.Add(subsystem.IsConfiguration.ToString());
                        }
                    }
                }

                if (Issue.Environment.ExtensionSimple != null)
                {
                    LVGroup = LVMain.Groups["ExtensionSimple"];

                    listViewItem = LVMain.Items.Add("Версия");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.Version);

                    listViewItem = LVMain.Items.Add("Вариант обмена");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.ExchangeOption);

                    listViewItem = LVMain.Items.Add("Публикация выполнена");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.Published.ToString());

                    listViewItem = LVMain.Items.Add("Установка предварительных версий");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.InstallingPreviewVersion.ToString());

                    listViewItem = LVMain.Items.Add("Логирование HTTP запросов");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.HTTPLoggingEnabled.ToString());

                    listViewItem = LVMain.Items.Add("Перезапись штрихкодов в потоке");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.ReplaceBarcodeFlow.ToString());

                    listViewItem = LVMain.Items.Add("Регистрация документов после загрузки");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.ExtensionSimple.RegisterChangesAfterUploadingDocument.ToString());
                }

                if (Issue.Environment.Computer != null)
                {
                    LVGroup = LVMain.Groups["Computer"];

                    listViewItem = LVMain.Items.Add("Процессор");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Computer.CPU);

                    listViewItem = LVMain.Items.Add("Операционная система");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Computer.OS);

                    listViewItem = LVMain.Items.Add("Доступно ОЗУ");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Computer.AvailableRAM.ToString());
                }

                if (Issue.Environment.Client != null)
                {
                    LVGroup = LVMain.Groups["Client"];

                    listViewItem = LVMain.Items.Add("Клиент Windows");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsWindowsClient.ToString());

                    listViewItem = LVMain.Items.Add("Сервер Windows");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsWindowsServer.ToString());

                    listViewItem = LVMain.Items.Add("Клиент Linux");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsLinuxClient.ToString());

                    listViewItem = LVMain.Items.Add("Сервер Linux");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsLinuxServer.ToString());

                    listViewItem = LVMain.Items.Add("Клиент Mac OS");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsMacOSClient.ToString());

                    listViewItem = LVMain.Items.Add("Мобильный клиент");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsMobileClient.ToString());

                    listViewItem = LVMain.Items.Add("Веб клиент");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsWebClient.ToString());

                    listViewItem = LVMain.Items.Add("Подключен через веб клиент");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.ConnectedViaWebServer.ToString());

                    listViewItem = LVMain.Items.Add("Режим отладки");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsDebuggingMode.ToString());

                    listViewItem = LVMain.Items.Add("Автономное рабочее место");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.Environment.Client.IsOfflineWorkplace.ToString());
                }

                if (Issue.MobileApp != null)
                {
                    LVGroup = LVMain.Groups["MobileApp"];

                    listViewItem = LVMain.Items.Add("Версия");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.MobileApp.Version);

                    listViewItem = LVMain.Items.Add("Конфигурация");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.MobileApp.Configuration);

                    listViewItem = LVMain.Items.Add("Версия конфигурации");
                    listViewItem.Group = LVGroup;
                    listViewItem.SubItems.Add(Issue.MobileApp.ConfigurationVersion);
                }
            }

            if (Issue.HTTPLogs != null)
            {
                foreach (FileHTTPLogs.Log log in Issue.HTTPLogs.Logs.Log)
                {
                    int i = HTTPLoggingTable.Rows.Add();
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableSID"].Value = log.SID;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableDate"].Value = log.Date;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableMethod"].Value = log.Method;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableStatusCode"].Value = log.StatusCode;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableDeviceID"].Value = log.DeviceID;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableSession"].Value = log.Session;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableTimestamp"].Value = log.Timestamp;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableURL"].Value = log.URL.url;
                    HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableUserName"].Value = log.User.Name;

                    using (StreamReader sr = new StreamReader(Path.Combine(TempPath, log.Data.Path, log.Data.Request)))
                        HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableRequestData"].Value = sr.ReadToEnd();

                    using (StreamReader sr = new StreamReader(Path.Combine(TempPath, log.Data.Path, log.Data.Response)))
                        HTTPLoggingTable.Rows[i].Cells["HTTPLoggingTableResponseData"].Value = sr.ReadToEnd();
                }
            }

            if (Issue.RegistrionLogs != null)
            {
                foreach (RegistrionLog.Log log in Issue.RegistrionLogs.Logs)
                {
                    int i = RLTable.Rows.Add();
                    RLTable.Rows[i].Cells["RLTableDate"].Value = log.Date;
                    RLTable.Rows[i].Cells["RLTableDateSever"].Value = log.DateServer;
                    RLTable.Rows[i].Cells["RLTableLevel"].Value = log.Level;
                    RLTable.Rows[i].Cells["RLTableEventView"].Value = log.Event.View;
                    RLTable.Rows[i].Cells["RLTableMetadataView"].Value = log.Metadata.View;
                    RLTable.Rows[i].Cells["RLTableConnectUserName"].Value = log.Connect.User.Name;
                    RLTable.Rows[i].Cells["RLTableConnectSession"].Value = log.Connect.Session;
                    RLTable.Rows[i].Cells["RLTableConnectConnection"].Value = log.Connect.Connection;
                    RLTable.Rows[i].Cells["RLTableConnectServer"].Value = log.Connect.Server;
                    RLTable.Rows[i].Cells["RLTableConnectPortMain"].Value = log.Connect.Port.Main;
                    RLTable.Rows[i].Cells["RLTableConnectComputer"].Value = log.Connect.Computer;
                    RLTable.Rows[i].Cells["RLTableConnectAppView"].Value = log.Connect.App.View;
                    RLTable.Rows[i].Cells["RLTableDataSeparationView"].Value = log.DataSeparation.View;
                    RLTable.Rows[i].Cells["RLTableTransactionName"].Value = log.Transaction.Name;
                    RLTable.Rows[i].Cells["RLTableTransactionStatus"].Value = log.Transaction.Status;
                    RLTable.Rows[i].Cells["RLTableDataData"].Value = log.Data.Data;
                    RLTable.Rows[i].Cells["RLTableDataComment"].Value = log.Data.Comment;
                }
            }

            if (Issue.Attachments != null)
            {
                foreach (FileIssue.Attachment attachment in Issue.Attachments.attachments)
                {
                    FileInfo fileAttachment = new FileInfo(Path.Combine(TempPath, Issue.Attachments.Path, attachment.file.Path));

                    if (!fileAttachment.Exists)
                        continue;

                    int i = AttachmentTable.Rows.Add();
                    AttachmentTable.Rows[i].Cells["AttachmentTableName"].Value = attachment.Name;
                    AttachmentTable.Rows[i].Cells["AttachmentTableView"].Value = attachment.View;
                    AttachmentTable.Rows[i].Cells["AttachmentTableDescription"].Value = attachment.Description;
                    AttachmentTable.Rows[i].Cells["AttachmentTableFilePath"].Value = attachment.file.Path;
                    AttachmentTable.Rows[i].Cells["AttachmentTableFileExtension"].Value = attachment.file.extension;
                    AttachmentTable.Rows[i].Cells["AttachmentTableFileFullPath"].Value = fileAttachment.FullName;
                }
            }

            if (Issue.Message != null)
                MainMessageText.Lines = Issue.Message.Split('\n');
        }

        private void ResetDataForm()
        {
            ClearTempFolder();

            Issue = new Issue();

            PagesMain.Visible = false;

            LVMain.Items.Clear();
            LVSubsystems.Items.Clear();

            MainMessageText.Text = string.Empty;

            HTTPLoggingTable.Rows.Clear();
            HTTPLoggingSearchStringText.Text = string.Empty;
            HTTPLoggingTextRequest.Text = string.Empty;
            HTTPLoggingTextResponse.Text = string.Empty;

            RLTable.Rows.Clear();
            RLSearchText.Text = string.Empty;
            RLCommentText.Text = string.Empty;

            AttachmentTable.Rows.Clear();
            AttachmentPicturePrewiew.ImageLocation = string.Empty;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                ResetDataForm();

                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                if (fileInfo.Extension != ".zip")
                    throw new Exception("Файл должен быть архивом");

                ExtractArchiveToTempFolder(openFileDialog.FileName);

                fileInfo = new FileInfo(Path.Combine(TempPath, GetNameHTTPLogFile()));

                if (fileInfo.Exists)
                {
                    Issue.HTTPLogs = new HTTPLogs();

                    XmlSerializer serializer = new XmlSerializer(typeof(FileHTTPLogs.Logs));

                    using (FileStream fs = new FileStream(fileInfo.FullName, FileMode.OpenOrCreate))
                        Issue.HTTPLogs.Logs = serializer.Deserialize(fs) as FileHTTPLogs.Logs;
                }
                else
                {
                    fileInfo = new FileInfo(Path.Combine(TempPath, GetNameIssueFile()));

                    if (fileInfo.Exists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Issue));

                        using (FileStream fs = new FileStream(fileInfo.FullName, FileMode.Open))
                            Issue = serializer.Deserialize(fs) as Issue;

                        Issue.RegistrionLogs.Logs = new System.Collections.Generic.List<RegistrionLog.Log>();

                        foreach (FileIssue.File file in Issue.RegistrionLogs.files)
                        {
                            FileInfo fileInfoRLog = new FileInfo(Path.Combine(TempPath, Issue.RegistrionLogs.Path, file.Path));

                            if (!fileInfoRLog.Exists || fileInfoRLog.Extension != ".xml")
                                continue;

                            XmlSerializer serializerlog = new XmlSerializer(typeof(RegistrionLog.Log));
                            
                            using (FileStream fs = new FileStream(fileInfoRLog.FullName, FileMode.Open))
                                Issue.RegistrionLogs.Logs.Add(serializerlog.Deserialize(fs) as RegistrionLog.Log);
                        }

                        foreach (Attachment attachment in Issue.Attachments.attachments)
                        {
                            FileInfo fileAttachment = new FileInfo(Path.Combine(TempPath, Issue.Attachments.Path, attachment.file.Path));

                            if (!fileAttachment.Exists)
                            {
                                Issue.Attachments.attachments.Remove(attachment);
                                continue;
                            }

                            attachment.file.extension = fileAttachment.Extension;
                        }
                    }
                    else throw new Exception("Неизвестный файл");
                }

                LoadDataForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка чтения файла: " + ex.Message);
                ResetDataForm();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetDataForm();
        }

        private void HTTPLoggingTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var requestData = HTTPLoggingTable.Rows[e.RowIndex].Cells["HTTPLoggingTableRequestData"].Value;
            if (requestData != null)
                HTTPLoggingTextRequest.Text = requestData.ToString();

            var responseData = HTTPLoggingTable.Rows[e.RowIndex].Cells["HTTPLoggingTableResponseData"].Value;
            if (responseData != null)
                HTTPLoggingTextResponse.Text = responseData.ToString();
        }

        private void HTTPLoggingSearchStringText_TextChanged(object sender, EventArgs e)
        {
            HTTPLoggingTable.ClearSelection();

            if (string.IsNullOrWhiteSpace(HTTPLoggingSearchStringText.Text))
                return;

            var values = HTTPLoggingSearchStringText.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < HTTPLoggingTable.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = HTTPLoggingTable.Rows[i];

                    if (row.Cells["HTTPLoggingTableRequestData"].Value.ToString().Contains(value) ||
                        row.Cells["HTTPLoggingTableResponseData"].Value.ToString().Contains(value))
                        row.Selected = true;
                }
            }
        }

        private void RLSearchText_TextChanged(object sender, EventArgs e)
        {
            RLTable.ClearSelection();

            if (string.IsNullOrWhiteSpace(RLSearchText.Text))
                return;

            var values = RLSearchText.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < RLTable.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = RLTable.Rows[i];

                    if (row.Cells["RLTableDataComment"].Value.ToString().Contains(value))
                        row.Selected = true;
                }
            }
        }

        private void RLTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var comment = RLTable.Rows[e.RowIndex].Cells["RLTableDataComment"].Value;
            if (comment != null)
                RLCommentText.Lines = comment.ToString().Split('\n');
        }

        private void AttachmentTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            AttachmentPicturePrewiew.ImageLocation = string.Empty;

            var attachmentFullPath = AttachmentTable.Rows[e.RowIndex].Cells["AttachmentTableFileFullPath"].Value;
            if (attachmentFullPath != null)
                AttachmentPicturePrewiew.ImageLocation = attachmentFullPath.ToString();
        }

        private void AttachmentMenuSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AttachmentPicturePrewiew.ImageLocation))
                return;

            FileInfo fileInfo = new FileInfo(AttachmentPicturePrewiew.ImageLocation);

            if (!fileInfo.Exists)
                return;

            AttachmentSaveDialog.FileName = fileInfo.Name;
            AttachmentSaveDialog.OverwritePrompt = true;

            if (AttachmentSaveDialog.ShowDialog() != DialogResult.OK)
                return;

            System.IO.File.Copy(fileInfo.FullName, AttachmentSaveDialog.FileName, true);

            MessageBox.Show("Файл сохранен");
        }
    }
}