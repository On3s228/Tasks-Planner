using Tasks_Planner.Repos;

namespace Tasks_Planner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Notifier.StringNotify += delegate (object ex)
            {
                if (ex is string s)
                {
                    MessageBox.Show(s, "Предупреждение!", MessageBoxButtons.OK);
                }
            };
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}