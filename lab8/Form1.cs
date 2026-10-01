using System.Data;
using Microsoft.Data.SqlClient;

namespace lab8_c_
{
    public partial class Form1 : Form
    {
        private int? selectedId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentRepository.EnsureDatabase();
                LoadStudents(StudentRepository.GetAll());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    $"Не удалось подключиться к базе данных StudentDB.\n\n{ex.Message}",
                    "Ошибка подключения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadStudents(DataTable table)
        {
            dataGridViewStudents.DataSource = table;

            if (dataGridViewStudents.Columns["Id"] is DataGridViewColumn idColumn)
            {
                idColumn.HeaderText = "ID";
                idColumn.Width = 50;
            }

            if (dataGridViewStudents.Columns["Surname"] is DataGridViewColumn surnameColumn)
            {
                surnameColumn.HeaderText = "Фамилия";
            }

            if (dataGridViewStudents.Columns["Name"] is DataGridViewColumn nameColumn)
            {
                nameColumn.HeaderText = "Имя";
            }

            if (dataGridViewStudents.Columns["GroupName"] is DataGridViewColumn groupColumn)
            {
                groupColumn.HeaderText = "Группа";
            }

            if (dataGridViewStudents.Columns["Course"] is DataGridViewColumn courseColumn)
            {
                courseColumn.HeaderText = "Курс";
            }
        }

        private bool TryBuildStudent(out Student student)
        {
            student = new Student();

            if (string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxGroup.Text))
            {
                MessageBox.Show(
                    "Заполните фамилию, имя и группу студента.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            student.Surname = textBoxSurname.Text.Trim();
            student.Name = textBoxName.Text.Trim();
            student.GroupName = textBoxGroup.Text.Trim();
            student.Course = (int)numericUpDownCourse.Value;
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!TryBuildStudent(out Student student))
            {
                return;
            }

            try
            {
                StudentRepository.Add(student);
                LoadStudents(StudentRepository.GetAll());
                ClearFields();
            }
            catch (SqlException ex)
            {
                ShowDbError(ex);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show(
                    "Выберите студента в таблице, которого нужно изменить.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!TryBuildStudent(out Student student))
            {
                return;
            }

            student.Id = selectedId.Value;

            try
            {
                StudentRepository.Update(student);
                LoadStudents(StudentRepository.GetAll());
                ClearFields();
            }
            catch (SqlException ex)
            {
                ShowDbError(ex);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show(
                    "Выберите студента в таблице, которого нужно удалить.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Удалить выбранного студента?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                StudentRepository.Delete(selectedId.Value);
                LoadStudents(StudentRepository.GetAll());
                ClearFields();
            }
            catch (SqlException ex)
            {
                ShowDbError(ex);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridViewStudents.ClearSelection();
        }

        private void ClearFields()
        {
            selectedId = null;
            textBoxSurname.Clear();
            textBoxName.Clear();
            textBoxGroup.Clear();
            numericUpDownCourse.Value = 1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadStudents(StudentRepository.Search(textBoxSearch.Text.Trim()));
            }
            catch (SqlException ex)
            {
                ShowDbError(ex);
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();

            try
            {
                LoadStudents(StudentRepository.GetAll());
            }
            catch (SqlException ex)
            {
                ShowDbError(ex);
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow?.DataBoundItem is not DataRowView row)
            {
                return;
            }

            selectedId = (int)row["Id"];
            textBoxSurname.Text = row["Surname"].ToString();
            textBoxName.Text = row["Name"].ToString();
            textBoxGroup.Text = row["GroupName"].ToString();
            numericUpDownCourse.Value = Convert.ToInt32(row["Course"]);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void ShowDbError(SqlException ex)
        {
            MessageBox.Show(
                $"Ошибка при обращении к базе данных.\n\n{ex.Message}",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
