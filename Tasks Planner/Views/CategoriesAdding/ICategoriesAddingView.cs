using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;

namespace Tasks_Planner.Forms.CategoriesAdding
{
    public interface ICategoriesAddingView
    {
        MyTextBox NameField { get; set; }
        RichTextBox DescriptionField { get; set; }
        void Close();
        CategoriesAddingPresenter Presenter { set; }
    }
}
