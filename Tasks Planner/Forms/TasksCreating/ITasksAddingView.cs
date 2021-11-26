using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;

namespace Tasks_Planner.Forms.TasksCreating
{
    public interface ITasksAddingView
    {
        CheckedListBox CheckedCategories { get; set; }
        TasksAddingPresenter Presenter { set; }
    }
}
