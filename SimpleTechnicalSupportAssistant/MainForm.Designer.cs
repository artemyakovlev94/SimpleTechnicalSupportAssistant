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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обращениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логированиеHTTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageHTTPLogging = new System.Windows.Forms.TabPage();
            this.splitContainerHTTPLogging = new System.Windows.Forms.SplitContainer();
            this.dgwHTTPLogging = new System.Windows.Forms.DataGridView();
            this.dgwHTTPLoggingSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingStatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingDeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingRequestData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwHTTPLoggingResponseData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_RegistrationLog = new System.Windows.Forms.TabPage();
            this.tabPage_Attachments = new System.Windows.Forms.TabPage();
            this.splitContainerHTTPLogging2 = new System.Windows.Forms.SplitContainer();
            this.tlpHTTPLogging = new System.Windows.Forms.TableLayoutPanel();
            this.gbHTTPLoggingRequest = new System.Windows.Forms.GroupBox();
            this.gbHTTPLogging = new System.Windows.Forms.GroupBox();
            this.tbHTTPLoggingRequest = new System.Windows.Forms.TextBox();
            this.tbHTTPLoggingResponse = new System.Windows.Forms.TextBox();
            this.panelHTTPLoggingSearch = new System.Windows.Forms.Panel();
            this.tbHTTPLoggingSearch = new System.Windows.Forms.TextBox();
            this.labelHTTPLoggingSearch = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageHTTPLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHTTPLogging)).BeginInit();
            this.splitContainerHTTPLogging.Panel1.SuspendLayout();
            this.splitContainerHTTPLogging.Panel2.SuspendLayout();
            this.splitContainerHTTPLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHTTPLogging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHTTPLogging2)).BeginInit();
            this.splitContainerHTTPLogging2.Panel1.SuspendLayout();
            this.splitContainerHTTPLogging2.Panel2.SuspendLayout();
            this.splitContainerHTTPLogging2.SuspendLayout();
            this.tlpHTTPLogging.SuspendLayout();
            this.gbHTTPLoggingRequest.SuspendLayout();
            this.gbHTTPLogging.SuspendLayout();
            this.panelHTTPLoggingSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(800, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обращениеToolStripMenuItem,
            this.логированиеHTTPToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // обращениеToolStripMenuItem
            // 
            this.обращениеToolStripMenuItem.Name = "обращениеToolStripMenuItem";
            this.обращениеToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.обращениеToolStripMenuItem.Text = "Обращение";
            this.обращениеToolStripMenuItem.Click += new System.EventHandler(this.обращениеToolStripMenuItem_Click);
            // 
            // логированиеHTTPToolStripMenuItem
            // 
            this.логированиеHTTPToolStripMenuItem.Name = "логированиеHTTPToolStripMenuItem";
            this.логированиеHTTPToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.логированиеHTTPToolStripMenuItem.Text = "Логирование HTTP";
            this.логированиеHTTPToolStripMenuItem.Click += new System.EventHandler(this.логированиеHTTPToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файл архива (*.zip)|*.zip|All files(*.*)|*.*";
            this.openFileDialog.Title = "Выберите файл";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageHTTPLogging);
            this.tabControlMain.Controls.Add(this.tabPage_RegistrationLog);
            this.tabControlMain.Controls.Add(this.tabPage_Attachments);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 426);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(792, 400);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Основное";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageHTTPLogging
            // 
            this.tabPageHTTPLogging.Controls.Add(this.tlpHTTPLogging);
            this.tabPageHTTPLogging.Location = new System.Drawing.Point(4, 22);
            this.tabPageHTTPLogging.Name = "tabPageHTTPLogging";
            this.tabPageHTTPLogging.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTTPLogging.Size = new System.Drawing.Size(792, 400);
            this.tabPageHTTPLogging.TabIndex = 1;
            this.tabPageHTTPLogging.Text = "HTTP логирование";
            this.tabPageHTTPLogging.UseVisualStyleBackColor = true;
            // 
            // splitContainerHTTPLogging
            // 
            this.splitContainerHTTPLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHTTPLogging.Location = new System.Drawing.Point(3, 38);
            this.splitContainerHTTPLogging.Name = "splitContainerHTTPLogging";
            // 
            // splitContainerHTTPLogging.Panel1
            // 
            this.splitContainerHTTPLogging.Panel1.Controls.Add(this.dgwHTTPLogging);
            // 
            // splitContainerHTTPLogging.Panel2
            // 
            this.splitContainerHTTPLogging.Panel2.Controls.Add(this.splitContainerHTTPLogging2);
            this.splitContainerHTTPLogging.Size = new System.Drawing.Size(780, 353);
            this.splitContainerHTTPLogging.SplitterDistance = 436;
            this.splitContainerHTTPLogging.TabIndex = 2;
            // 
            // dgwHTTPLogging
            // 
            this.dgwHTTPLogging.AllowUserToAddRows = false;
            this.dgwHTTPLogging.AllowUserToDeleteRows = false;
            this.dgwHTTPLogging.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHTTPLogging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHTTPLogging.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgwHTTPLoggingSID,
            this.dgwHTTPLoggingDate,
            this.dgwHTTPLoggingMethod,
            this.dgwHTTPLoggingStatusCode,
            this.dgwHTTPLoggingDeviceID,
            this.dgwHTTPLoggingSession,
            this.dgwHTTPLoggingTimestamp,
            this.dgwHTTPLoggingURL,
            this.dgwHTTPLoggingUserName,
            this.dgwHTTPLoggingRequestData,
            this.dgwHTTPLoggingResponseData});
            this.dgwHTTPLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwHTTPLogging.Location = new System.Drawing.Point(0, 0);
            this.dgwHTTPLogging.Name = "dgwHTTPLogging";
            this.dgwHTTPLogging.ReadOnly = true;
            this.dgwHTTPLogging.Size = new System.Drawing.Size(436, 353);
            this.dgwHTTPLogging.TabIndex = 1;
            this.dgwHTTPLogging.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHTTPLogging_CellEnter);
            // 
            // dgwHTTPLoggingSID
            // 
            this.dgwHTTPLoggingSID.HeaderText = "SID";
            this.dgwHTTPLoggingSID.Name = "dgwHTTPLoggingSID";
            this.dgwHTTPLoggingSID.ReadOnly = true;
            // 
            // dgwHTTPLoggingDate
            // 
            this.dgwHTTPLoggingDate.HeaderText = "Дата";
            this.dgwHTTPLoggingDate.Name = "dgwHTTPLoggingDate";
            this.dgwHTTPLoggingDate.ReadOnly = true;
            // 
            // dgwHTTPLoggingMethod
            // 
            this.dgwHTTPLoggingMethod.HeaderText = "Метод";
            this.dgwHTTPLoggingMethod.Name = "dgwHTTPLoggingMethod";
            this.dgwHTTPLoggingMethod.ReadOnly = true;
            // 
            // dgwHTTPLoggingStatusCode
            // 
            this.dgwHTTPLoggingStatusCode.HeaderText = "Код состояния";
            this.dgwHTTPLoggingStatusCode.Name = "dgwHTTPLoggingStatusCode";
            this.dgwHTTPLoggingStatusCode.ReadOnly = true;
            // 
            // dgwHTTPLoggingDeviceID
            // 
            this.dgwHTTPLoggingDeviceID.HeaderText = "ИД устройства";
            this.dgwHTTPLoggingDeviceID.Name = "dgwHTTPLoggingDeviceID";
            this.dgwHTTPLoggingDeviceID.ReadOnly = true;
            // 
            // dgwHTTPLoggingSession
            // 
            this.dgwHTTPLoggingSession.HeaderText = "Сеанс";
            this.dgwHTTPLoggingSession.Name = "dgwHTTPLoggingSession";
            this.dgwHTTPLoggingSession.ReadOnly = true;
            // 
            // dgwHTTPLoggingTimestamp
            // 
            this.dgwHTTPLoggingTimestamp.HeaderText = "Метка времени";
            this.dgwHTTPLoggingTimestamp.Name = "dgwHTTPLoggingTimestamp";
            this.dgwHTTPLoggingTimestamp.ReadOnly = true;
            // 
            // dgwHTTPLoggingURL
            // 
            this.dgwHTTPLoggingURL.HeaderText = "URL";
            this.dgwHTTPLoggingURL.Name = "dgwHTTPLoggingURL";
            this.dgwHTTPLoggingURL.ReadOnly = true;
            // 
            // dgwHTTPLoggingUserName
            // 
            this.dgwHTTPLoggingUserName.HeaderText = "Пользователь";
            this.dgwHTTPLoggingUserName.Name = "dgwHTTPLoggingUserName";
            this.dgwHTTPLoggingUserName.ReadOnly = true;
            // 
            // dgwHTTPLoggingRequestData
            // 
            this.dgwHTTPLoggingRequestData.HeaderText = "Запрос";
            this.dgwHTTPLoggingRequestData.Name = "dgwHTTPLoggingRequestData";
            this.dgwHTTPLoggingRequestData.ReadOnly = true;
            this.dgwHTTPLoggingRequestData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgwHTTPLoggingResponseData
            // 
            this.dgwHTTPLoggingResponseData.HeaderText = "Ответ";
            this.dgwHTTPLoggingResponseData.Name = "dgwHTTPLoggingResponseData";
            this.dgwHTTPLoggingResponseData.ReadOnly = true;
            this.dgwHTTPLoggingResponseData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage_RegistrationLog
            // 
            this.tabPage_RegistrationLog.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RegistrationLog.Name = "tabPage_RegistrationLog";
            this.tabPage_RegistrationLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RegistrationLog.Size = new System.Drawing.Size(792, 400);
            this.tabPage_RegistrationLog.TabIndex = 2;
            this.tabPage_RegistrationLog.Text = "Журнал регистрации";
            this.tabPage_RegistrationLog.UseVisualStyleBackColor = true;
            // 
            // tabPage_Attachments
            // 
            this.tabPage_Attachments.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Attachments.Name = "tabPage_Attachments";
            this.tabPage_Attachments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Attachments.Size = new System.Drawing.Size(792, 400);
            this.tabPage_Attachments.TabIndex = 3;
            this.tabPage_Attachments.Text = "Вложения";
            this.tabPage_Attachments.UseVisualStyleBackColor = true;
            // 
            // splitContainerHTTPLogging2
            // 
            this.splitContainerHTTPLogging2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHTTPLogging2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHTTPLogging2.Name = "splitContainerHTTPLogging2";
            this.splitContainerHTTPLogging2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHTTPLogging2.Panel1
            // 
            this.splitContainerHTTPLogging2.Panel1.Controls.Add(this.gbHTTPLoggingRequest);
            // 
            // splitContainerHTTPLogging2.Panel2
            // 
            this.splitContainerHTTPLogging2.Panel2.Controls.Add(this.gbHTTPLogging);
            this.splitContainerHTTPLogging2.Size = new System.Drawing.Size(340, 353);
            this.splitContainerHTTPLogging2.SplitterDistance = 165;
            this.splitContainerHTTPLogging2.TabIndex = 0;
            // 
            // tlpHTTPLogging
            // 
            this.tlpHTTPLogging.ColumnCount = 1;
            this.tlpHTTPLogging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHTTPLogging.Controls.Add(this.splitContainerHTTPLogging, 0, 1);
            this.tlpHTTPLogging.Controls.Add(this.panelHTTPLoggingSearch, 0, 0);
            this.tlpHTTPLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHTTPLogging.Location = new System.Drawing.Point(3, 3);
            this.tlpHTTPLogging.Name = "tlpHTTPLogging";
            this.tlpHTTPLogging.RowCount = 2;
            this.tlpHTTPLogging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpHTTPLogging.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHTTPLogging.Size = new System.Drawing.Size(786, 394);
            this.tlpHTTPLogging.TabIndex = 3;
            // 
            // gbHTTPLoggingRequest
            // 
            this.gbHTTPLoggingRequest.Controls.Add(this.tbHTTPLoggingRequest);
            this.gbHTTPLoggingRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHTTPLoggingRequest.Location = new System.Drawing.Point(0, 0);
            this.gbHTTPLoggingRequest.Name = "gbHTTPLoggingRequest";
            this.gbHTTPLoggingRequest.Size = new System.Drawing.Size(340, 165);
            this.gbHTTPLoggingRequest.TabIndex = 0;
            this.gbHTTPLoggingRequest.TabStop = false;
            this.gbHTTPLoggingRequest.Text = "Запрос";
            // 
            // gbHTTPLogging
            // 
            this.gbHTTPLogging.Controls.Add(this.tbHTTPLoggingResponse);
            this.gbHTTPLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHTTPLogging.Location = new System.Drawing.Point(0, 0);
            this.gbHTTPLogging.Name = "gbHTTPLogging";
            this.gbHTTPLogging.Size = new System.Drawing.Size(340, 184);
            this.gbHTTPLogging.TabIndex = 0;
            this.gbHTTPLogging.TabStop = false;
            this.gbHTTPLogging.Text = "Ответ";
            // 
            // tbHTTPLoggingRequest
            // 
            this.tbHTTPLoggingRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHTTPLoggingRequest.Location = new System.Drawing.Point(3, 16);
            this.tbHTTPLoggingRequest.MaxLength = 1000000;
            this.tbHTTPLoggingRequest.Multiline = true;
            this.tbHTTPLoggingRequest.Name = "tbHTTPLoggingRequest";
            this.tbHTTPLoggingRequest.ReadOnly = true;
            this.tbHTTPLoggingRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbHTTPLoggingRequest.Size = new System.Drawing.Size(334, 146);
            this.tbHTTPLoggingRequest.TabIndex = 0;
            // 
            // tbHTTPLoggingResponse
            // 
            this.tbHTTPLoggingResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHTTPLoggingResponse.Location = new System.Drawing.Point(3, 16);
            this.tbHTTPLoggingResponse.MaxLength = 1000000;
            this.tbHTTPLoggingResponse.Multiline = true;
            this.tbHTTPLoggingResponse.Name = "tbHTTPLoggingResponse";
            this.tbHTTPLoggingResponse.ReadOnly = true;
            this.tbHTTPLoggingResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbHTTPLoggingResponse.Size = new System.Drawing.Size(334, 165);
            this.tbHTTPLoggingResponse.TabIndex = 0;
            // 
            // panelHTTPLoggingSearch
            // 
            this.panelHTTPLoggingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelHTTPLoggingSearch.Controls.Add(this.labelHTTPLoggingSearch);
            this.panelHTTPLoggingSearch.Controls.Add(this.tbHTTPLoggingSearch);
            this.panelHTTPLoggingSearch.Location = new System.Drawing.Point(3, 3);
            this.panelHTTPLoggingSearch.Name = "panelHTTPLoggingSearch";
            this.panelHTTPLoggingSearch.Size = new System.Drawing.Size(283, 29);
            this.panelHTTPLoggingSearch.TabIndex = 3;
            // 
            // tbHTTPLoggingSearch
            // 
            this.tbHTTPLoggingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbHTTPLoggingSearch.Location = new System.Drawing.Point(51, 3);
            this.tbHTTPLoggingSearch.Name = "tbHTTPLoggingSearch";
            this.tbHTTPLoggingSearch.Size = new System.Drawing.Size(229, 20);
            this.tbHTTPLoggingSearch.TabIndex = 0;
            this.tbHTTPLoggingSearch.TextChanged += new System.EventHandler(this.tbHTTPLoggingSearch_TextChanged);
            // 
            // labelHTTPLoggingSearch
            // 
            this.labelHTTPLoggingSearch.AutoSize = true;
            this.labelHTTPLoggingSearch.Location = new System.Drawing.Point(3, 6);
            this.labelHTTPLoggingSearch.Name = "labelHTTPLoggingSearch";
            this.labelHTTPLoggingSearch.Size = new System.Drawing.Size(42, 13);
            this.labelHTTPLoggingSearch.TabIndex = 1;
            this.labelHTTPLoggingSearch.Text = "Поиск:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.Text = "Simple: Technical Support Assistant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHTTPLogging.ResumeLayout(false);
            this.splitContainerHTTPLogging.Panel1.ResumeLayout(false);
            this.splitContainerHTTPLogging.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHTTPLogging)).EndInit();
            this.splitContainerHTTPLogging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHTTPLogging)).EndInit();
            this.splitContainerHTTPLogging2.Panel1.ResumeLayout(false);
            this.splitContainerHTTPLogging2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHTTPLogging2)).EndInit();
            this.splitContainerHTTPLogging2.ResumeLayout(false);
            this.tlpHTTPLogging.ResumeLayout(false);
            this.gbHTTPLoggingRequest.ResumeLayout(false);
            this.gbHTTPLoggingRequest.PerformLayout();
            this.gbHTTPLogging.ResumeLayout(false);
            this.gbHTTPLogging.PerformLayout();
            this.panelHTTPLoggingSearch.ResumeLayout(false);
            this.panelHTTPLoggingSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обращениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логированиеHTTPToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageHTTPLogging;
        private System.Windows.Forms.TabPage tabPage_RegistrationLog;
        private System.Windows.Forms.TabPage tabPage_Attachments;
        private System.Windows.Forms.DataGridView dgwHTTPLogging;
        private System.Windows.Forms.SplitContainer splitContainerHTTPLogging;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingStatusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingDeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingRequestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwHTTPLoggingResponseData;
        private System.Windows.Forms.SplitContainer splitContainerHTTPLogging2;
        private System.Windows.Forms.TableLayoutPanel tlpHTTPLogging;
        private System.Windows.Forms.GroupBox gbHTTPLoggingRequest;
        private System.Windows.Forms.TextBox tbHTTPLoggingRequest;
        private System.Windows.Forms.GroupBox gbHTTPLogging;
        private System.Windows.Forms.TextBox tbHTTPLoggingResponse;
        private System.Windows.Forms.Panel panelHTTPLoggingSearch;
        private System.Windows.Forms.Label labelHTTPLoggingSearch;
        private System.Windows.Forms.TextBox tbHTTPLoggingSearch;
    }
}

