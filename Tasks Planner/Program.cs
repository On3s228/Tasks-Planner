
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
            ApplicationConfiguration.Initialize();
            MainForm mainForm = Initializer.InitializeMain();
            Application.Run(mainForm);
        }
    }
}