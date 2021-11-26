using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.TasksCreating;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Presenters
{
    public class TasksAddingPresenter
    {
        private readonly ITasksAddingView _view;
        private readonly IRepository<UserTask> _tasks;
        private readonly IRepository<Category> _categories;

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
    }
}
