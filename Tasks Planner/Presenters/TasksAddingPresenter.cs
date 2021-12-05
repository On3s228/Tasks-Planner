using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.TasksCreating;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;
using Tasks_Planner.Tools;

namespace Tasks_Planner.Presenters
{
    public class TasksAddingPresenter
    {
        private readonly ITasksAddingView _view;
        private readonly IRepository<UserTask> _tasks;
        private readonly IRepository<Category> _categories;
        private readonly int[] Periods = { 3600, 7200, 14400, 28800, 43200, 86400, 259200, 604800, 2592000};

        public TasksAddingPresenter(ITasksAddingView view, IRepository<UserTask> tasks, IRepository<Category> categories)
        {
            _view = view;
            _view.Presenter = this;
            _tasks = tasks;
            _categories = categories;

            UpdateCheckedListBox();
        }
        private void UpdateCheckedListBox()
        {
            var categories = (from category in _categories.GetList() select category.Name).ToList();
            foreach (string category in categories)
            {
                _view.CheckedCategories.Items.Add(category, false);
            }
        }
        private bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(_view.NameField.Text) &&
                !string.IsNullOrWhiteSpace(_view.DescriptionField.Text) &&
                _view.Date >= DateTime.Now.AddMinutes(30);
        }
        private void ClearFields()
        {
            _view.NameField.Text = Messages.Empty;
            _view.DescriptionField.Text = Messages.Empty;
            _view.IsPeriodic = default;
            _view.CheckedCategories.ClearSelected();

        }
        public void Add()
        {
            if (IsValid())
            {
                UserTask task = new UserTask
                {
                    Id = ++UserTasks.IdCounter,
                    Name = _view.NameField.Text,
                    Description = _view.DescriptionField.Text,
                    TaskDate = _view.Date,
                    IsHandled = false
                };
                if (_view.IsPeriodic)
                {
                    task.Period = Periods[_view.Periodicity.SelectedIndex];
                }
                List<string> checkedCategoriesNames = new List<string>();
                foreach (var item in _view.CheckedCategories.CheckedItems)
                {
                    checkedCategoriesNames.Add(item.ToString()); 
                }
                var checkedCategories = _categories.GetList().ToList().FindAll(c => checkedCategoriesNames.Contains(c.Name));
                task.CategoriesID = (from category in checkedCategories select category.Id).ToList();
                
                if (_tasks.Create(task))
                {
                    Events.TasksListChanged();
                    ClearFields();
                    Notifier.StringNotify?.Invoke(Messages.TaskAdded);
                } else
                {
                    Notifier.StringNotify?.Invoke(Messages.TaskExists);
                    UserTasks.IdCounter--;
                }
            }
        }
    }
}
