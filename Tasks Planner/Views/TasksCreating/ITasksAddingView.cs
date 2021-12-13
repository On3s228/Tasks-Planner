using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Forms.TasksCreating
{
    public interface ITasksAddingView
    {
        UserTask Edit { get; set; }
        MyTextBox NameField { get; set; }
        MyRichTextBox DescriptionField { get; set; }
        DateTime Date { get; set; }
        bool IsPeriodic { get; set; }
        ComboBox Periodicity { get; set; }
        CheckedListBox CheckedCategories { get; set; }
        TasksAddingPresenter Presenter { set; }
    }
}
