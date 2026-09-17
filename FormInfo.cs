namespace lab4_c_
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            labelInfo.Text =
                $"Операционная система: {Environment.OSVersion}\r\n" +
                $"Имя компьютера: {Environment.MachineName}\r\n" +
                $"Пользователь: {Environment.UserName}\r\n" +
                $"Версия приложения: 1.0\r\n" +
                $"Текущее время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
