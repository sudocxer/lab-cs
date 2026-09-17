namespace lab4_c_
{
    public partial class FormLog : Form
    {
        private int entryNumber = 1;

        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            listBoxLog.Items.Add($"{DateTime.Now:HH:mm:ss} — Приложение запущено");
            listBoxLog.Items.Add($"{DateTime.Now:HH:mm:ss} — Окно «Журнал событий» открыто");
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Add($"{DateTime.Now:HH:mm:ss} — Запись №{entryNumber} добавлена пользователем");
            entryNumber++;
        }
    }
}
