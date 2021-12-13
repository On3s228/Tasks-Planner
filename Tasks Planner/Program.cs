

using Serilog;
using System.Configuration;
using Tasks_Planner.Tools;
using Tasks_Planner.Tools.PeriodicitiesConfig;

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
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();


            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            PeriodsConfigSection section = (PeriodsConfigSection)cfg.GetSection("PeriodsList");

            string res = "";
            foreach (PeriodElement item in section.PeriodsItems)
            {
                res += $"{item.PeriodString} - {item.PeriodSeconds}\n";
            }
            MessageBox.Show(res);


            JSerializer<Dictionary<string, int>>.Serialize(Periodicities.GetPeriodsDictionary(), "dic.json");
            ApplicationConfiguration.Initialize();
            MainForm mainForm = Initializer.InitializeMain();
            Application.Run(mainForm);
        }
    }
}