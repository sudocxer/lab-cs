namespace lab5_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            using FormEditor form = new FormEditor();
            form.ShowDialog(this);
        }

        private void buttonTrafficLight_Click(object sender, EventArgs e)
        {
            using FormTrafficLight form = new FormTrafficLight();
            form.ShowDialog(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
