using System.Windows.Forms;

namespace Tasks_Planner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //ShowInTaskbar = false;
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            
            testSave.Click += TestSave_Click;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy, HH:mm:ss";
        }

        private void TestSave_Click(object? sender, EventArgs e)
        {
            DateTime m = dateTimePicker1.Value;
            MessageBox.Show(m.ToString());
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
                notifyIcon1.ShowBalloonTip(10000, "Аттентион", "Вадим пидор", ToolTipIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }

}