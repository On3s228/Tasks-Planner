using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Tools;

namespace Tasks_Planner
{
    public class Initializer
    {
        public static void InitializeNotifier(MainForm mainForm)
        {
            Notifier.ShowNotify += delegate (object ex)
            {
                if (ex is string s)
                {
                    MessageBox.Show(s, Messages.Attention, MessageBoxButtons.OK);
                }
            };
            MainViewHelper mainViewHelper = new MainViewHelper(mainForm);
            Notifier.TaskNotify += mainViewHelper.Notify;
        }
        public static MainForm InitializeMain()
        {
            MainForm mainForm = new MainForm();
            InitializeNotifier(mainForm);
            Repositories repos = new Repositories(Application.StartupPath);
            var presenter = new MainPresenter(mainForm, repos.CategoriesRepository, repos.TasksRepository);
            var categoriesPresenter = new CategoriesPresenter(mainForm, repos.CategoriesRepository, repos.TasksRepository);
            Events.MainPresenter = presenter;
            Events.CategoriesPresenter = categoriesPresenter;
            return mainForm;
        }
    }
}
