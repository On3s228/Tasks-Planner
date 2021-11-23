using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos.Tasks
{
    public class UserTask
    {
        private int period;

        public int Period
        {
            get => period;
            set
            {
                if (value != 0)
                {
                    period = value;
                    TimerCallback tc = new TimerCallback(Notifier.GetNotify);
                    Timer = new System.Threading.Timer(tc, this, value, value);
                } else
                {
                    Timer.Dispose();
                }
            }
        }
        [JsonIgnore]
        public System.Threading.Timer Timer { get; set; } //in miliseconds
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskDate { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserTask task &&
                   Id == task.Id &&
                   Name == task.Name &&
                   Description == task.Description &&
                   TaskDate == task.TaskDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Description, TaskDate);
        }
        public UserTask() { }

    }
}
