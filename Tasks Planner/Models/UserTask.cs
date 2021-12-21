using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Categories;

namespace Tasks_Planner.Repos.Tasks
{
    public class UserTasks
    {
        public ObservableCollection<UserTask> TasksList { get; set; }
        [JsonProperty]
        public static int IdCounter { get; set; }
        public UserTasks() { }
    }
    public class UserTask : IEquatable<UserTask>, IDisposable
    {

        private int period;
        private DateTime taskDate;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskDate
        {
            get => taskDate;
            set
            {
                taskDate = value;
                DefaultTimer = new System.Windows.Forms.Timer();
                DefaultTimer.Interval = 60000;
                DefaultTimer.Tick += DefaultTimer_Tick;
                DefaultTimer.Enabled = true;
            }
        }
        public int Period
        {
            get => period;
            set
            {
                if (value > 0)
                {
                    period = value;
                    if (LastTick == DateTime.MinValue)
                    {
                        LastTick = DateTime.Now;
                    }
                    PeriodicTimer = new System.Windows.Forms.Timer();
                    //because setter gets value in seconds, but Timer.Interval needs miliseconds
                    PeriodicTimer.Interval = value * 1000;
                    PeriodicTimer.Tick += PeriodicTimer_Tick;
                    PeriodicTimer.Start();

                }
                else
                {
                    if (PeriodicTimer != null)
                    {
                        PeriodicTimer.Dispose();
                    }
                }
            }
        }
        public DateTime LastTick { get; set; }
        public List<int> CategoriesID { get; set; }
        public bool IsHandled { get; set; }

        [JsonIgnore]
        private System.Windows.Forms.Timer PeriodicTimer { get; set; } //in miliseconds
        [JsonIgnore]
        private System.Windows.Forms.Timer DefaultTimer { get; set; }

        private void DefaultTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= taskDate && !IsHandled)
            {
                Notifier.TaskNotify?.Invoke(this);
                IsHandled = true;
                DefaultTimer.Dispose();
            }
        }


        private void PeriodicTimer_Tick(object sender, EventArgs e)
        {
            Notifier.TaskNotify?.Invoke(this);
            LastTick = DateTime.Now;
        }

        public UserTask() { }

        public override bool Equals(object obj)
        {
            return Equals(obj as UserTask);
        }

        public bool Equals(UserTask other)
        {
            return other != null &&
                other.Id != Id &&
                (other.Name == Name || other.Description == Description);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description, TaskDate);
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Period = 0;
                    PeriodicTimer = null;
                    DefaultTimer.Dispose();
                    DefaultTimer = null;
                    Id = 0;
                    Name = null;
                    Description = null;
                    TaskDate = DateTime.MinValue;
                    LastTick = DateTime.MinValue;
                    CategoriesID = null;
                    IsHandled = false;
                }
                disposed = true;
            }
        }

        public static bool operator ==(UserTask left, UserTask right)
        {
            return EqualityComparer<UserTask>.Default.Equals(left, right);
        }

        public static bool operator !=(UserTask left, UserTask right)
        {
            return !(left == right);
        }

    }
}
