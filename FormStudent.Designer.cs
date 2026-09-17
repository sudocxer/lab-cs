namespace lab3_c_
{
    partial class FormStudent
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
            this.labelFullName = new Label();
            this.textBoxFullName = new TextBox();
            this.labelGroup = new Label();
            this.textBoxGroup = new TextBox();
            this.labelCourse = new Label();
            this.numericUpDownCourse = new NumericUpDown();
            this.labelSpecialty = new Label();
            this.textBoxSpecialty = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.SuspendLayout();
            //
            // labelFullName
            //
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(12, 20);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(33, 15);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ФИО:";
            //
            // textBoxFullName
            //
            this.textBoxFullName.Location = new Point(110, 17);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new Size(220, 23);
            this.textBoxFullName.TabIndex = 1;
            //
            // labelGroup
            //
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new Point(12, 55);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new Size(50, 15);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группа:";
            //
            // textBoxGroup
            //
            this.textBoxGroup.Location = new Point(110, 52);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new Size(220, 23);
            this.textBoxGroup.TabIndex = 3;
            //
            // labelCourse
            //
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new Point(12, 90);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new Size(37, 15);
            this.labelCourse.TabIndex = 4;
            this.labelCourse.Text = "Курс:";
            //
            // numericUpDownCourse
            //
            this.numericUpDownCourse.Location = new Point(110, 87);
            this.numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new Size(60, 23);
            this.numericUpDownCourse.TabIndex = 5;
            //
            // labelSpecialty
            //
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new Point(12, 125);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new Size(92, 15);
            this.labelSpecialty.TabIndex = 6;
            this.labelSpecialty.Text = "Специальность:";
            //
            // textBoxSpecialty
            //
            this.textBoxSpecialty.Location = new Point(110, 122);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.Size = new Size(220, 23);
            this.textBoxSpecialty.TabIndex = 7;
            //
            // buttonOK
            //
            this.buttonOK.Location = new Point(110, 165);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(105, 35);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Location = new Point(225, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(105, 35);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            //
            // FormStudent
            //
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(342, 212);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.labelSpecialty);
            this.Controls.Add(this.textBoxSpecialty);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudent";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Новый студент";
            this.Load += new EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelGroup;
        private TextBox textBoxGroup;
        private Label labelCourse;
        private NumericUpDown numericUpDownCourse;
        private Label labelSpecialty;
        private TextBox textBoxSpecialty;
        private Button buttonOK;
        private Button buttonCancel;
    }
}
