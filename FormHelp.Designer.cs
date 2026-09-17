namespace lab4_c_
{
    partial class FormHelp
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
            this.textBoxHelp = new TextBox();
            this.buttonClose = new Button();
            this.SuspendLayout();
            //
            // textBoxHelp
            //
            this.textBoxHelp.Location = new Point(12, 12);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.ReadOnly = true;
            this.textBoxHelp.ScrollBars = ScrollBars.Vertical;
            this.textBoxHelp.Size = new Size(300, 150);
            this.textBoxHelp.TabIndex = 0;
            this.textBoxHelp.TabStop = false;
            this.textBoxHelp.Text = "«Многоканальный рабочий стол»\r\n\r\n" +
                "Каждая кнопка главного окна открывает своё немодальное окно: " +
                "Информация, Настройки, Поиск, Журнал, Справка.\r\n\r\n" +
                "Все окна можно держать открытыми одновременно и свободно " +
                "переключаться между ними и главным окном.\r\n\r\n" +
                "Повторное нажатие кнопки не создаёт новую копию окна, а " +
                "активирует уже открытое.";
            //
            // buttonClose
            //
            this.buttonClose.Location = new Point(12, 170);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(300, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            //
            // FormHelp
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(324, 217);
            this.Controls.Add(this.textBoxHelp);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHelp";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp;
        private Button buttonClose;
    }
}
