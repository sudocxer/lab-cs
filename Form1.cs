namespace lab2_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            FormCatalog formCatalog = new FormCatalog();
            formCatalog.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show(
                    "Введите название товара.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxProductName.Focus();
                return;
            }

            using FormOrder formOrder = new FormOrder(productName);
            if (formOrder.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(
                    $"Заказ оформлен!\n\nТовар: {formOrder.SelectedProductName}\nКоличество: {formOrder.Quantity} шт.",
                    "Заказ принят",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            FormContacts formContacts = new FormContacts();
            formContacts.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
