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
            UserTask t = new UserTask
            {
                Id = IdCounter++,
                Name = "Напоминание",
                Description = "Не забыть, что Вадим пидор",
                TaskDate = new DateTime(2021, 11, 23, 19, 30, 0)
            };
            t.Period = 30000;
            tasksList.Add(t);
            TaskToItem(t);
            UserTask t1 = new UserTask
            {
                Id = IdCounter++,
                Name = "Напоминание",
                Description = "Тестовое напоминание",
                TaskDate = new DateTime(2022, 11, 24)
            };
            tasksList.Add(t1);
            TaskToItem(t1);
            //string test = JsonSerializer.Serialize(tasksList, new JsonSerializerOptions 
            //{
            //    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            //    WriteIndented = true
            //});
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\test.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, tasksList);
            }
            List<UserTask> test;
            using (StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\test.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                test = serializer.Deserialize<List<UserTask>>(reader);
            }
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