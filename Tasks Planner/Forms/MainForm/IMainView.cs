using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;

namespace Tasks_Planner.Forms.MainForm
{
    public interface IMainView
    {
        int SelectedTask { get; set; }
        NotifyIcon Icon { get; set; }
        ListView TasksView { get; set; }
        string NameField { get; set; }
        string DescriptionField { get; set; }
        DateTime Date { get; set; }
        MainPresenter Presenter { set; }
    }
}
