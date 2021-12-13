using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Tools.PeriodicitiesConfig
{
    public class PeriodElement : ConfigurationElement
    {
        [ConfigurationProperty("periodString", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string PeriodString
        {
            get
            {
                return (string) base["periodString"];
            }
            set
            {
                base["periodString"] = value;
            }
        }
        [ConfigurationProperty("periodSeconds", DefaultValue = 0, IsKey = false, IsRequired = true)]
        public int PeriodSeconds
        {
            get
            {
                return (int)base["periodSeconds"];
            }
            set
            {
                base["periodSeconds"] = value.ToString();
            }
        }
    }
}
