namespace lab6_c_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#pragma warning disable WFO5001
            Application.SetColorMode(SystemColorMode.Dark);
#pragma warning restore WFO5001
            Application.Run(new Form1());
        }
    }
}
