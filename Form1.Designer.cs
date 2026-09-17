namespace lab4_c_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonInfo = new Button();
            this.buttonSettings = new Button();
            this.buttonSearch = new Button();
            this.buttonLog = new Button();
            this.buttonHelp = new Button();
            this.buttonExit = new Button();
            this.SuspendLayout();
            //
            // buttonInfo
            //
            this.buttonInfo.Location = new Point(12, 12);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new Size(160, 40);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "Информация";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new EventHandler(this.buttonInfo_Click);
            //
            // buttonSettings
            //
            this.buttonSettings.Location = new Point(188, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new Size(160, 40);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new EventHandler(this.buttonSettings_Click);
            //
            // buttonSearch
            //
            this.buttonSearch.Location = new Point(12, 62);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(160, 40);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            //
            // buttonLog
            //
            this.buttonLog.Location = new Point(188, 62);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new Size(160, 40);
            this.buttonLog.TabIndex = 3;
            this.buttonLog.Text = "Журнал";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new EventHandler(this.buttonLog_Click);
            //
            // buttonHelp
            //
            this.buttonHelp.Location = new Point(12, 112);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new Size(160, 40);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new EventHandler(this.buttonHelp_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(188, 112);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(160, 40);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 168);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Многоканальный рабочий стол";
            this.ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo;
        private Button buttonSettings;
        private Button buttonSearch;
        private Button buttonLog;
        private Button buttonHelp;
        private Button buttonExit;
    }
}
