namespace lab4_c_
{
    partial class FormSettings
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
            this.checkBoxNotifications = new CheckBox();
            this.checkBoxDarkTheme = new CheckBox();
            this.labelLanguage = new Label();
            this.comboBoxLanguage = new ComboBox();
            this.buttonApply = new Button();
            this.buttonClose = new Button();
            this.SuspendLayout();
            //
            // checkBoxNotifications
            //
            this.checkBoxNotifications.AutoSize = true;
            this.checkBoxNotifications.Checked = true;
            this.checkBoxNotifications.CheckState = CheckState.Checked;
            this.checkBoxNotifications.Location = new Point(12, 15);
            this.checkBoxNotifications.Name = "checkBoxNotifications";
            this.checkBoxNotifications.Size = new Size(150, 19);
            this.checkBoxNotifications.TabIndex = 0;
            this.checkBoxNotifications.Text = "Включить уведомления";
            this.checkBoxNotifications.UseVisualStyleBackColor = true;
            //
            // checkBoxDarkTheme
            //
            this.checkBoxDarkTheme.AutoSize = true;
            this.checkBoxDarkTheme.Location = new Point(12, 45);
            this.checkBoxDarkTheme.Name = "checkBoxDarkTheme";
            this.checkBoxDarkTheme.Size = new Size(97, 19);
            this.checkBoxDarkTheme.TabIndex = 1;
            this.checkBoxDarkTheme.Text = "Тёмная тема";
            this.checkBoxDarkTheme.UseVisualStyleBackColor = true;
            //
            // labelLanguage
            //
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new Point(12, 82);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new Size(107, 15);
            this.labelLanguage.TabIndex = 2;
            this.labelLanguage.Text = "Язык интерфейса:";
            //
            // comboBoxLanguage
            //
            this.comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Items.AddRange(new object[] { "Русский", "English" });
            this.comboBoxLanguage.Location = new Point(140, 78);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new Size(140, 23);
            this.comboBoxLanguage.TabIndex = 3;
            //
            // buttonApply
            //
            this.buttonApply.Location = new Point(12, 120);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new Size(130, 35);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new EventHandler(this.buttonApply_Click);
            //
            // buttonClose
            //
            this.buttonClose.Location = new Point(152, 120);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(130, 35);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            //
            // FormSettings
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(296, 167);
            this.Controls.Add(this.checkBoxNotifications);
            this.Controls.Add(this.checkBoxDarkTheme);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private CheckBox checkBoxNotifications;
        private CheckBox checkBoxDarkTheme;
        private Label labelLanguage;
        private ComboBox comboBoxLanguage;
        private Button buttonApply;
        private Button buttonClose;
    }
}
