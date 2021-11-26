using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.CategoriesAdding;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Forms.TasksCreating;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IRepository<Category> _categories;
        private readonly IRepository<UserTask> _tasks;

        public MainPresenter(IMainView view, IRepository<Category> categories, IRepository<UserTask> tasks)
        {
            _view = view;
            _view.Presenter = this;
            _categories = categories;
            _tasks = tasks;

            UpdateTasksList();
        }

        //public IRepository<Category> GetCategoriesRepository()
        //{
        //    return _categories;
        //}
        //public IRepository<UserTask> GetTasksRepository()
        //{
        //    return _tasks;
        //}
        public void NewTasksAdding()
        {
            var form = new TaskCreating();
            var presenter = new TasksAddingPresenter(form, _tasks, _categories);
            form.ShowDialog();
        }
        public void NewCategoryAdding()
        {
            var form = new CategoryAdding();
            var presenter = new CategoriesAddingPresenter(form, _categories);
            form.ShowDialog();
        }
        public void UpdateTasksList()
        {
            List<UserTask> tasks = (List<UserTask>)_tasks.GetList();
            int SelectedIndex = _view.SelectedTask >= 0 ? _view.SelectedTask : 0;
            _view.TasksView.Items.Clear();
            foreach (UserTask task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Id.ToString());
                item.SubItems.Add(task.Name);
                _view.TasksView.Items.Add(item);
            }
            _view.SelectedTask = SelectedIndex;
        }
        public void UpdateTaskView()
        {
            if (_view.TasksView.SelectedIndices.Count > 0)
            {
                UserTask task = _tasks.GetByID(_view.SelectedTask);
                _view.NameField = task.Name;
                _view.DescriptionField = task.Description;
                _view.Date = task.TaskDate;
            }
            else
            {
                _view.NameField = "";
                _view.DescriptionField = "";
                _view.Date = DateTime.MinValue;
            }
        }

    }
}
