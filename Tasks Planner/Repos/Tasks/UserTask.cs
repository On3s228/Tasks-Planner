using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos.Tasks
{
    public class UserTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskDate { get; set; }
        //private System.Threading.Timer _timer;
        //public void SetNotifyInterval(int seconds)
        //{
        //    _timer = new System.Threading.Timer();
        //}
       
    }
}
