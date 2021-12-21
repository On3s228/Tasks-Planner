using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Properties;
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
                string notifyContent = $"{Messages.Notification}\n\n{Messages.NotifyName} {t.Name}\n" +
                    $"{Messages.NotifyDescription} {t.Description}\n{Messages.NotifyTime} {t.TaskDate}";
                if (!_mainForm.Icon.Visible)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(notifyContent, Messages.Notification, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SystemSounds.Hand.Play();
                    _mainForm.Icon.ShowBalloonTip(20000, Messages.Notification, notifyContent, ToolTipIcon.Warning);
                }
            }
        }
    }
}
