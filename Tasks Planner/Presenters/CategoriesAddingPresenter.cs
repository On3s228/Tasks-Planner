using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.CategoriesAdding;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Tools;

namespace Tasks_Planner.Presenters
{
    public class CategoriesAddingPresenter
    {
        private readonly ICategoriesAddingView _view;
        private readonly IRepository<Category> _categories;

        public CategoriesAddingPresenter(ICategoriesAddingView view, IRepository<Category> categories)
        {
            _view = view;
            _view.Presenter = this;
            _categories = categories;
        }
        private bool ValidateName()
        {
            return !string.IsNullOrWhiteSpace(_view.NameField.Text);
        }
        private void ClearFields()
        {
            _view.NameField.Text = DefaultValues.Empty;
            _view.DescriptionField.Text = DefaultValues.Empty;
        }
        public void AddCategory()
        {
            if (ValidateName())
            {
                Category c = new Category
                {
                    Id = ++Categories.IdCounter,
                    Name = _view.NameField.Text,
                    Description = _view.DescriptionField.Text
                };
                if (_categories.Create(c))
                {
                    //Events.CategoriesListChanged();
                    //ClearFields();
                    _view.Close();
                    Notifier.ShowNotify?.Invoke(CategoriesMessages.CategoryAdded);
                } else
                {
                    Notifier.ShowNotify?.Invoke(CategoriesMessages.CategoryExists);
                    Categories.IdCounter--;
                }
                
            }
            else Notifier.ShowNotify?.Invoke(CategoriesMessages.InvalidName);
        }
    }
}
