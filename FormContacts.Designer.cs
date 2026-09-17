namespace lab2_c_
{
    partial class FormContacts
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
            this.labelInfo = new Label();
            this.buttonClose = new Button();
            this.SuspendLayout();
            //
            // labelInfo
            //
            this.labelInfo.Location = new Point(12, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new Size(300, 140);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Адрес: г. Москва, ул. Примерная, д. 1\r\n" +
                "Телефон: +7 (495) 123-45-67\r\n" +
                "Email: info@magazin.ru\r\n" +
                "Режим работы: ежедневно, 9:00–21:00";
            //
            // buttonClose
            //
            this.buttonClose.Location = new Point(12, 160);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(300, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            //
            // FormContacts
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(324, 207);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormContacts";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Контакты";
            this.ResumeLayout(false);
        }

        #endregion

        private Label labelInfo;
        private Button buttonClose;
    }
}
