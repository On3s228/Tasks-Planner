using Tasks_Planner.Presenters;
using Tasks_Planner.Properties;
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
                    MessageBox.Show(s, Messages.Warning, MessageBoxButtons.OK);
                }
            };
            ApplicationConfiguration.Initialize();
            MainForm mainForm = new MainForm();
            MainViewHelper mainViewHelper = new MainViewHelper(mainForm);
            Notifier.GetNotify += mainViewHelper.Notify;
            Repositories repos = new Repositories(Application.StartupPath);
            var presenter = new MainPresenter(mainForm, repos.CategoriesRepository, repos.TasksRepository);
            var categoriesPresenter = new CategoriesPresenter(mainForm, repos.CategoriesRepository, repos.TasksRepository);
            Application.Run(mainForm);
        }
    }
}