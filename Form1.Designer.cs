namespace lab3_c_
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
            this.listBoxStudents = new ListBox();
            this.buttonAdd = new Button();
            this.buttonExit = new Button();
            this.SuspendLayout();
            //
            // listBoxStudents
            //
            this.listBoxStudents.Location = new Point(12, 12);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new Size(360, 220);
            this.listBoxStudents.TabIndex = 0;
            //
            // buttonAdd
            //
            this.buttonAdd.Location = new Point(12, 244);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(174, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(198, 244);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(174, 35);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(384, 291);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Добавление студента";
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxStudents;
        private Button buttonAdd;
        private Button buttonExit;
    }
}
