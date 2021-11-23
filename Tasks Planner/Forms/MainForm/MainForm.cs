using System.Windows.Forms;
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
                //notifyIcon1.ShowBalloonTip(10000, "Аттентион", "Вадим", ToolTipIcon.Warning);
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
            UserTask t = new UserTask
            {
                Id = IdCounter++,
                Name = "Попить воды",
                Description = "Не забыть попить воды в 19:30",
                TaskDate = new DateTime(2021, 11, 23, 19, 30, 0)
            };
            tasksList.Add(t);
            TaskToItem(t);
        }

        private void tasksView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksView.SelectedIndices.Count > 0)
            {
                int SelectedIndex = tasksView.SelectedIndices[0];
                nameBox.Text = tasksList[SelectedIndex].Name;
                descriptionRichBox.Text = tasksList[SelectedIndex].Description;
                dateTimePicker1.Value = tasksList[SelectedIndex].TaskDate;
            } else
            {
                tasksView.SelectedIndices.Add(0);
            }
        }
    }

}