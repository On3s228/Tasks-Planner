using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Tools
{
    public static class Periodicities
    {
        public static List<string> PeriodsStrings { get; set; }
        public static List<int> PeriodsValues { get; set; }
        public static Dictionary<string, int> GetPeriodsDictionary()
        {
            return PeriodsStrings.Zip(PeriodsValues, (k, v) => new { k, v })
                .ToDictionary(x => x.k, x => x.v);
        }
    }
}
