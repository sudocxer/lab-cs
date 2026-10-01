namespace lab6_c_
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
            this.components = new System.ComponentModel.Container();
            this.labelFullName = new Label();
            this.textBoxFullName = new TextBox();
            this.labelCourse = new Label();
            this.numericUpDownCourse = new NumericUpDown();
            this.labelGroup = new Label();
            this.comboBoxGroup = new ComboBox();
            this.groupBoxForm = new GroupBox();
            this.radioButtonEveningTime = new RadioButton();
            this.radioButtonPartTime = new RadioButton();
            this.radioButtonFullTime = new RadioButton();
            this.labelDisciplines = new Label();
            this.checkedListBoxDisciplines = new CheckedListBox();
            this.labelSelectedCount = new Label();
            this.labelBirthDate = new Label();
            this.dateTimePickerBirthDate = new DateTimePicker();
            this.progressBarRegister = new ProgressBar();
            this.buttonRegister = new Button();
            this.buttonClear = new Button();
            this.buttonExit = new Button();
            this.labelResultCaption = new Label();
            this.textBoxResult = new TextBox();
            this.timerRegister = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            //
            // labelFullName
            //
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(12, 18);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(33, 15);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ФИО:";
            //
            // textBoxFullName
            //
            this.textBoxFullName.Location = new Point(170, 15);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new Size(288, 23);
            this.textBoxFullName.TabIndex = 1;
            //
            // labelCourse
            //
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new Point(12, 53);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new Size(37, 15);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Курс:";
            //
            // numericUpDownCourse
            //
            this.numericUpDownCourse.Location = new Point(170, 50);
            this.numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new Size(60, 23);
            this.numericUpDownCourse.TabIndex = 3;
            this.numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // labelGroup
            //
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new Point(250, 53);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new Size(50, 15);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Группа:";
            //
            // comboBoxGroup
            //
            this.comboBoxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxGroup.Items.AddRange(new object[] { "ПИ-21", "ПИ-22", "ИС-19", "КТ-20" });
            this.comboBoxGroup.Location = new Point(310, 50);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new Size(148, 23);
            this.comboBoxGroup.TabIndex = 5;
            //
            // groupBoxForm
            //
            this.groupBoxForm.Controls.Add(this.radioButtonEveningTime);
            this.groupBoxForm.Controls.Add(this.radioButtonPartTime);
            this.groupBoxForm.Controls.Add(this.radioButtonFullTime);
            this.groupBoxForm.Location = new Point(12, 86);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new Size(446, 54);
            this.groupBoxForm.TabIndex = 6;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Форма обучения";
            //
            // radioButtonEveningTime
            //
            this.radioButtonEveningTime.AutoSize = true;
            this.radioButtonEveningTime.Location = new Point(250, 22);
            this.radioButtonEveningTime.Name = "radioButtonEveningTime";
            this.radioButtonEveningTime.Size = new Size(118, 19);
            this.radioButtonEveningTime.TabIndex = 2;
            this.radioButtonEveningTime.Text = "Очно-заочная";
            this.radioButtonEveningTime.UseVisualStyleBackColor = true;
            //
            // radioButtonPartTime
            //
            this.radioButtonPartTime.AutoSize = true;
            this.radioButtonPartTime.Location = new Point(130, 22);
            this.radioButtonPartTime.Name = "radioButtonPartTime";
            this.radioButtonPartTime.Size = new Size(70, 19);
            this.radioButtonPartTime.TabIndex = 1;
            this.radioButtonPartTime.Text = "Заочная";
            this.radioButtonPartTime.UseVisualStyleBackColor = true;
            //
            // radioButtonFullTime
            //
            this.radioButtonFullTime.AutoSize = true;
            this.radioButtonFullTime.Checked = true;
            this.radioButtonFullTime.Location = new Point(10, 22);
            this.radioButtonFullTime.Name = "radioButtonFullTime";
            this.radioButtonFullTime.Size = new Size(63, 19);
            this.radioButtonFullTime.TabIndex = 0;
            this.radioButtonFullTime.TabStop = true;
            this.radioButtonFullTime.Text = "Очная";
            this.radioButtonFullTime.UseVisualStyleBackColor = true;
            //
            // labelDisciplines
            //
            this.labelDisciplines.AutoSize = true;
            this.labelDisciplines.Location = new Point(12, 152);
            this.labelDisciplines.Name = "labelDisciplines";
            this.labelDisciplines.Size = new Size(168, 15);
            this.labelDisciplines.TabIndex = 7;
            this.labelDisciplines.Text = "Дополнительные дисциплины:";
            //
            // checkedListBoxDisciplines
            //
            this.checkedListBoxDisciplines.CheckOnClick = true;
            this.checkedListBoxDisciplines.FormattingEnabled = true;
            this.checkedListBoxDisciplines.Items.AddRange(new object[] {
                "Английский язык",
                "Основы программирования",
                "Экономика",
                "Философия",
                "Физическая культура"});
            this.checkedListBoxDisciplines.Location = new Point(12, 172);
            this.checkedListBoxDisciplines.Name = "checkedListBoxDisciplines";
            this.checkedListBoxDisciplines.Size = new Size(446, 106);
            this.checkedListBoxDisciplines.TabIndex = 8;
            this.checkedListBoxDisciplines.ItemCheck += new ItemCheckEventHandler(this.checkedListBoxDisciplines_ItemCheck);
            //
            // labelSelectedCount
            //
            this.labelSelectedCount.AutoSize = true;
            this.labelSelectedCount.Location = new Point(12, 286);
            this.labelSelectedCount.Name = "labelSelectedCount";
            this.labelSelectedCount.Size = new Size(124, 15);
            this.labelSelectedCount.TabIndex = 9;
            this.labelSelectedCount.Text = "Выбрано дисциплин: 0";
            //
            // labelBirthDate
            //
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new Point(12, 317);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new Size(97, 15);
            this.labelBirthDate.TabIndex = 10;
            this.labelBirthDate.Text = "Дата рождения:";
            //
            // dateTimePickerBirthDate
            //
            this.dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new Point(170, 313);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new Size(200, 23);
            this.dateTimePickerBirthDate.TabIndex = 11;
            this.dateTimePickerBirthDate.Value = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            //
            // progressBarRegister
            //
            this.progressBarRegister.Location = new Point(12, 349);
            this.progressBarRegister.Name = "progressBarRegister";
            this.progressBarRegister.Size = new Size(446, 18);
            this.progressBarRegister.TabIndex = 12;
            //
            // buttonRegister
            //
            this.buttonRegister.Location = new Point(12, 378);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new Size(144, 36);
            this.buttonRegister.TabIndex = 13;
            this.buttonRegister.Text = "Зарегистрировать";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new EventHandler(this.buttonRegister_Click);
            //
            // buttonClear
            //
            this.buttonClear.Location = new Point(164, 378);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new Size(144, 36);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(316, 378);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(142, 36);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // labelResultCaption
            //
            this.labelResultCaption.AutoSize = true;
            this.labelResultCaption.Location = new Point(12, 426);
            this.labelResultCaption.Name = "labelResultCaption";
            this.labelResultCaption.Size = new Size(133, 15);
            this.labelResultCaption.TabIndex = 16;
            this.labelResultCaption.Text = "Результат регистрации:";
            //
            // textBoxResult
            //
            this.textBoxResult.Location = new Point(12, 448);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = ScrollBars.Vertical;
            this.textBoxResult.Size = new Size(446, 94);
            this.textBoxResult.TabIndex = 17;
            this.textBoxResult.TabStop = false;
            //
            // timerRegister
            //
            this.timerRegister.Interval = 30;
            this.timerRegister.Tick += new EventHandler(this.timerRegister_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(470, 554);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.labelDisciplines);
            this.Controls.Add(this.checkedListBoxDisciplines);
            this.Controls.Add(this.labelSelectedCount);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.progressBarRegister);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelResultCaption);
            this.Controls.Add(this.textBoxResult);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Регистрация студента";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelCourse;
        private NumericUpDown numericUpDownCourse;
        private Label labelGroup;
        private ComboBox comboBoxGroup;
        private GroupBox groupBoxForm;
        private RadioButton radioButtonEveningTime;
        private RadioButton radioButtonPartTime;
        private RadioButton radioButtonFullTime;
        private Label labelDisciplines;
        private CheckedListBox checkedListBoxDisciplines;
        private Label labelSelectedCount;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirthDate;
        private ProgressBar progressBarRegister;
        private Button buttonRegister;
        private Button buttonClear;
        private Button buttonExit;
        private Label labelResultCaption;
        private TextBox textBoxResult;
        private System.Windows.Forms.Timer timerRegister;
    }
}
