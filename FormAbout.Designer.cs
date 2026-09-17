namespace lab2_c_
{
    partial class FormAbout
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
            this.labelTitle = new Label();
            this.labelVersion = new Label();
            this.labelDescription = new Label();
            this.buttonOk = new Button();
            this.SuspendLayout();
            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.labelTitle.Location = new Point(12, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(90, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Магазин";
            //
            // labelVersion
            //
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new Point(12, 45);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new Size(70, 15);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Версия 1.0";
            //
            // labelDescription
            //
            this.labelDescription.Location = new Point(12, 70);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new Size(280, 80);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Многооконное Windows-\r\n" +
                "приложение «Магазин».\r\n" +
                "Лабораторная работа №2.\r\n" +
                "Демонстрация работы с\r\n" +
                "несколькими формами.";
            //
            // buttonOk
            //
            this.buttonOk.Location = new Point(12, 160);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(280, 35);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
            //
            // FormAbout
            //
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(304, 210);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelVersion;
        private Label labelDescription;
        private Button buttonOk;
    }
}
