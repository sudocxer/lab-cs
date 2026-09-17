namespace lab2_c_
{
    public partial class FormCatalog : Form
    {
        private static readonly string[] Products =
        {
            "Хлеб белый — 60 руб.",
            "Молоко 1л — 90 руб.",
            "Сыр Российский — 450 руб/кг",
            "Яблоки — 120 руб/кг",
            "Чай чёрный — 180 руб.",
            "Кофе растворимый — 350 руб.",
            "Макароны — 85 руб.",
            "Масло сливочное — 220 руб.",
        };

        public FormCatalog()
        {
            InitializeComponent();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            listBoxProducts.Items.AddRange(Products);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
