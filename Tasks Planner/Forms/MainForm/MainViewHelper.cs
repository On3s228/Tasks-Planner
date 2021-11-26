using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Presenters
{
    public class MainViewHelper
    {
        private readonly IMainView _mainForm;

        public MainViewHelper(IMainView mainForm)
        {
            _mainForm = mainForm;
        }
        public void Notify(object userTask)
        {
            if (userTask is UserTask t)
            {
                if (_mainForm.IsVisible)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(t.Description, t.Name, MessageBoxButtons.OK);
                }
                else
                {
                    SystemSounds.Hand.Play();
                    _mainForm.Icon.ShowBalloonTip(10000, t.Name, t.Description, ToolTipIcon.Warning);
                }
            }
        }
    }
}
