using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Tools
{
    public static class Periodicities
    {
        public static List<string> PeriodsStrings { get; private set; } = new List<string>
            {
                "раз в 1 час",
                "раз в 2 часа",
                "раз в 4 часа",
                "раз в 8 часов",
                "раз в 12 часов",
                "раз в 24 часа",
                "раз в 3 дня",
                "раз в неделю",
                "раз в 24 дня"
            };
        public static int[] PeriodsValues { get; private set; } = { 3600, 7200, 14400, 28800, 43200, 86400, 259200, 604800, 2074000 };
        public static Dictionary<string, int> GetPeriodsDictionary()
        {
            return PeriodsStrings.Zip(PeriodsValues, (k, v) => new { k, v })
                .ToDictionary(x => x.k, x => x.v);
        }
    }
}
