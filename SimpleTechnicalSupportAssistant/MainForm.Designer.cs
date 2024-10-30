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
            this.tabPage_RegistrationLog = new System.Windows.Forms.TabPage();
            this.tabPage_Attachments = new System.Windows.Forms.TabPage();
            this.menuStrip_Main.SuspendLayout();
            this.tabControlMain.SuspendLayout();
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
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.tabPageHTTPLogging.Location = new System.Drawing.Point(4, 22);
            this.tabPageHTTPLogging.Name = "tabPageHTTPLogging";
            this.tabPageHTTPLogging.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTTPLogging.Size = new System.Drawing.Size(792, 400);
            this.tabPageHTTPLogging.TabIndex = 1;
            this.tabPageHTTPLogging.Text = "HTTP логирование";
            this.tabPageHTTPLogging.UseVisualStyleBackColor = true;
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
    }
}

