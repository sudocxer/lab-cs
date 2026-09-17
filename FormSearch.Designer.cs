namespace lab4_c_
{
    partial class FormSearch
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
            this.labelQuery = new Label();
            this.textBoxQuery = new TextBox();
            this.buttonFind = new Button();
            this.listBoxResults = new ListBox();
            this.SuspendLayout();
            //
            // labelQuery
            //
            this.labelQuery.AutoSize = true;
            this.labelQuery.Location = new Point(12, 17);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new Size(52, 15);
            this.labelQuery.TabIndex = 0;
            this.labelQuery.Text = "Запрос:";
            //
            // textBoxQuery
            //
            this.textBoxQuery.Location = new Point(75, 14);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new Size(180, 23);
            this.textBoxQuery.TabIndex = 1;
            //
            // buttonFind
            //
            this.buttonFind.Location = new Point(263, 13);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new Size(72, 25);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new EventHandler(this.buttonFind_Click);
            //
            // listBoxResults
            //
            this.listBoxResults.Location = new Point(12, 47);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new Size(323, 150);
            this.listBoxResults.TabIndex = 3;
            //
            // FormSearch
            //
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(347, 209);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listBoxResults);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSearch";
            this.Text = "Поиск";
            this.Load += new EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelQuery;
        private TextBox textBoxQuery;
        private Button buttonFind;
        private ListBox listBoxResults;
    }
}
