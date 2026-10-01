namespace lab7_c_
{
    public partial class Form1 : Form
    {
        private string? currentFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ConfirmDiscardChanges()
        {
            if (!richTextBox1.Modified)
            {
                return true;
            }

            DialogResult result = MessageBox.Show(
                "Сохранить изменения в документе?",
                "Текстовый редактор",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return false;
            }

            if (result == DialogResult.Yes)
            {
                return SaveFile(false);
            }

            return true;
        }

        private void UpdateTitle()
        {
            string name = currentFilePath != null ? Path.GetFileName(currentFilePath) : "Без имени";
            string marker = richTextBox1.Modified ? "*" : "";
            Text = $"{marker}{name} — Текстовый редактор";
        }

        private void UpdateStatus()
        {
            statusLabelState.Text = richTextBox1.Modified ? "Документ изменён" : "Документ не изменён";
            statusLabelCharCount.Text = $"Символов: {richTextBox1.TextLength}";
        }

        private void SetOperation(string text)
        {
            statusLabelOperation.Text = text;
        }

        private bool SaveFile(bool forceDialog)
        {
            string? path = currentFilePath;

            if (forceDialog || path == null)
            {
                using SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt|RTF-файлы (*.rtf)|*.rtf",
                    FileName = path != null ? Path.GetFileName(path) : "Документ.txt",
                };

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return false;
                }

                path = dialog.FileName;
            }

            if (Path.GetExtension(path).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
            {
                richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);
            }
            else
            {
                File.WriteAllText(path, richTextBox1.Text);
            }

            currentFilePath = path;
            richTextBox1.Modified = false;
            UpdateTitle();
            UpdateStatus();
            SetOperation($"Сохранено: {Path.GetFileName(path)}");
            return true;
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardChanges())
            {
                return;
            }

            richTextBox1.Clear();
            currentFilePath = null;
            richTextBox1.Modified = false;
            UpdateTitle();
            UpdateStatus();
            SetOperation("Создан новый документ");
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardChanges())
            {
                return;
            }

            using OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|RTF-файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*",
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            if (Path.GetExtension(dialog.FileName).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
            {
                richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.Text = File.ReadAllText(dialog.FileName);
            }

            currentFilePath = dialog.FileName;
            richTextBox1.Modified = false;
            UpdateTitle();
            UpdateStatus();
            SetOperation($"Открыт файл: {Path.GetFileName(dialog.FileName)}");
        }

        private void menuFileSave_Click(object sender, EventArgs e) => SaveFile(false);

        private void menuFileSaveAs_Click(object sender, EventArgs e) => SaveFile(true);

        private void menuFileExit_Click(object sender, EventArgs e) => Close();

        private void menuEditUndo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
                SetOperation("Отменено последнее действие");
            }
        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
                SetOperation("Скопировано в буфер обмена");
            }
        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
                SetOperation("Вырезано в буфер обмена");
            }
        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            SetOperation("Вставлено из буфера обмена");
        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            using FontDialog dialog = new FontDialog
            {
                Font = richTextBox1.SelectionFont ?? richTextBox1.Font,
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dialog.Font;
                SetOperation("Изменён шрифт");
            }
        }

        private void menuFormatColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new ColorDialog
            {
                Color = richTextBox1.SelectionColor,
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.SelectionColor = dialog.Color;
                SetOperation("Изменён цвет текста");
            }
        }

        private void menuAlignLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            SetOperation("Выравнивание по левому краю");
        }

        private void menuAlignCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            SetOperation("Выравнивание по центру");
        }

        private void menuAlignRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            SetOperation("Выравнивание по правому краю");
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Текстовый редактор\nЛабораторная работа №7\n\n" +
                "Демонстрация MenuStrip, ToolStrip и StatusStrip в Windows Forms.",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
            UpdateTitle();

            if (richTextBox1.Modified)
            {
                SetOperation("Редактирование текста");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ConfirmDiscardChanges();
        }
    }
}
