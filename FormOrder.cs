namespace lab2_c_
{
    public partial class FormOrder : Form
    {
        public string SelectedProductName { get; private set; }
        public int Quantity { get; private set; }

        public FormOrder(string productName)
        {
            InitializeComponent();
            SelectedProductName = productName;
            labelProductNameValue.Text = productName;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Quantity = (int)numericUpDownQuantity.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
