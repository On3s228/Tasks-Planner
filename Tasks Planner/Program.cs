

using Serilog;
using Tasks_Planner.Tools;

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
            JSerializer<Dictionary<string, int>>.Serialize(Periodicities.GetPeriodsDictionary(), "dic.json");
            ApplicationConfiguration.Initialize();
            MainForm mainForm = Initializer.InitializeMain();
            Application.Run(mainForm);
        }
    }
}