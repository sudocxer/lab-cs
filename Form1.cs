namespace lab4_c_
{
    public partial class Form1 : Form
    {
        private FormInfo? formInfo;
        private FormSettings? formSettings;
        private FormSearch? formSearch;
        private FormLog? formLog;
        private FormHelp? formHelp;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowAt(Form form, int offsetX, int offsetY)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Left + offsetX, this.Top + offsetY);
            form.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (formInfo == null || formInfo.IsDisposed)
            {
                formInfo = new FormInfo();
                ShowAt(formInfo, 390, 0);
            }
            else
            {
                formInfo.Activate();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (formSettings == null || formSettings.IsDisposed)
            {
                formSettings = new FormSettings();
                ShowAt(formSettings, 760, 0);
            }
            else
            {
                formSettings.Activate();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (formSearch == null || formSearch.IsDisposed)
            {
                formSearch = new FormSearch();
                ShowAt(formSearch, 1140, 0);
            }
            else
            {
                formSearch.Activate();
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (formLog == null || formLog.IsDisposed)
            {
                formLog = new FormLog();
                ShowAt(formLog, 390, 280);
            }
            else
            {
                formLog.Activate();
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            if (formHelp == null || formHelp.IsDisposed)
            {
                formHelp = new FormHelp();
                ShowAt(formHelp, 760, 280);
            }
            else
            {
                formHelp.Activate();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
