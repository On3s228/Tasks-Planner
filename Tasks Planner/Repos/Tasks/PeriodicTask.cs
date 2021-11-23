using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos.Tasks
{
    public class PeriodicTask : UserTask
    {
        public System.Threading.Timer Timer { get; set; } //in miliseconds
        public PeriodicTask(int period)
        {
            TimerCallback tc = new TimerCallback(Notifier.GetNotify);
            Timer = new System.Threading.Timer(tc, this, period, period);
        }
        public void StopPeriod()
        {
            Timer.Dispose();
        }
    }
}
