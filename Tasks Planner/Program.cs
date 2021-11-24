using Tasks_Planner.Presenters;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;

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
            MainViewHelper mainViewHelper = new MainViewHelper(mainForm);
            Notifier.GetNotify += mainViewHelper.Notify;
            var categoriesRepo = new CategoriesRepository(Application.StartupPath);
            var tasksRepo = new TasksRepository(Application.StartupPath, categoriesRepo);
            var presenter = new MainPresenter(mainForm, categoriesRepo, tasksRepo);
            Application.Run(mainForm);
        }
    }
}