namespace lab1_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLogin.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show(
                    "Заполните все поля формы.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Пароль должен содержать не менее 6 символов.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return;
            }

            if (!email.Contains('@') || !email.Contains('.'))
            {
                MessageBox.Show(
                    "Введите корректный адрес электронной почты.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            MessageBox.Show(
                $"Пользователь успешно зарегистрирован!\n\n" +
                $"Логин: {login}\n" +
                $"Пароль: {new string('*', password.Length)}\n" +
                $"Email: {email}\n" +
                $"Телефон: {phone}",
                "Регистрация завершена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxLogin.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
