namespace SimpleTechnicalSupportAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Платформа", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Конфигурация", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Разделение данных", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Распределенная база данных", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Расширение Simple", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Мобильное приложение", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Компьютер", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Клиент", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Подсистемы", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PagesMain = new System.Windows.Forms.TabControl();
            this.PageMain = new System.Windows.Forms.TabPage();
            this.MainContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainContainer2 = new System.Windows.Forms.SplitContainer();
            this.LVMain = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVSubsystems = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainMessageGroup = new System.Windows.Forms.GroupBox();
            this.MainMessageText = new System.Windows.Forms.TextBox();
            this.PageHTTPLogging = new System.Windows.Forms.TabPage();
            this.HTTPLoggingMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HTTPLoggingMainContainer = new System.Windows.Forms.SplitContainer();
            this.HTTPLoggingTable = new System.Windows.Forms.DataGridView();
            this.HTTPLoggingTableSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableStatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableDeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableRequestData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingTableResponseData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTPLoggingContainerRequestResponse = new System.Windows.Forms.SplitContainer();
            this.HTTPLoggingGroupRequest = new System.Windows.Forms.GroupBox();
            this.HTTPLoggingTextRequest = new System.Windows.Forms.TextBox();
            this.HTTPLoggingGroupResponse = new System.Windows.Forms.GroupBox();
            this.HTTPLoggingTextResponse = new System.Windows.Forms.TextBox();
            this.HTTPLoggingSearchStringPanel = new System.Windows.Forms.Panel();
            this.HTTPLoggingSearchStringLabel = new System.Windows.Forms.Label();
            this.HTTPLoggingSearchStringText = new System.Windows.Forms.TextBox();
            this.PageRegistrationLog = new System.Windows.Forms.TabPage();
            this.RLMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RLContainer = new System.Windows.Forms.SplitContainer();
            this.RLTable = new System.Windows.Forms.DataGridView();
            this.RLTableDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableEventView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableMetadataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectAppView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectComputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableDateSever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectPortMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableConnectConnection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableDataSeparationView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableTransactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableTransactionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableDataData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLTableDataComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLCommentText = new System.Windows.Forms.TextBox();
            this.RLSearchPanel = new System.Windows.Forms.Panel();
            this.RLSearchLabel = new System.Windows.Forms.Label();
            this.RLSearchText = new System.Windows.Forms.TextBox();
            this.PageAttachments = new System.Windows.Forms.TabPage();
            this.AttachmentMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AttachmentContainer = new System.Windows.Forms.SplitContainer();
            this.AttachmentTable = new System.Windows.Forms.DataGridView();
            this.AttachmentTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentTableView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentTableDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentTableFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentTableFileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentTableFileFullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AttachmentMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.AttachmentPicturePrewiew = new System.Windows.Forms.PictureBox();
            this.AttachmentSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu.SuspendLayout();
            this.PagesMain.SuspendLayout();
            this.PageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer1)).BeginInit();
            this.MainContainer1.Panel1.SuspendLayout();
            this.MainContainer1.Panel2.SuspendLayout();
            this.MainContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer2)).BeginInit();
            this.MainContainer2.Panel1.SuspendLayout();
            this.MainContainer2.Panel2.SuspendLayout();
            this.MainContainer2.SuspendLayout();
            this.MainMessageGroup.SuspendLayout();
            this.PageHTTPLogging.SuspendLayout();
            this.HTTPLoggingMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HTTPLoggingMainContainer)).BeginInit();
            this.HTTPLoggingMainContainer.Panel1.SuspendLayout();
            this.HTTPLoggingMainContainer.Panel2.SuspendLayout();
            this.HTTPLoggingMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HTTPLoggingTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HTTPLoggingContainerRequestResponse)).BeginInit();
            this.HTTPLoggingContainerRequestResponse.Panel1.SuspendLayout();
            this.HTTPLoggingContainerRequestResponse.Panel2.SuspendLayout();
            this.HTTPLoggingContainerRequestResponse.SuspendLayout();
            this.HTTPLoggingGroupRequest.SuspendLayout();
            this.HTTPLoggingGroupResponse.SuspendLayout();
            this.HTTPLoggingSearchStringPanel.SuspendLayout();
            this.PageRegistrationLog.SuspendLayout();
            this.RLMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RLContainer)).BeginInit();
            this.RLContainer.Panel1.SuspendLayout();
            this.RLContainer.Panel2.SuspendLayout();
            this.RLContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RLTable)).BeginInit();
            this.RLSearchPanel.SuspendLayout();
            this.PageAttachments.SuspendLayout();
            this.AttachmentMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentContainer)).BeginInit();
            this.AttachmentContainer.Panel1.SuspendLayout();
            this.AttachmentContainer.Panel2.SuspendLayout();
            this.AttachmentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentTable)).BeginInit();
            this.AttachmentMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentPicturePrewiew)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файл архива (*.zip)|*.zip|All files(*.*)|*.*";
            this.openFileDialog.Title = "Выберите файл";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1120, 24);
            this.MainMenu.TabIndex = 0;
            // 
            // MainMenuFile
            // 
            this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.MainMenuFile.Name = "MainMenuFile";
            this.MainMenuFile.Size = new System.Drawing.Size(48, 20);
            this.MainMenuFile.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // PagesMain
            // 
            this.PagesMain.Controls.Add(this.PageMain);
            this.PagesMain.Controls.Add(this.PageHTTPLogging);
            this.PagesMain.Controls.Add(this.PageRegistrationLog);
            this.PagesMain.Controls.Add(this.PageAttachments);
            this.PagesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagesMain.Location = new System.Drawing.Point(0, 24);
            this.PagesMain.Name = "PagesMain";
            this.PagesMain.SelectedIndex = 0;
            this.PagesMain.Size = new System.Drawing.Size(1120, 519);
            this.PagesMain.TabIndex = 1;
            // 
            // PageMain
            // 
            this.PageMain.AutoScroll = true;
            this.PageMain.Controls.Add(this.MainContainer1);
            this.PageMain.Location = new System.Drawing.Point(4, 22);
            this.PageMain.Name = "PageMain";
            this.PageMain.Padding = new System.Windows.Forms.Padding(3);
            this.PageMain.Size = new System.Drawing.Size(1112, 493);
            this.PageMain.TabIndex = 0;
            this.PageMain.Text = "Основное";
            this.PageMain.UseVisualStyleBackColor = true;
            // 
            // MainContainer1
            // 
            this.MainContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer1.Location = new System.Drawing.Point(3, 3);
            this.MainContainer1.Name = "MainContainer1";
            this.MainContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer1.Panel1
            // 
            this.MainContainer1.Panel1.Controls.Add(this.MainContainer2);
            // 
            // MainContainer1.Panel2
            // 
            this.MainContainer1.Panel2.Controls.Add(this.MainMessageGroup);
            this.MainContainer1.Size = new System.Drawing.Size(1106, 487);
            this.MainContainer1.SplitterDistance = 322;
            this.MainContainer1.TabIndex = 9;
            // 
            // MainContainer2
            // 
            this.MainContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer2.Location = new System.Drawing.Point(0, 0);
            this.MainContainer2.Name = "MainContainer2";
            // 
            // MainContainer2.Panel1
            // 
            this.MainContainer2.Panel1.Controls.Add(this.LVMain);
            // 
            // MainContainer2.Panel2
            // 
            this.MainContainer2.Panel2.Controls.Add(this.LVSubsystems);
            this.MainContainer2.Size = new System.Drawing.Size(1106, 322);
            this.MainContainer2.SplitterDistance = 532;
            this.MainContainer2.TabIndex = 0;
            // 
            // LVMain
            // 
            this.LVMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.LVMain.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Платформа";
            listViewGroup1.Name = "Platform";
            listViewGroup2.Header = "Конфигурация";
            listViewGroup2.Name = "Configuration";
            listViewGroup3.Header = "Разделение данных";
            listViewGroup3.Name = "SeparationData";
            listViewGroup4.Header = "Распределенная база данных";
            listViewGroup4.Name = "DIB";
            listViewGroup5.Header = "Расширение Simple";
            listViewGroup5.Name = "ExtensionSimple";
            listViewGroup6.Header = "Мобильное приложение";
            listViewGroup6.Name = "MobileApp";
            listViewGroup7.Header = "Компьютер";
            listViewGroup7.Name = "Computer";
            listViewGroup8.Header = "Клиент";
            listViewGroup8.Name = "Client";
            this.LVMain.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.LVMain.HideSelection = false;
            this.LVMain.Location = new System.Drawing.Point(0, 0);
            this.LVMain.Name = "LVMain";
            this.LVMain.Size = new System.Drawing.Size(532, 322);
            this.LVMain.TabIndex = 7;
            this.LVMain.UseCompatibleStateImageBehavior = false;
            this.LVMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 400;
            // 
            // LVSubsystems
            // 
            this.LVSubsystems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.LVSubsystems.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup9.Header = "Подсистемы";
            listViewGroup9.Name = "Subsystems";
            this.LVSubsystems.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9});
            this.LVSubsystems.HideSelection = false;
            this.LVSubsystems.Location = new System.Drawing.Point(0, 0);
            this.LVSubsystems.Name = "LVSubsystems";
            this.LVSubsystems.Size = new System.Drawing.Size(570, 322);
            this.LVSubsystems.TabIndex = 8;
            this.LVSubsystems.UseCompatibleStateImageBehavior = false;
            this.LVSubsystems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Наименование";
            this.columnHeader6.Width = 250;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Версия";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Идентификатор поддержки";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Это конфигурация";
            // 
            // MainMessageGroup
            // 
            this.MainMessageGroup.Controls.Add(this.MainMessageText);
            this.MainMessageGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMessageGroup.Location = new System.Drawing.Point(0, 0);
            this.MainMessageGroup.Name = "MainMessageGroup";
            this.MainMessageGroup.Size = new System.Drawing.Size(1106, 161);
            this.MainMessageGroup.TabIndex = 2;
            this.MainMessageGroup.TabStop = false;
            this.MainMessageGroup.Text = "Сообщение";
            // 
            // MainMessageText
            // 
            this.MainMessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMessageText.Location = new System.Drawing.Point(3, 16);
            this.MainMessageText.Multiline = true;
            this.MainMessageText.Name = "MainMessageText";
            this.MainMessageText.Size = new System.Drawing.Size(1100, 142);
            this.MainMessageText.TabIndex = 1;
            // 
            // PageHTTPLogging
            // 
            this.PageHTTPLogging.Controls.Add(this.HTTPLoggingMainPanel);
            this.PageHTTPLogging.Location = new System.Drawing.Point(4, 22);
            this.PageHTTPLogging.Name = "PageHTTPLogging";
            this.PageHTTPLogging.Padding = new System.Windows.Forms.Padding(3);
            this.PageHTTPLogging.Size = new System.Drawing.Size(1112, 493);
            this.PageHTTPLogging.TabIndex = 1;
            this.PageHTTPLogging.Text = "HTTP логирование";
            this.PageHTTPLogging.UseVisualStyleBackColor = true;
            // 
            // HTTPLoggingMainPanel
            // 
            this.HTTPLoggingMainPanel.ColumnCount = 1;
            this.HTTPLoggingMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HTTPLoggingMainPanel.Controls.Add(this.HTTPLoggingMainContainer, 0, 1);
            this.HTTPLoggingMainPanel.Controls.Add(this.HTTPLoggingSearchStringPanel, 0, 0);
            this.HTTPLoggingMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingMainPanel.Location = new System.Drawing.Point(3, 3);
            this.HTTPLoggingMainPanel.Name = "HTTPLoggingMainPanel";
            this.HTTPLoggingMainPanel.RowCount = 2;
            this.HTTPLoggingMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.HTTPLoggingMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HTTPLoggingMainPanel.Size = new System.Drawing.Size(1106, 487);
            this.HTTPLoggingMainPanel.TabIndex = 3;
            // 
            // HTTPLoggingMainContainer
            // 
            this.HTTPLoggingMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingMainContainer.Location = new System.Drawing.Point(3, 38);
            this.HTTPLoggingMainContainer.Name = "HTTPLoggingMainContainer";
            // 
            // HTTPLoggingMainContainer.Panel1
            // 
            this.HTTPLoggingMainContainer.Panel1.Controls.Add(this.HTTPLoggingTable);
            // 
            // HTTPLoggingMainContainer.Panel2
            // 
            this.HTTPLoggingMainContainer.Panel2.Controls.Add(this.HTTPLoggingContainerRequestResponse);
            this.HTTPLoggingMainContainer.Size = new System.Drawing.Size(1100, 446);
            this.HTTPLoggingMainContainer.SplitterDistance = 614;
            this.HTTPLoggingMainContainer.TabIndex = 2;
            // 
            // HTTPLoggingTable
            // 
            this.HTTPLoggingTable.AllowUserToAddRows = false;
            this.HTTPLoggingTable.AllowUserToDeleteRows = false;
            this.HTTPLoggingTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HTTPLoggingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HTTPLoggingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HTTPLoggingTableSID,
            this.HTTPLoggingTableDate,
            this.HTTPLoggingTableMethod,
            this.HTTPLoggingTableStatusCode,
            this.HTTPLoggingTableDeviceID,
            this.HTTPLoggingTableSession,
            this.HTTPLoggingTableTimestamp,
            this.HTTPLoggingTableURL,
            this.HTTPLoggingTableUserName,
            this.HTTPLoggingTableRequestData,
            this.HTTPLoggingTableResponseData});
            this.HTTPLoggingTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingTable.Location = new System.Drawing.Point(0, 0);
            this.HTTPLoggingTable.Name = "HTTPLoggingTable";
            this.HTTPLoggingTable.ReadOnly = true;
            this.HTTPLoggingTable.Size = new System.Drawing.Size(614, 446);
            this.HTTPLoggingTable.TabIndex = 1;
            this.HTTPLoggingTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.HTTPLoggingTable_RowEnter);
            // 
            // HTTPLoggingTableSID
            // 
            this.HTTPLoggingTableSID.HeaderText = "SID";
            this.HTTPLoggingTableSID.MaxInputLength = 36;
            this.HTTPLoggingTableSID.Name = "HTTPLoggingTableSID";
            this.HTTPLoggingTableSID.ReadOnly = true;
            // 
            // HTTPLoggingTableDate
            // 
            this.HTTPLoggingTableDate.HeaderText = "Дата";
            this.HTTPLoggingTableDate.MaxInputLength = 50;
            this.HTTPLoggingTableDate.Name = "HTTPLoggingTableDate";
            this.HTTPLoggingTableDate.ReadOnly = true;
            // 
            // HTTPLoggingTableMethod
            // 
            this.HTTPLoggingTableMethod.HeaderText = "Метод";
            this.HTTPLoggingTableMethod.MaxInputLength = 20;
            this.HTTPLoggingTableMethod.Name = "HTTPLoggingTableMethod";
            this.HTTPLoggingTableMethod.ReadOnly = true;
            // 
            // HTTPLoggingTableStatusCode
            // 
            this.HTTPLoggingTableStatusCode.HeaderText = "Код состояния";
            this.HTTPLoggingTableStatusCode.MaxInputLength = 5;
            this.HTTPLoggingTableStatusCode.Name = "HTTPLoggingTableStatusCode";
            this.HTTPLoggingTableStatusCode.ReadOnly = true;
            // 
            // HTTPLoggingTableDeviceID
            // 
            this.HTTPLoggingTableDeviceID.HeaderText = "ИД устройства";
            this.HTTPLoggingTableDeviceID.MaxInputLength = 50;
            this.HTTPLoggingTableDeviceID.Name = "HTTPLoggingTableDeviceID";
            this.HTTPLoggingTableDeviceID.ReadOnly = true;
            // 
            // HTTPLoggingTableSession
            // 
            this.HTTPLoggingTableSession.HeaderText = "Сеанс";
            this.HTTPLoggingTableSession.MaxInputLength = 20;
            this.HTTPLoggingTableSession.Name = "HTTPLoggingTableSession";
            this.HTTPLoggingTableSession.ReadOnly = true;
            // 
            // HTTPLoggingTableTimestamp
            // 
            this.HTTPLoggingTableTimestamp.HeaderText = "Метка времени";
            this.HTTPLoggingTableTimestamp.MaxInputLength = 50;
            this.HTTPLoggingTableTimestamp.Name = "HTTPLoggingTableTimestamp";
            this.HTTPLoggingTableTimestamp.ReadOnly = true;
            // 
            // HTTPLoggingTableURL
            // 
            this.HTTPLoggingTableURL.HeaderText = "URL";
            this.HTTPLoggingTableURL.MaxInputLength = 1000;
            this.HTTPLoggingTableURL.Name = "HTTPLoggingTableURL";
            this.HTTPLoggingTableURL.ReadOnly = true;
            // 
            // HTTPLoggingTableUserName
            // 
            this.HTTPLoggingTableUserName.HeaderText = "Пользователь";
            this.HTTPLoggingTableUserName.MaxInputLength = 150;
            this.HTTPLoggingTableUserName.Name = "HTTPLoggingTableUserName";
            this.HTTPLoggingTableUserName.ReadOnly = true;
            // 
            // HTTPLoggingTableRequestData
            // 
            this.HTTPLoggingTableRequestData.HeaderText = "Запрос";
            this.HTTPLoggingTableRequestData.MaxInputLength = 0;
            this.HTTPLoggingTableRequestData.Name = "HTTPLoggingTableRequestData";
            this.HTTPLoggingTableRequestData.ReadOnly = true;
            this.HTTPLoggingTableRequestData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HTTPLoggingTableRequestData.Visible = false;
            // 
            // HTTPLoggingTableResponseData
            // 
            this.HTTPLoggingTableResponseData.HeaderText = "Ответ";
            this.HTTPLoggingTableResponseData.MaxInputLength = 0;
            this.HTTPLoggingTableResponseData.Name = "HTTPLoggingTableResponseData";
            this.HTTPLoggingTableResponseData.ReadOnly = true;
            this.HTTPLoggingTableResponseData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HTTPLoggingTableResponseData.Visible = false;
            // 
            // HTTPLoggingContainerRequestResponse
            // 
            this.HTTPLoggingContainerRequestResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingContainerRequestResponse.Location = new System.Drawing.Point(0, 0);
            this.HTTPLoggingContainerRequestResponse.Name = "HTTPLoggingContainerRequestResponse";
            this.HTTPLoggingContainerRequestResponse.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HTTPLoggingContainerRequestResponse.Panel1
            // 
            this.HTTPLoggingContainerRequestResponse.Panel1.Controls.Add(this.HTTPLoggingGroupRequest);
            // 
            // HTTPLoggingContainerRequestResponse.Panel2
            // 
            this.HTTPLoggingContainerRequestResponse.Panel2.Controls.Add(this.HTTPLoggingGroupResponse);
            this.HTTPLoggingContainerRequestResponse.Size = new System.Drawing.Size(482, 446);
            this.HTTPLoggingContainerRequestResponse.SplitterDistance = 208;
            this.HTTPLoggingContainerRequestResponse.TabIndex = 0;
            // 
            // HTTPLoggingGroupRequest
            // 
            this.HTTPLoggingGroupRequest.Controls.Add(this.HTTPLoggingTextRequest);
            this.HTTPLoggingGroupRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingGroupRequest.Location = new System.Drawing.Point(0, 0);
            this.HTTPLoggingGroupRequest.Name = "HTTPLoggingGroupRequest";
            this.HTTPLoggingGroupRequest.Size = new System.Drawing.Size(482, 208);
            this.HTTPLoggingGroupRequest.TabIndex = 0;
            this.HTTPLoggingGroupRequest.TabStop = false;
            this.HTTPLoggingGroupRequest.Text = "Запрос";
            // 
            // HTTPLoggingTextRequest
            // 
            this.HTTPLoggingTextRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingTextRequest.Location = new System.Drawing.Point(3, 16);
            this.HTTPLoggingTextRequest.MaxLength = 0;
            this.HTTPLoggingTextRequest.Multiline = true;
            this.HTTPLoggingTextRequest.Name = "HTTPLoggingTextRequest";
            this.HTTPLoggingTextRequest.ReadOnly = true;
            this.HTTPLoggingTextRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HTTPLoggingTextRequest.Size = new System.Drawing.Size(476, 189);
            this.HTTPLoggingTextRequest.TabIndex = 0;
            // 
            // HTTPLoggingGroupResponse
            // 
            this.HTTPLoggingGroupResponse.Controls.Add(this.HTTPLoggingTextResponse);
            this.HTTPLoggingGroupResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingGroupResponse.Location = new System.Drawing.Point(0, 0);
            this.HTTPLoggingGroupResponse.Name = "HTTPLoggingGroupResponse";
            this.HTTPLoggingGroupResponse.Size = new System.Drawing.Size(482, 234);
            this.HTTPLoggingGroupResponse.TabIndex = 0;
            this.HTTPLoggingGroupResponse.TabStop = false;
            this.HTTPLoggingGroupResponse.Text = "Ответ";
            // 
            // HTTPLoggingTextResponse
            // 
            this.HTTPLoggingTextResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPLoggingTextResponse.Location = new System.Drawing.Point(3, 16);
            this.HTTPLoggingTextResponse.MaxLength = 0;
            this.HTTPLoggingTextResponse.Multiline = true;
            this.HTTPLoggingTextResponse.Name = "HTTPLoggingTextResponse";
            this.HTTPLoggingTextResponse.ReadOnly = true;
            this.HTTPLoggingTextResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HTTPLoggingTextResponse.Size = new System.Drawing.Size(476, 215);
            this.HTTPLoggingTextResponse.TabIndex = 0;
            // 
            // HTTPLoggingSearchStringPanel
            // 
            this.HTTPLoggingSearchStringPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HTTPLoggingSearchStringPanel.Controls.Add(this.HTTPLoggingSearchStringLabel);
            this.HTTPLoggingSearchStringPanel.Controls.Add(this.HTTPLoggingSearchStringText);
            this.HTTPLoggingSearchStringPanel.Location = new System.Drawing.Point(3, 3);
            this.HTTPLoggingSearchStringPanel.Name = "HTTPLoggingSearchStringPanel";
            this.HTTPLoggingSearchStringPanel.Size = new System.Drawing.Size(283, 29);
            this.HTTPLoggingSearchStringPanel.TabIndex = 3;
            // 
            // HTTPLoggingSearchStringLabel
            // 
            this.HTTPLoggingSearchStringLabel.AutoSize = true;
            this.HTTPLoggingSearchStringLabel.Location = new System.Drawing.Point(3, 6);
            this.HTTPLoggingSearchStringLabel.Name = "HTTPLoggingSearchStringLabel";
            this.HTTPLoggingSearchStringLabel.Size = new System.Drawing.Size(42, 13);
            this.HTTPLoggingSearchStringLabel.TabIndex = 1;
            this.HTTPLoggingSearchStringLabel.Text = "Поиск:";
            // 
            // HTTPLoggingSearchStringText
            // 
            this.HTTPLoggingSearchStringText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HTTPLoggingSearchStringText.Location = new System.Drawing.Point(51, 3);
            this.HTTPLoggingSearchStringText.Name = "HTTPLoggingSearchStringText";
            this.HTTPLoggingSearchStringText.Size = new System.Drawing.Size(229, 20);
            this.HTTPLoggingSearchStringText.TabIndex = 0;
            this.HTTPLoggingSearchStringText.TextChanged += new System.EventHandler(this.HTTPLoggingSearchStringText_TextChanged);
            // 
            // PageRegistrationLog
            // 
            this.PageRegistrationLog.Controls.Add(this.RLMainPanel);
            this.PageRegistrationLog.Location = new System.Drawing.Point(4, 22);
            this.PageRegistrationLog.Name = "PageRegistrationLog";
            this.PageRegistrationLog.Padding = new System.Windows.Forms.Padding(3);
            this.PageRegistrationLog.Size = new System.Drawing.Size(1112, 493);
            this.PageRegistrationLog.TabIndex = 2;
            this.PageRegistrationLog.Text = "Журнал регистрации";
            this.PageRegistrationLog.UseVisualStyleBackColor = true;
            // 
            // RLMainPanel
            // 
            this.RLMainPanel.ColumnCount = 1;
            this.RLMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RLMainPanel.Controls.Add(this.RLContainer, 0, 1);
            this.RLMainPanel.Controls.Add(this.RLSearchPanel, 0, 0);
            this.RLMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RLMainPanel.Location = new System.Drawing.Point(3, 3);
            this.RLMainPanel.Name = "RLMainPanel";
            this.RLMainPanel.RowCount = 2;
            this.RLMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.RLMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RLMainPanel.Size = new System.Drawing.Size(1106, 487);
            this.RLMainPanel.TabIndex = 0;
            // 
            // RLContainer
            // 
            this.RLContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RLContainer.Location = new System.Drawing.Point(3, 38);
            this.RLContainer.Name = "RLContainer";
            // 
            // RLContainer.Panel1
            // 
            this.RLContainer.Panel1.Controls.Add(this.RLTable);
            // 
            // RLContainer.Panel2
            // 
            this.RLContainer.Panel2.Controls.Add(this.RLCommentText);
            this.RLContainer.Size = new System.Drawing.Size(1100, 446);
            this.RLContainer.SplitterDistance = 648;
            this.RLContainer.TabIndex = 0;
            // 
            // RLTable
            // 
            this.RLTable.AllowUserToAddRows = false;
            this.RLTable.AllowUserToDeleteRows = false;
            this.RLTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RLTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RLTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RLTableDate,
            this.RLTableLevel,
            this.RLTableEventView,
            this.RLTableMetadataView,
            this.RLTableConnectUserName,
            this.RLTableConnectSession,
            this.RLTableConnectAppView,
            this.RLTableConnectComputer,
            this.RLTableDateSever,
            this.RLTableConnectServer,
            this.RLTableConnectPortMain,
            this.RLTableConnectConnection,
            this.RLTableDataSeparationView,
            this.RLTableTransactionName,
            this.RLTableTransactionStatus,
            this.RLTableDataData,
            this.RLTableDataComment});
            this.RLTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RLTable.Location = new System.Drawing.Point(0, 0);
            this.RLTable.MultiSelect = false;
            this.RLTable.Name = "RLTable";
            this.RLTable.ReadOnly = true;
            this.RLTable.Size = new System.Drawing.Size(648, 446);
            this.RLTable.TabIndex = 0;
            this.RLTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RLTable_RowEnter);
            // 
            // RLTableDate
            // 
            this.RLTableDate.HeaderText = "Дата";
            this.RLTableDate.MaxInputLength = 50;
            this.RLTableDate.Name = "RLTableDate";
            this.RLTableDate.ReadOnly = true;
            // 
            // RLTableLevel
            // 
            this.RLTableLevel.HeaderText = "Уровень";
            this.RLTableLevel.MaxInputLength = 50;
            this.RLTableLevel.Name = "RLTableLevel";
            this.RLTableLevel.ReadOnly = true;
            // 
            // RLTableEventView
            // 
            this.RLTableEventView.HeaderText = "Событие";
            this.RLTableEventView.MaxInputLength = 500;
            this.RLTableEventView.Name = "RLTableEventView";
            this.RLTableEventView.ReadOnly = true;
            // 
            // RLTableMetadataView
            // 
            this.RLTableMetadataView.HeaderText = "Метаданные";
            this.RLTableMetadataView.MaxInputLength = 500;
            this.RLTableMetadataView.Name = "RLTableMetadataView";
            this.RLTableMetadataView.ReadOnly = true;
            // 
            // RLTableConnectUserName
            // 
            this.RLTableConnectUserName.HeaderText = "Пользователь";
            this.RLTableConnectUserName.MaxInputLength = 150;
            this.RLTableConnectUserName.Name = "RLTableConnectUserName";
            this.RLTableConnectUserName.ReadOnly = true;
            // 
            // RLTableConnectSession
            // 
            this.RLTableConnectSession.HeaderText = "Сеанс";
            this.RLTableConnectSession.MaxInputLength = 20;
            this.RLTableConnectSession.Name = "RLTableConnectSession";
            this.RLTableConnectSession.ReadOnly = true;
            // 
            // RLTableConnectAppView
            // 
            this.RLTableConnectAppView.HeaderText = "Приложение";
            this.RLTableConnectAppView.MaxInputLength = 200;
            this.RLTableConnectAppView.Name = "RLTableConnectAppView";
            this.RLTableConnectAppView.ReadOnly = true;
            // 
            // RLTableConnectComputer
            // 
            this.RLTableConnectComputer.HeaderText = "Компьютер";
            this.RLTableConnectComputer.MaxInputLength = 200;
            this.RLTableConnectComputer.Name = "RLTableConnectComputer";
            this.RLTableConnectComputer.ReadOnly = true;
            // 
            // RLTableDateSever
            // 
            this.RLTableDateSever.HeaderText = "Дата сервера";
            this.RLTableDateSever.MaxInputLength = 50;
            this.RLTableDateSever.Name = "RLTableDateSever";
            this.RLTableDateSever.ReadOnly = true;
            // 
            // RLTableConnectServer
            // 
            this.RLTableConnectServer.HeaderText = "Сервер";
            this.RLTableConnectServer.MaxInputLength = 200;
            this.RLTableConnectServer.Name = "RLTableConnectServer";
            this.RLTableConnectServer.ReadOnly = true;
            // 
            // RLTableConnectPortMain
            // 
            this.RLTableConnectPortMain.HeaderText = "Порт";
            this.RLTableConnectPortMain.MaxInputLength = 10;
            this.RLTableConnectPortMain.Name = "RLTableConnectPortMain";
            this.RLTableConnectPortMain.ReadOnly = true;
            // 
            // RLTableConnectConnection
            // 
            this.RLTableConnectConnection.HeaderText = "Соединение";
            this.RLTableConnectConnection.MaxInputLength = 50;
            this.RLTableConnectConnection.Name = "RLTableConnectConnection";
            this.RLTableConnectConnection.ReadOnly = true;
            // 
            // RLTableDataSeparationView
            // 
            this.RLTableDataSeparationView.HeaderText = "Разделение данных";
            this.RLTableDataSeparationView.MaxInputLength = 200;
            this.RLTableDataSeparationView.Name = "RLTableDataSeparationView";
            this.RLTableDataSeparationView.ReadOnly = true;
            // 
            // RLTableTransactionName
            // 
            this.RLTableTransactionName.HeaderText = "Транзакция";
            this.RLTableTransactionName.MaxInputLength = 100;
            this.RLTableTransactionName.Name = "RLTableTransactionName";
            this.RLTableTransactionName.ReadOnly = true;
            // 
            // RLTableTransactionStatus
            // 
            this.RLTableTransactionStatus.HeaderText = "Статус транзакции";
            this.RLTableTransactionStatus.Name = "RLTableTransactionStatus";
            this.RLTableTransactionStatus.ReadOnly = true;
            // 
            // RLTableDataData
            // 
            this.RLTableDataData.HeaderText = "Данные";
            this.RLTableDataData.Name = "RLTableDataData";
            this.RLTableDataData.ReadOnly = true;
            // 
            // RLTableDataComment
            // 
            this.RLTableDataComment.HeaderText = "Комментарий";
            this.RLTableDataComment.MaxInputLength = 0;
            this.RLTableDataComment.Name = "RLTableDataComment";
            this.RLTableDataComment.ReadOnly = true;
            this.RLTableDataComment.Visible = false;
            // 
            // RLCommentText
            // 
            this.RLCommentText.AcceptsReturn = true;
            this.RLCommentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RLCommentText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RLCommentText.Location = new System.Drawing.Point(0, 0);
            this.RLCommentText.MaxLength = 0;
            this.RLCommentText.Multiline = true;
            this.RLCommentText.Name = "RLCommentText";
            this.RLCommentText.ReadOnly = true;
            this.RLCommentText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RLCommentText.Size = new System.Drawing.Size(448, 446);
            this.RLCommentText.TabIndex = 0;
            // 
            // RLSearchPanel
            // 
            this.RLSearchPanel.Controls.Add(this.RLSearchLabel);
            this.RLSearchPanel.Controls.Add(this.RLSearchText);
            this.RLSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.RLSearchPanel.Name = "RLSearchPanel";
            this.RLSearchPanel.Size = new System.Drawing.Size(283, 28);
            this.RLSearchPanel.TabIndex = 1;
            // 
            // RLSearchLabel
            // 
            this.RLSearchLabel.AutoSize = true;
            this.RLSearchLabel.Location = new System.Drawing.Point(2, 6);
            this.RLSearchLabel.Name = "RLSearchLabel";
            this.RLSearchLabel.Size = new System.Drawing.Size(42, 13);
            this.RLSearchLabel.TabIndex = 1;
            this.RLSearchLabel.Text = "Поиск:";
            // 
            // RLSearchText
            // 
            this.RLSearchText.AccessibleDescription = "";
            this.RLSearchText.AccessibleName = "";
            this.RLSearchText.Location = new System.Drawing.Point(50, 3);
            this.RLSearchText.Name = "RLSearchText";
            this.RLSearchText.Size = new System.Drawing.Size(230, 20);
            this.RLSearchText.TabIndex = 0;
            this.RLSearchText.TextChanged += new System.EventHandler(this.RLSearchText_TextChanged);
            // 
            // PageAttachments
            // 
            this.PageAttachments.Controls.Add(this.AttachmentMainPanel);
            this.PageAttachments.Location = new System.Drawing.Point(4, 22);
            this.PageAttachments.Name = "PageAttachments";
            this.PageAttachments.Padding = new System.Windows.Forms.Padding(3);
            this.PageAttachments.Size = new System.Drawing.Size(1112, 493);
            this.PageAttachments.TabIndex = 3;
            this.PageAttachments.Text = "Вложения";
            this.PageAttachments.UseVisualStyleBackColor = true;
            // 
            // AttachmentMainPanel
            // 
            this.AttachmentMainPanel.ColumnCount = 1;
            this.AttachmentMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AttachmentMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AttachmentMainPanel.Controls.Add(this.AttachmentContainer, 0, 1);
            this.AttachmentMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachmentMainPanel.Location = new System.Drawing.Point(3, 3);
            this.AttachmentMainPanel.Name = "AttachmentMainPanel";
            this.AttachmentMainPanel.RowCount = 2;
            this.AttachmentMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.AttachmentMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AttachmentMainPanel.Size = new System.Drawing.Size(1106, 487);
            this.AttachmentMainPanel.TabIndex = 0;
            // 
            // AttachmentContainer
            // 
            this.AttachmentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachmentContainer.Location = new System.Drawing.Point(3, 38);
            this.AttachmentContainer.Name = "AttachmentContainer";
            // 
            // AttachmentContainer.Panel1
            // 
            this.AttachmentContainer.Panel1.Controls.Add(this.AttachmentTable);
            // 
            // AttachmentContainer.Panel2
            // 
            this.AttachmentContainer.Panel2.Controls.Add(this.AttachmentPicturePrewiew);
            this.AttachmentContainer.Size = new System.Drawing.Size(1100, 446);
            this.AttachmentContainer.SplitterDistance = 517;
            this.AttachmentContainer.TabIndex = 0;
            // 
            // AttachmentTable
            // 
            this.AttachmentTable.AllowUserToAddRows = false;
            this.AttachmentTable.AllowUserToDeleteRows = false;
            this.AttachmentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttachmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttachmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttachmentTableName,
            this.AttachmentTableView,
            this.AttachmentTableDescription,
            this.AttachmentTableFilePath,
            this.AttachmentTableFileExtension,
            this.AttachmentTableFileFullPath});
            this.AttachmentTable.ContextMenuStrip = this.AttachmentMenu;
            this.AttachmentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachmentTable.Location = new System.Drawing.Point(0, 0);
            this.AttachmentTable.MultiSelect = false;
            this.AttachmentTable.Name = "AttachmentTable";
            this.AttachmentTable.ReadOnly = true;
            this.AttachmentTable.Size = new System.Drawing.Size(517, 446);
            this.AttachmentTable.TabIndex = 0;
            this.AttachmentTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttachmentTable_RowEnter);
            // 
            // AttachmentTableName
            // 
            this.AttachmentTableName.HeaderText = "Имя";
            this.AttachmentTableName.MaxInputLength = 1000;
            this.AttachmentTableName.Name = "AttachmentTableName";
            this.AttachmentTableName.ReadOnly = true;
            // 
            // AttachmentTableView
            // 
            this.AttachmentTableView.HeaderText = "Представление";
            this.AttachmentTableView.MaxInputLength = 200;
            this.AttachmentTableView.Name = "AttachmentTableView";
            this.AttachmentTableView.ReadOnly = true;
            // 
            // AttachmentTableDescription
            // 
            this.AttachmentTableDescription.HeaderText = "Описание";
            this.AttachmentTableDescription.MaxInputLength = 1000;
            this.AttachmentTableDescription.Name = "AttachmentTableDescription";
            this.AttachmentTableDescription.ReadOnly = true;
            // 
            // AttachmentTableFilePath
            // 
            this.AttachmentTableFilePath.HeaderText = "Path";
            this.AttachmentTableFilePath.MaxInputLength = 1000;
            this.AttachmentTableFilePath.Name = "AttachmentTableFilePath";
            this.AttachmentTableFilePath.ReadOnly = true;
            this.AttachmentTableFilePath.Visible = false;
            // 
            // AttachmentTableFileExtension
            // 
            this.AttachmentTableFileExtension.HeaderText = "Extension";
            this.AttachmentTableFileExtension.MaxInputLength = 50;
            this.AttachmentTableFileExtension.Name = "AttachmentTableFileExtension";
            this.AttachmentTableFileExtension.ReadOnly = true;
            this.AttachmentTableFileExtension.Visible = false;
            // 
            // AttachmentTableFileFullPath
            // 
            this.AttachmentTableFileFullPath.HeaderText = "Full path";
            this.AttachmentTableFileFullPath.Name = "AttachmentTableFileFullPath";
            this.AttachmentTableFileFullPath.ReadOnly = true;
            this.AttachmentTableFileFullPath.Visible = false;
            // 
            // AttachmentMenu
            // 
            this.AttachmentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AttachmentMenuSave});
            this.AttachmentMenu.Name = "AttachmentMenu";
            this.AttachmentMenu.Size = new System.Drawing.Size(134, 26);
            // 
            // AttachmentMenuSave
            // 
            this.AttachmentMenuSave.Name = "AttachmentMenuSave";
            this.AttachmentMenuSave.Size = new System.Drawing.Size(133, 22);
            this.AttachmentMenuSave.Text = "Сохранить";
            this.AttachmentMenuSave.Click += new System.EventHandler(this.AttachmentMenuSave_Click);
            // 
            // AttachmentPicturePrewiew
            // 
            this.AttachmentPicturePrewiew.ContextMenuStrip = this.AttachmentMenu;
            this.AttachmentPicturePrewiew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachmentPicturePrewiew.Location = new System.Drawing.Point(0, 0);
            this.AttachmentPicturePrewiew.Name = "AttachmentPicturePrewiew";
            this.AttachmentPicturePrewiew.Size = new System.Drawing.Size(579, 446);
            this.AttachmentPicturePrewiew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttachmentPicturePrewiew.TabIndex = 0;
            this.AttachmentPicturePrewiew.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 543);
            this.Controls.Add(this.PagesMain);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Simple: Technical Support Assistant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.PagesMain.ResumeLayout(false);
            this.PageMain.ResumeLayout(false);
            this.MainContainer1.Panel1.ResumeLayout(false);
            this.MainContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer1)).EndInit();
            this.MainContainer1.ResumeLayout(false);
            this.MainContainer2.Panel1.ResumeLayout(false);
            this.MainContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer2)).EndInit();
            this.MainContainer2.ResumeLayout(false);
            this.MainMessageGroup.ResumeLayout(false);
            this.MainMessageGroup.PerformLayout();
            this.PageHTTPLogging.ResumeLayout(false);
            this.HTTPLoggingMainPanel.ResumeLayout(false);
            this.HTTPLoggingMainContainer.Panel1.ResumeLayout(false);
            this.HTTPLoggingMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HTTPLoggingMainContainer)).EndInit();
            this.HTTPLoggingMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HTTPLoggingTable)).EndInit();
            this.HTTPLoggingContainerRequestResponse.Panel1.ResumeLayout(false);
            this.HTTPLoggingContainerRequestResponse.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HTTPLoggingContainerRequestResponse)).EndInit();
            this.HTTPLoggingContainerRequestResponse.ResumeLayout(false);
            this.HTTPLoggingGroupRequest.ResumeLayout(false);
            this.HTTPLoggingGroupRequest.PerformLayout();
            this.HTTPLoggingGroupResponse.ResumeLayout(false);
            this.HTTPLoggingGroupResponse.PerformLayout();
            this.HTTPLoggingSearchStringPanel.ResumeLayout(false);
            this.HTTPLoggingSearchStringPanel.PerformLayout();
            this.PageRegistrationLog.ResumeLayout(false);
            this.RLMainPanel.ResumeLayout(false);
            this.RLContainer.Panel1.ResumeLayout(false);
            this.RLContainer.Panel2.ResumeLayout(false);
            this.RLContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RLContainer)).EndInit();
            this.RLContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RLTable)).EndInit();
            this.RLSearchPanel.ResumeLayout(false);
            this.RLSearchPanel.PerformLayout();
            this.PageAttachments.ResumeLayout(false);
            this.AttachmentMainPanel.ResumeLayout(false);
            this.AttachmentContainer.Panel1.ResumeLayout(false);
            this.AttachmentContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentContainer)).EndInit();
            this.AttachmentContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentTable)).EndInit();
            this.AttachmentMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentPicturePrewiew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl PagesMain;
        private System.Windows.Forms.TabPage PageMain;
        private System.Windows.Forms.TabPage PageHTTPLogging;
        private System.Windows.Forms.TabPage PageRegistrationLog;
        private System.Windows.Forms.TabPage PageAttachments;
        private System.Windows.Forms.DataGridView HTTPLoggingTable;
        private System.Windows.Forms.SplitContainer HTTPLoggingMainContainer;
        private System.Windows.Forms.SplitContainer HTTPLoggingContainerRequestResponse;
        private System.Windows.Forms.TableLayoutPanel HTTPLoggingMainPanel;
        private System.Windows.Forms.GroupBox HTTPLoggingGroupRequest;
        private System.Windows.Forms.TextBox HTTPLoggingTextRequest;
        private System.Windows.Forms.GroupBox HTTPLoggingGroupResponse;
        private System.Windows.Forms.TextBox HTTPLoggingTextResponse;
        private System.Windows.Forms.Panel HTTPLoggingSearchStringPanel;
        private System.Windows.Forms.Label HTTPLoggingSearchStringLabel;
        private System.Windows.Forms.TextBox HTTPLoggingSearchStringText;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel RLMainPanel;
        private System.Windows.Forms.SplitContainer RLContainer;
        private System.Windows.Forms.Panel RLSearchPanel;
        private System.Windows.Forms.Label RLSearchLabel;
        private System.Windows.Forms.TextBox RLSearchText;
        private System.Windows.Forms.TextBox RLCommentText;
        private System.Windows.Forms.DataGridView RLTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDateServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableMetadata;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTablePortMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableAppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDataSeparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableComment;
        private System.Windows.Forms.TableLayoutPanel AttachmentMainPanel;
        private System.Windows.Forms.SplitContainer AttachmentContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableStatusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableDeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableRequestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTPLoggingTableResponseData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableEventView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableMetadataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectAppView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDateSever;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectPortMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableConnectConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDataSeparationView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableTransactionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableTransactionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDataData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLTableDataComment;
        private System.Windows.Forms.DataGridView AttachmentTable;
        private System.Windows.Forms.PictureBox AttachmentPicturePrewiew;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentTableDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentTableFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentTableFileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentTableFileFullPath;
        private System.Windows.Forms.ContextMenuStrip AttachmentMenu;
        private System.Windows.Forms.ToolStripMenuItem AttachmentMenuSave;
        private System.Windows.Forms.SaveFileDialog AttachmentSaveDialog;
        private System.Windows.Forms.ListView LVMain;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView LVSubsystems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.SplitContainer MainContainer1;
        private System.Windows.Forms.GroupBox MainMessageGroup;
        private System.Windows.Forms.TextBox MainMessageText;
        private System.Windows.Forms.SplitContainer MainContainer2;
    }
}

