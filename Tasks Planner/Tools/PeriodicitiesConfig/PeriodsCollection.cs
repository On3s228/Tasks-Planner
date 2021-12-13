using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Tools.PeriodicitiesConfig
{
    public class PeriodsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PeriodElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PeriodElement)element).PeriodString;
        }
        public PeriodElement this[int id]
        {
            get
            {
                return (PeriodElement) BaseGet(id);
            }
        }
    }
}
