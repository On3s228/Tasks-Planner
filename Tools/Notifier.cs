using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos
{
    public static class Notifier
    {
        public delegate void Notify(object obj);
        public static Notify TaskNotify;
        public static Notify ShowNotify;

    }
}
