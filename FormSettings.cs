namespace lab4_c_
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Настройки применены",
                "Настройки",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
