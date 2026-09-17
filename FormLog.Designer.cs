namespace lab4_c_
{
    partial class FormLog
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
            this.listBoxLog = new ListBox();
            this.buttonAddEntry = new Button();
            this.SuspendLayout();
            //
            // listBoxLog
            //
            this.listBoxLog.Location = new Point(12, 12);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new Size(300, 184);
            this.listBoxLog.TabIndex = 0;
            //
            // buttonAddEntry
            //
            this.buttonAddEntry.Location = new Point(12, 205);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new Size(300, 35);
            this.buttonAddEntry.TabIndex = 1;
            this.buttonAddEntry.Text = "Добавить запись";
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            this.buttonAddEntry.Click += new EventHandler(this.buttonAddEntry_Click);
            //
            // FormLog
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(324, 252);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonAddEntry);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLog";
            this.Text = "Журнал событий";
            this.Load += new EventHandler(this.FormLog_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxLog;
        private Button buttonAddEntry;
    }
}
