namespace lab6_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBoxDisciplines_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int delta = e.NewValue == CheckState.Checked ? 1 : 0;
            delta -= e.CurrentValue == CheckState.Checked ? 1 : 0;
            int count = checkedListBoxDisciplines.CheckedItems.Count + delta;
            labelSelectedCount.Text = $"Выбрано дисциплин: {count}";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show(
                    "Введите ФИО студента.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxFullName.Focus();
                return;
            }

            textBoxResult.Clear();
            progressBarRegister.Value = 0;
            buttonRegister.Enabled = false;
            timerRegister.Start();
        }

        private void timerRegister_Tick(object sender, EventArgs e)
        {
            progressBarRegister.Value = Math.Min(100, progressBarRegister.Value + 10);

            if (progressBarRegister.Value >= 100)
            {
                timerRegister.Stop();
                buttonRegister.Enabled = true;
                ShowResult();
            }
        }

        private void ShowResult()
        {
            string studyForm =
                radioButtonFullTime.Checked ? "Очная" :
                radioButtonPartTime.Checked ? "Заочная" :
                "Очно-заочная";

            var disciplines = checkedListBoxDisciplines.CheckedItems.Cast<string>().ToList();
            string disciplinesText = disciplines.Count > 0 ? string.Join(", ", disciplines) : "не выбраны";

            textBoxResult.Text =
                $"ФИО: {textBoxFullName.Text.Trim()}\r\n" +
                $"Курс: {numericUpDownCourse.Value}\r\n" +
                $"Группа: {comboBoxGroup.SelectedItem}\r\n" +
                $"Форма обучения: {studyForm}\r\n" +
                $"Дополнительные дисциплины: {disciplinesText}\r\n" +
                $"Дата рождения: {dateTimePickerBirthDate.Value:dd.MM.yyyy}";

            MessageBox.Show(
                "Студент успешно зарегистрирован!",
                "Регистрация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFullName.Clear();
            numericUpDownCourse.Value = 1;
            comboBoxGroup.SelectedIndex = -1;
            radioButtonFullTime.Checked = true;

            for (int i = 0; i < checkedListBoxDisciplines.Items.Count; i++)
            {
                checkedListBoxDisciplines.SetItemChecked(i, false);
            }

            labelSelectedCount.Text = "Выбрано дисциплин: 0";
            dateTimePickerBirthDate.Value = new DateTime(2006, 1, 1);
            progressBarRegister.Value = 0;
            textBoxResult.Clear();
            textBoxFullName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
