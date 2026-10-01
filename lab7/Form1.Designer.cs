namespace lab7_c_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileNew;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileSaveAs;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem menuEdit;
        private ToolStripMenuItem menuEditUndo;
        private ToolStripMenuItem menuEditCopy;
        private ToolStripMenuItem menuEditCut;
        private ToolStripMenuItem menuEditPaste;
        private ToolStripMenuItem menuFormat;
        private ToolStripMenuItem menuFormatFont;
        private ToolStripMenuItem menuFormatColor;
        private ToolStripMenuItem menuFormatAlign;
        private ToolStripMenuItem menuAlignLeft;
        private ToolStripMenuItem menuAlignCenter;
        private ToolStripMenuItem menuAlignRight;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuHelpAbout;

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonCut;
        private ToolStripButton toolStripButtonCopy;
        private ToolStripButton toolStripButtonPaste;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelState;
        private ToolStripStatusLabel statusLabelCharCount;
        private ToolStripStatusLabel statusLabelOperation;

        private ContextMenuStrip contextMenuStripEditor;
        private ToolStripMenuItem contextMenuCut;
        private ToolStripMenuItem contextMenuCopy;
        private ToolStripMenuItem contextMenuPaste;

        private RichTextBox richTextBox1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.menuStrip1 = new MenuStrip();
            this.menuFile = new ToolStripMenuItem();
            this.menuFileNew = new ToolStripMenuItem();
            this.menuFileOpen = new ToolStripMenuItem();
            this.menuFileSave = new ToolStripMenuItem();
            this.menuFileSaveAs = new ToolStripMenuItem();
            this.menuFileExit = new ToolStripMenuItem();
            this.menuEdit = new ToolStripMenuItem();
            this.menuEditUndo = new ToolStripMenuItem();
            this.menuEditCopy = new ToolStripMenuItem();
            this.menuEditCut = new ToolStripMenuItem();
            this.menuEditPaste = new ToolStripMenuItem();
            this.menuFormat = new ToolStripMenuItem();
            this.menuFormatFont = new ToolStripMenuItem();
            this.menuFormatColor = new ToolStripMenuItem();
            this.menuFormatAlign = new ToolStripMenuItem();
            this.menuAlignLeft = new ToolStripMenuItem();
            this.menuAlignCenter = new ToolStripMenuItem();
            this.menuAlignRight = new ToolStripMenuItem();
            this.menuHelp = new ToolStripMenuItem();
            this.menuHelpAbout = new ToolStripMenuItem();

            this.toolStrip1 = new ToolStrip();
            this.toolStripButtonNew = new ToolStripButton();
            this.toolStripButtonOpen = new ToolStripButton();
            this.toolStripButtonSave = new ToolStripButton();
            this.toolStripButtonCut = new ToolStripButton();
            this.toolStripButtonCopy = new ToolStripButton();
            this.toolStripButtonPaste = new ToolStripButton();

            this.statusStrip1 = new StatusStrip();
            this.statusLabelState = new ToolStripStatusLabel();
            this.statusLabelCharCount = new ToolStripStatusLabel();
            this.statusLabelOperation = new ToolStripStatusLabel();

            this.contextMenuStripEditor = new ContextMenuStrip(this.components);
            this.contextMenuCut = new ToolStripMenuItem();
            this.contextMenuCopy = new ToolStripMenuItem();
            this.contextMenuPaste = new ToolStripMenuItem();

            this.richTextBox1 = new RichTextBox();

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripEditor.SuspendLayout();
            this.SuspendLayout();
            //
            // menuFile
            //
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Text = "Создать";
            this.menuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            this.menuFileNew.Click += new EventHandler(this.menuFileNew_Click);

            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Text = "Открыть...";
            this.menuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            this.menuFileOpen.Click += new EventHandler(this.menuFileOpen_Click);

            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Text = "Сохранить";
            this.menuFileSave.ShortcutKeys = Keys.Control | Keys.S;
            this.menuFileSave.Click += new EventHandler(this.menuFileSave_Click);

            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Text = "Сохранить как...";
            this.menuFileSaveAs.Click += new EventHandler(this.menuFileSaveAs_Click);

            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Text = "Выход";
            this.menuFileExit.Click += new EventHandler(this.menuFileExit_Click);

            this.menuFile.Name = "menuFile";
            this.menuFile.Text = "Файл";
            this.menuFile.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuFileNew,
                this.menuFileOpen,
                this.menuFileSave,
                this.menuFileSaveAs,
                new ToolStripSeparator(),
                this.menuFileExit });
            //
            // menuEdit
            //
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.Text = "Отменить";
            this.menuEditUndo.ShortcutKeys = Keys.Control | Keys.Z;
            this.menuEditUndo.Click += new EventHandler(this.menuEditUndo_Click);

            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Text = "Копировать";
            this.menuEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            this.menuEditCopy.Click += new EventHandler(this.menuEditCopy_Click);

            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Text = "Вырезать";
            this.menuEditCut.ShortcutKeys = Keys.Control | Keys.X;
            this.menuEditCut.Click += new EventHandler(this.menuEditCut_Click);

            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Text = "Вставить";
            this.menuEditPaste.ShortcutKeys = Keys.Control | Keys.V;
            this.menuEditPaste.Click += new EventHandler(this.menuEditPaste_Click);

            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Text = "Правка";
            this.menuEdit.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuEditUndo,
                new ToolStripSeparator(),
                this.menuEditCopy,
                this.menuEditCut,
                this.menuEditPaste });
            //
            // menuFormat
            //
            this.menuFormatFont.Name = "menuFormatFont";
            this.menuFormatFont.Text = "Шрифт...";
            this.menuFormatFont.Click += new EventHandler(this.menuFormatFont_Click);

            this.menuFormatColor.Name = "menuFormatColor";
            this.menuFormatColor.Text = "Цвет...";
            this.menuFormatColor.Click += new EventHandler(this.menuFormatColor_Click);

            this.menuAlignLeft.Name = "menuAlignLeft";
            this.menuAlignLeft.Text = "По левому краю";
            this.menuAlignLeft.Click += new EventHandler(this.menuAlignLeft_Click);

            this.menuAlignCenter.Name = "menuAlignCenter";
            this.menuAlignCenter.Text = "По центру";
            this.menuAlignCenter.Click += new EventHandler(this.menuAlignCenter_Click);

            this.menuAlignRight.Name = "menuAlignRight";
            this.menuAlignRight.Text = "По правому краю";
            this.menuAlignRight.Click += new EventHandler(this.menuAlignRight_Click);

            this.menuFormatAlign.Name = "menuFormatAlign";
            this.menuFormatAlign.Text = "Выравнивание";
            this.menuFormatAlign.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuAlignLeft,
                this.menuAlignCenter,
                this.menuAlignRight });

            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Text = "Формат";
            this.menuFormat.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuFormatFont,
                this.menuFormatColor,
                this.menuFormatAlign });
            //
            // menuHelp
            //
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Text = "О программе";
            this.menuHelpAbout.Click += new EventHandler(this.menuHelpAbout_Click);

            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Text = "Справка";
            this.menuHelp.DropDownItems.AddRange(new ToolStripItem[] { this.menuHelpAbout });
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.menuFile,
                this.menuEdit,
                this.menuFormat,
                this.menuHelp });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            //
            // toolStrip1
            //
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Text = "Новый";
            this.toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNew.Click += new EventHandler(this.menuFileNew_Click);

            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Text = "Открыть";
            this.toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Click += new EventHandler(this.menuFileOpen_Click);

            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Click += new EventHandler(this.menuFileSave_Click);

            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Text = "Вырезать";
            this.toolStripButtonCut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCut.Click += new EventHandler(this.menuEditCut_Click);

            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Text = "Копировать";
            this.toolStripButtonCopy.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopy.Click += new EventHandler(this.menuEditCopy_Click);

            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Text = "Вставить";
            this.toolStripButtonPaste.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPaste.Click += new EventHandler(this.menuEditPaste_Click);

            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
                this.toolStripButtonNew,
                this.toolStripButtonOpen,
                this.toolStripButtonSave,
                new ToolStripSeparator(),
                this.toolStripButtonCut,
                this.toolStripButtonCopy,
                this.toolStripButtonPaste });
            this.toolStrip1.Location = new Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            //
            // statusStrip1
            //
            this.statusLabelState.Name = "statusLabelState";
            this.statusLabelState.Text = "Документ не изменён";
            this.statusLabelState.Spring = true;
            this.statusLabelState.TextAlign = ContentAlignment.MiddleLeft;

            this.statusLabelCharCount.Name = "statusLabelCharCount";
            this.statusLabelCharCount.Text = "Символов: 0";
            this.statusLabelCharCount.BorderSides = ToolStripStatusLabelBorderSides.Left;
            this.statusLabelCharCount.AutoSize = true;

            this.statusLabelOperation.Name = "statusLabelOperation";
            this.statusLabelOperation.Text = "Готово";
            this.statusLabelOperation.BorderSides = ToolStripStatusLabelBorderSides.Left;
            this.statusLabelOperation.AutoSize = true;

            this.statusStrip1.Items.AddRange(new ToolStripItem[] {
                this.statusLabelState,
                this.statusLabelCharCount,
                this.statusLabelOperation });
            this.statusStrip1.Location = new Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            //
            // contextMenuStripEditor
            //
            this.contextMenuCut.Name = "contextMenuCut";
            this.contextMenuCut.Text = "Вырезать";
            this.contextMenuCut.Click += new EventHandler(this.menuEditCut_Click);

            this.contextMenuCopy.Name = "contextMenuCopy";
            this.contextMenuCopy.Text = "Копировать";
            this.contextMenuCopy.Click += new EventHandler(this.menuEditCopy_Click);

            this.contextMenuPaste.Name = "contextMenuPaste";
            this.contextMenuPaste.Text = "Вставить";
            this.contextMenuPaste.Click += new EventHandler(this.menuEditPaste_Click);

            this.contextMenuStripEditor.Items.AddRange(new ToolStripItem[] {
                this.contextMenuCut,
                this.contextMenuCopy,
                this.contextMenuPaste });
            this.contextMenuStripEditor.Name = "contextMenuStripEditor";
            this.contextMenuStripEditor.Size = new Size(160, 70);
            //
            // richTextBox1
            //
            this.richTextBox1.ContextMenuStrip = this.contextMenuStripEditor;
            this.richTextBox1.Dock = DockStyle.Fill;
            this.richTextBox1.Font = new Font("Consolas", 11F);
            this.richTextBox1.Location = new Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(800, 379);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new Size(560, 360);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Без имени — Текстовый редактор";
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
