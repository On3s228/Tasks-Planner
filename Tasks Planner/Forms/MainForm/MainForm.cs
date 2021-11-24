using Newtonsoft.Json;
using System.Media;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Presenters;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner
{
    public partial class MainForm : Form, IMainView
    {
        private static int IdCounter = 1;
        private List<UserTask> tasksList;

        public int SelectedTask 
        { 
            get
            {
                if (tasksView.SelectedIndices.Count > 0)
                {
                    return tasksView.SelectedIndices[tasksView.SelectedIndices.Count - 1];
                }
                else return 0;
            }
            set
            {
                if (tasksView.SelectedIndices.Count > 0)
                {
                    tasksView.SelectedIndices.Clear();
                    tasksView.SelectedIndices.Add(value);
                }
            }
        }
        NotifyIcon IMainView.Icon { get => notifyIcon1; set => notifyIcon1 = value; }
        public ListView TasksView { get => tasksView; set => tasksView = value; }
        public string NameField { get => nameBox.Text; set => nameBox.Text = value; }
        public string DescriptionField { get => descriptionRichBox.Text; set => descriptionRichBox.Text = value; }
        public DateTime Date 
        { 
            get => dateTimePicker1.Value;
            set
            {
                if (value > dateTimePicker1.MinDate && value < dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = value;
                } else
                {
                    dateTimePicker1.Value = dateTimePicker1.MinDate;
                }
            }
        }

        public MainPresenter Presenter { private get; set; }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tasksView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateTaskView();
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