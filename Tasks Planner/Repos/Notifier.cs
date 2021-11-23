using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos
{
    public class Notifier
    {
        public delegate void NotifierDelegate();
        public static event NotifierDelegate Notify;
        public Notifier()
        {

        }

    }
}
