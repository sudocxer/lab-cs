namespace lab3_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxStudents.Items.Add("Иванов Иван Иванович — гр. ПИ-21, 2 курс, Программная инженерия");
            listBoxStudents.Items.Add("Петрова Анна Сергеевна — гр. ИС-19, 4 курс, Информационные системы");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using FormStudent form = new FormStudent();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                listBoxStudents.Items.Add(
                    $"{form.FullName} — гр. {form.Group}, {form.Course} курс, {form.Specialty}");

                MessageBox.Show(
                    "Данные сохранены",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
