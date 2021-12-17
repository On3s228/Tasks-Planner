using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Tools;
using Tasks_Planner.Tools.PeriodicitiesConfig;

namespace Tasks_Planner
{
    public class Initializer
    {
        public static void InitializePeriods()
        {
            //aaaaaaaa
            PeriodsConfigSection section = (PeriodsConfigSection) ConfigurationManager.GetSection("PeriodsList");
            Periodicities.PeriodsStrings = new List<string>();
            Periodicities.PeriodsValues = new List<int>();
            foreach (PeriodElement item in section.PeriodsItems)
            {
                Periodicities.PeriodsStrings.Add(item.PeriodString);
                Periodicities.PeriodsValues.Add(item.PeriodSeconds);
            }
        }
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
            InitializePeriods();
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
