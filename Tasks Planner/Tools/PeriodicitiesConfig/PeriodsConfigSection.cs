using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Tools.PeriodicitiesConfig
{
    public class PeriodsConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("Periods")]
        public PeriodsCollection PeriodsItems
        {
            get
            {
                return (PeriodsCollection)base["Periods"];
            }
        }
    }
}
