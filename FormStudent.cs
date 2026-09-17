namespace lab3_c_
{
    public partial class FormStudent : Form
    {
        public string FullName { get; private set; } = string.Empty;
        public string Group { get; private set; } = string.Empty;
        public int Course { get; private set; }
        public string Specialty { get; private set; } = string.Empty;

        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            textBoxFullName.Focus();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxGroup.Text) ||
                string.IsNullOrWhiteSpace(textBoxSpecialty.Text))
            {
                MessageBox.Show(
                    "Заполните все поля формы.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            FullName = textBoxFullName.Text.Trim();
            Group = textBoxGroup.Text.Trim();
            Course = (int)numericUpDownCourse.Value;
            Specialty = textBoxSpecialty.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
