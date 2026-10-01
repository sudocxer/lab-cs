namespace lab8_c_
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
            this.dataGridViewStudents = new DataGridView();
            this.labelSurname = new Label();
            this.textBoxSurname = new TextBox();
            this.labelName = new Label();
            this.textBoxName = new TextBox();
            this.labelGroup = new Label();
            this.textBoxGroup = new TextBox();
            this.labelCourse = new Label();
            this.numericUpDownCourse = new NumericUpDown();
            this.buttonAdd = new Button();
            this.buttonUpdate = new Button();
            this.buttonDelete = new Button();
            this.buttonClear = new Button();
            this.labelSearch = new Label();
            this.textBoxSearch = new TextBox();
            this.buttonSearch = new Button();
            this.buttonShowAll = new Button();
            this.buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridViewStudents
            //
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.Location = new Point(12, 12);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersWidth = 24;
            this.dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new Size(716, 210);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.SelectionChanged += new EventHandler(this.dataGridViewStudents_SelectionChanged);
            //
            // labelSurname
            //
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new Point(12, 237);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new Size(58, 15);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия:";
            //
            // textBoxSurname
            //
            this.textBoxSurname.Location = new Point(100, 234);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new Size(200, 23);
            this.textBoxSurname.TabIndex = 2;
            //
            // labelName
            //
            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(320, 237);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(30, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя:";
            //
            // textBoxName
            //
            this.textBoxName.Location = new Point(360, 234);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(200, 23);
            this.textBoxName.TabIndex = 4;
            //
            // labelGroup
            //
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new Point(12, 269);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new Size(50, 15);
            this.labelGroup.TabIndex = 5;
            this.labelGroup.Text = "Группа:";
            //
            // textBoxGroup
            //
            this.textBoxGroup.Location = new Point(100, 266);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new Size(200, 23);
            this.textBoxGroup.TabIndex = 6;
            //
            // labelCourse
            //
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new Point(320, 269);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new Size(37, 15);
            this.labelCourse.TabIndex = 7;
            this.labelCourse.Text = "Курс:";
            //
            // numericUpDownCourse
            //
            this.numericUpDownCourse.Location = new Point(360, 266);
            this.numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new Size(60, 23);
            this.numericUpDownCourse.TabIndex = 8;
            this.numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // buttonAdd
            //
            this.buttonAdd.Location = new Point(12, 300);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(160, 34);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            //
            // buttonUpdate
            //
            this.buttonUpdate.Location = new Point(182, 300);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(160, 34);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            //
            // buttonDelete
            //
            this.buttonDelete.Location = new Point(352, 300);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new Size(160, 34);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            //
            // buttonClear
            //
            this.buttonClear.Location = new Point(522, 300);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new Size(206, 34);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);
            //
            // labelSearch
            //
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new Point(12, 352);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new Size(110, 15);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "Поиск по фамилии:";
            //
            // textBoxSearch
            //
            this.textBoxSearch.Location = new Point(140, 346);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new Size(220, 23);
            this.textBoxSearch.TabIndex = 14;
            //
            // buttonSearch
            //
            this.buttonSearch.Location = new Point(368, 345);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(90, 25);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            //
            // buttonShowAll
            //
            this.buttonShowAll.Location = new Point(464, 345);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new Size(140, 25);
            this.buttonShowAll.TabIndex = 16;
            this.buttonShowAll.Text = "Показать всех";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new EventHandler(this.buttonShowAll_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(616, 345);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(112, 25);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(740, 400);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonExit);
            this.MinimumSize = new Size(620, 430);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Управление студентами";
            this.Load += new EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelGroup;
        private TextBox textBoxGroup;
        private Label labelCourse;
        private NumericUpDown numericUpDownCourse;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonShowAll;
        private Button buttonExit;
    }
}
