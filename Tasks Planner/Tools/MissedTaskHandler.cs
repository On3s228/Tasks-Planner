using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Tools
{
    public class MissedTaskHandler
    {
        private readonly IRepository<UserTask> _tasksRepo;
        private string _result;
        private bool _isHandled;
        private int counter;
        public MissedTaskHandler(IRepository<UserTask> tasksRepo)
        {
            _tasksRepo = tasksRepo;
            _isHandled = false;
            _result = TasksMessages.MissedTasks + "\n";
            counter = 0;
        }
        public void Show()
        {
            if (_isHandled && counter != 0)
            {
                MessageBox.Show(_result, TasksMessages.MissedTasks, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
        public void Handle()
        {
            HandleNonPeriodic();
            HandlePeriodic();
            _isHandled = true;
        }
        private void HandleNonPeriodic()
        {
            List<UserTask> tasks = _tasksRepo.GetCollection().ToList();
            foreach (UserTask task in tasks)
            {
                if (task.Period == 0 && !task.IsHandled && DateTime.Now >= task.TaskDate)
                {
                    counter++;
                    task.IsHandled = true;
                    _result += $"Название: {task.Name}\nОписание: {task.Description}\nДата: {task.TaskDate}\n\n";
                }
            }
        }
        private void HandlePeriodic()
        {
            _result += TasksMessages.MissedPeriodic + "\n";
            List<UserTask> tasks = _tasksRepo.GetCollection().ToList();
            foreach (UserTask task in tasks)
            {
                if (task.Period != 0)
                {
                    DateTime now = DateTime.Now;
                    DateTime lastTick = task.LastTick;
                    TimeSpan sub = now.Subtract(lastTick);
                    int missedTime = Convert.ToInt32(sub.TotalSeconds);
                    if (missedTime >= task.Period)
                    {
                        counter++;
                        task.LastTick = DateTime.Now;
                        _result += $"{Messages.NotifyName} {task.Name}\n" +
                            $"{Messages.NotifyDescription} {task.Description}\n{Messages.NotifyTime}: {task.TaskDate}\n\n";
                    }
                }
            }
        }
    }
}
