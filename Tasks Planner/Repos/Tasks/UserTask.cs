using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos.Tasks
{
    public class UserTask : IEquatable<UserTask?>
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
                    if (Timer != null)
                    {
                        Timer.Dispose();
                    }
                }
            }
        }
        [JsonIgnore]
        public System.Threading.Timer Timer { get; set; } //in miliseconds
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskDate { get; set; }

        public UserTask() { }

        public override bool Equals(object? obj)
        {
            return Equals(obj as UserTask);
        }

        public bool Equals(UserTask? other)
        {
            return other != null &&
                   Name == other.Name &&
                   Description == other.Description &&
                   TaskDate == other.TaskDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description, TaskDate);
        }

        public static bool operator ==(UserTask? left, UserTask? right)
        {
            return EqualityComparer<UserTask>.Default.Equals(left, right);
        }

        public static bool operator !=(UserTask? left, UserTask? right)
        {
            return !(left == right);
        }
    }
}
