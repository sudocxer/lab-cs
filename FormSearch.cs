namespace lab4_c_
{
    public partial class FormSearch : Form
    {
        private static readonly string[] SearchIndex =
        {
            "Отчёт по продажам за 2026 год",
            "Договор поставки № 145",
            "Инструкция пользователя",
            "Приказ о премировании",
            "Смета проекта «Магазин»",
            "Протокол совещания отдела",
            "Справочник контактов",
            "План работ на квартал",
        };

        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            listBoxResults.Items.AddRange(SearchIndex);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string query = textBoxQuery.Text.Trim();
            listBoxResults.Items.Clear();

            var found = string.IsNullOrEmpty(query)
                ? SearchIndex
                : Array.FindAll(SearchIndex, item => item.Contains(query, StringComparison.OrdinalIgnoreCase));

            if (found.Length == 0)
            {
                listBoxResults.Items.Add("Ничего не найдено");
            }
            else
            {
                listBoxResults.Items.AddRange(found);
            }
        }
    }
}
