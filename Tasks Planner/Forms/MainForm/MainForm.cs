using Newtonsoft.Json;
using System.Media;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner
{
    public partial class MainForm : Form
    {
        private static int IdCounter = 1;
        private List<UserTask> tasksList;
        public MainForm()
        {
            InitializeComponent();

            //ShowInTaskbar = false;
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            
            dateTimePicker1.CustomFormat = "dd MMMM yyyy, HH:mm:ss";
            tasksList = new List<UserTask>();

            Notifier.GetNotify += Notify;
        }

        private void NotifyIcon1_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                Thread.Sleep(2000);
                
            }
        }
        public void TaskToItem(UserTask t)
        {
            ListViewItem i = new ListViewItem(t.Id.ToString());
            i.SubItems.Add(t.Name);
            tasksView.Items.Add(i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tasksView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksView.SelectedIndices.Count > 0)
            {
                int SelectedIndex = tasksView.SelectedIndices[tasksView.SelectedIndices.Count - 1];
                nameBox.Text = tasksList[SelectedIndex].Name;
                descriptionRichBox.Text = tasksList[SelectedIndex].Description;
                dateTimePicker1.Value = tasksList[SelectedIndex].TaskDate;
            } else
            {
                nameBox.Text = "";
                descriptionRichBox.Text = "";
                dateTimePicker1.Value = dateTimePicker1.MinDate;
            }
        }
        public void Notify(object userTask)
        {
            if (userTask is UserTask t)
            {
                if (Visible)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(t.Description, t.Name, MessageBoxButtons.OK);
                } else
                {
                    SystemSounds.Hand.Play();
                    notifyIcon1.ShowBalloonTip(10000, t.Name, t.Description, ToolTipIcon.Warning);
                }
            }
        }
    }

}