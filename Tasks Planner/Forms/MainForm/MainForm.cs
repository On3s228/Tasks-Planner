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
            UserTask t = new PeriodicTask(60000)
            {
                Id = IdCounter++,
                Name = "Напоминание",
                Description = "Не забыть, что Вадим пидор",
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
        public void Notify(object periodicTask)
        {
            if (periodicTask is PeriodicTask t)
            {
                notifyIcon1.ShowBalloonTip(10000, t.Name, t.Description, ToolTipIcon.Warning);
            }
        }
    }

}