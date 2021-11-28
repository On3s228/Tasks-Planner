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
        public void AddCategory()
        {
            if (ValidateName())
            {
                Category c = new Category
                {
                    Id = Category.IdCounter++,
                    Name = _view.NameField.Text,
                    Description = _view.DescriptionField.Text
                };
                _categories.Create(c);
                Events.CategoriesListChanged();
            }
            else Notifier.StringNotify?.Invoke(Messages.InvalidName);
        }
    }
}
