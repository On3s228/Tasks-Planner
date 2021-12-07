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
        private readonly Dictionary<string, int> Periods;

        public TasksAddingPresenter(ITasksAddingView view, IRepository<UserTask> tasks, IRepository<Category> categories)
        {
            _view = view;
            _view.Presenter = this;
            _tasks = tasks;
            _categories = categories;

            _view.Periodicity.DataSource = Periodicities.PeriodsStrings;
            Periods = Periodicities.GetPeriodsDictionary();


            UpdateCheckedListBox();
            if (_view.Edit != null)
            {
                FillFields(_view.Edit);
            }            
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

        private void FillFields(UserTask task)
        {
            _view.NameField.Text = task.Name;
            _view.DescriptionField.Text = task.Description;
            _view.Date = task.TaskDate;
            _view.IsPeriodic = task.Period != 0;
            int periodIndex = Periodicities.PeriodsStrings.IndexOf(Periods.FirstOrDefault(x => x.Value == task.Period).Key);
            _view.Periodicity.SelectedIndex = periodIndex;
                

            List<Category> categories = _categories.GetList().ToList();
            List<Category> categoriesWithNeededId = categories.FindAll(c => task.CategoriesID.Contains(c.Id));
            List<string> categoriesStrings = (from category in categoriesWithNeededId select category.Name).ToList();
            foreach (var category in categoriesStrings)
            {
                if (_view.CheckedCategories.Items.Contains(category))
                {
                    int index = _view.CheckedCategories.Items.IndexOf(category);
                    _view.CheckedCategories.SetItemChecked(index, true);
                }
            }

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
                if (_view.IsPeriodic && _view.Periodicity.SelectedIndex != -1)
                {
                    task.Period = Periods[_view.Periodicity.SelectedItem.ToString()];
                }
                List<string> checkedCategoriesNames = new List<string>();
                foreach (var item in _view.CheckedCategories.CheckedItems)
                {
                    checkedCategoriesNames.Add(item.ToString());
                }
                var checkedCategories = _categories.GetList().ToList().FindAll(c => checkedCategoriesNames.Contains(c.Name));
                task.CategoriesID = (from category in checkedCategories select category.Id).ToList();

                if (_view.Edit == null)
                {
                    if (_tasks.Create(task))
                    {
                        ClearFields();
                        Notifier.StringNotify?.Invoke(Messages.TaskAdded);
                    }
                    else
                    {
                        Notifier.StringNotify?.Invoke(Messages.TaskExists);
                        UserTasks.IdCounter--;
                    }
                }
                else
                {
                    task.Id = _view.Edit.Id;
                    UserTasks.IdCounter--;
                    List<UserTask> tasks = _tasks.GetList().ToList();
                    int index = tasks.IndexOf(_view.Edit);
                    if (_tasks.Update(index, task))
                    {
                        Notifier.StringNotify?.Invoke(Messages.Saved);
                    }
                    else Notifier.StringNotify?.Invoke(Messages.TaskNotUnique);
                    
                }
            }
            else Notifier.GetNotify?.Invoke(Messages.InvalidTaskData);
        }

    }
}
