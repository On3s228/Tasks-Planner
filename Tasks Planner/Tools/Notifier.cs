using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos
{
    public static class Notifier
    {
        public delegate void Notify(object obj);
        public static Notify TaskNotify;
        public static Notify ShowNotify;

    }
}
