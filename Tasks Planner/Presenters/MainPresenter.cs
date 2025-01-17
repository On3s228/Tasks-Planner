﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.CategoriesAdding;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Forms.TasksCreating;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;
using Tasks_Planner.Tools;

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

            _view.PeriodicityCombo.DataSource = Periodicities.PeriodsStrings;

            UpdateTasksList();
            UpdateCheckedListBox();
        }
        public void NewTasksAdding()
        {
            var form = new TaskCreating();
            form.Text = DefaultValues.TaskAddingForm;
            var presenter = new TasksAddingPresenter(form, _tasks, _categories);
            form.ShowDialog();
        }
        public void Save()
        {
            _categories.Save();
            _tasks.Save();
        }
        public void NewCategoryAdding()
        {
            var form = new CategoryAdding();
            var presenter = new CategoriesAddingPresenter(form, _categories);
            form.ShowDialog();
        }

        public void UpdateCheckedListBox()
        {
            _view.Categories.Items.Clear();
            var categories = (from category in _categories.GetCollection() select category.Name).ToList();
            foreach (string category in categories)
            {
                _view.Categories.Items.Add(category, false);
            }
            UpdateTaskView();
        }
        public void UpdateTasksList()
        {
            List<UserTask> tasks = _tasks.GetCollection().ToList();
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

                UserTask task = _tasks.GetByIndex(_view.SelectedTask);
                _view.NameField = task.Name;
                _view.DescriptionField = task.Description;
                _view.Date = task.TaskDate;
                _view.IsPeriodic = task.Period != 0;
                if (_view.IsPeriodic)
                {
                    Dictionary<string, int> Periods = Periodicities.GetPeriodsDictionary();
                    int periodIndex = Periodicities.PeriodsStrings.IndexOf(Periods.FirstOrDefault(x => x.Value == task.Period).Key);
                    _view.PeriodicityCombo.SelectedIndex = periodIndex;
                } else
                {
                    _view.PeriodicityCombo.SelectedIndex = -1;
                }
                List<Category> neededIdCategories = _categories.GetCollection().ToList().FindAll(c => task.CategoriesID.Contains(c.Id));
                List<string> categoriesStrings = (from category in neededIdCategories select category.Name).ToList();
                foreach (string category in categoriesStrings)
                {
                    if (_view.Categories.Items.Contains(category))
                    {
                        int index = _view.Categories.Items.IndexOf(category);
                        _view.Categories.SetItemChecked(index, true);
                    }
                }
                _view.IsDeleteButtonEnabled = true;
                _view.IsEditButtonEnabled = true;
            }
            else
            {
                _view.IsDeleteButtonEnabled = false;
                _view.IsEditButtonEnabled = false;
                _view.NameField = DefaultValues.Empty;
                _view.DescriptionField = DefaultValues.Empty;
                _view.Date = DateTime.MinValue;
                _view.IsPeriodic = false;
                _view.PeriodicityCombo.SelectedIndex = -1;
                for (int i = 0; i < _view.Categories.Items.Count; i++)
                {
                    _view.Categories.SetItemChecked(i, false);
                }
            }
        }
        public void HandleMissed()
        {
            MissedTaskHandler missedTaskHandler = new MissedTaskHandler(_tasks);
            missedTaskHandler.Handle();
            missedTaskHandler.Show();
        }

        public void Edit()
        {
            var form = new TaskCreating();
            form.Text = DefaultValues.TaskEditForm;
            form.Edit = _tasks.GetByIndex(_view.SelectedTask);
            var presenter = new TasksAddingPresenter(form, _tasks, _categories);
            form.ShowDialog();
        }

        public void Delete()
        {
            DialogResult result = MessageBox.Show(Messages.AreYouSureWantDelete, Messages.Attention, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_view.SelectedTask >= 0 && result == DialogResult.Yes)
            {
                _tasks.Delete(_view.SelectedTask);
            }
        }

    }
}
