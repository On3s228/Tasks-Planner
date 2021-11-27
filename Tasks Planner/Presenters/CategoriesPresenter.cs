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

        public CategoriesPresenter(ICategoriesView view, IRepository<Category> categories, IRepository<UserTask> tasks)
        {
            _view = view;
            _view.CategoriesPresenter = this;
            _categories = categories;
            _tasks = tasks;

            UpdateCategoriesList();
        }
        private void UpdateCategoriesList()
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
    }
}
