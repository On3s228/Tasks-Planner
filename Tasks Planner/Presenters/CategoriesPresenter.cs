using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Presenters
{
    public class CategoriesPresenter
    {
        private readonly ICategoriesView _view;
        private readonly IRepository<Category> _categories;
        private readonly IRepository<UserTask> _tasks;
        private bool IsEditMode = false;

        public CategoriesPresenter(ICategoriesView view, IRepository<Category> categories, IRepository<UserTask> tasks)
        {
            _view = view;
            _view.CategoriesPresenter = this;
            _categories = categories;
            _tasks = tasks;

            UpdateCategoriesList();
        }
        public void UpdateCategoriesList()
        {
            List<Category> categories = (List<Category>)_categories.GetList();
            int SelectedIndex = _view.SelectedCategory >= 0 ? _view.SelectedCategory : 0;
            _view.CategoriesList.Items.Clear();
            foreach (Category category in categories)
            {
                ListViewItem item = new ListViewItem(category.Id.ToString());
                item.SubItems.Add(category.Name);
                _view.CategoriesList.Items.Add(item);
            }
            _view.SelectedCategory = SelectedIndex;
        }
        public void UpdateCategoryView()
        {
            if (_view.CategoriesList.SelectedIndices.Count > 0)
            {
                Category c = _categories.GetByID(_view.SelectedCategory);
                _view.CategoryName.Text = c.Name;
                _view.Description.Text = c.Description;
            }
            else
            {
                _view.CategoryName.Text = Messages.Empty;
                _view.Description.Text = Messages.Empty;
            }
        }
        private void Save()
        {
            ListViewItem i = _view.CategoriesList.SelectedItems[0];
            Category c = new Category
            {
                Id = Convert.ToInt32(i.SubItems[0].Text),
                Name = _view.CategoryName.Text,
                Description = _view.Description.Text
            };
            _categories.Update(_view.SelectedCategory, c);
        }
        private bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(_view.CategoryName.Text);
        }

        private void ChangeFieldsState(bool state)
        {
            _view.CategoryName.ReadOnly = state;
            _view.Description.ReadOnly = state;

            _view.EditButton.Text = !state ? Messages.Save : Messages.Edit;
        }
        public void Edit()
        {
            if (_view.SelectedCategory != -1)
            {
                IsEditMode = !IsEditMode;
                ChangeFieldsState(!IsEditMode);

                if (IsEditMode) return;

                if (IsValid())
                {
                    Save();
                    UpdateCategoriesList();
                }
                else Notifier.StringNotify?.Invoke(Messages.InvalidName);

            }
            else Notifier.StringNotify?.Invoke(Messages.CategoryNotSelected);
        }
    }
}
