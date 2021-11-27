using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;

namespace Tasks_Planner.Forms.MainForm
{
    public interface ICategoriesView
    {
        int SelectedCategory { get; set; }
        ListView CategoriesList { get; set; }
        TextBox CategoryName { get; set; }
        RichTextBox Description { get; set; }
        Button EditButton { get; set; }
        CategoriesPresenter CategoriesPresenter { set; }
    }
}
