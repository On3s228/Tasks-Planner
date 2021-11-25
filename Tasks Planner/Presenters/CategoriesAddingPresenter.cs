using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.CategoriesAdding;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;

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
        public void ValidateName()
        {

        }
    }
}
