using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;

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
            MainForm mainForm = new MainForm();
            Notifier.GetNotify += mainForm.Notify;
            var categoriesRepo = new CategoriesRepository(Application.StartupPath);
            Application.Run(mainForm);
        }
    }
}