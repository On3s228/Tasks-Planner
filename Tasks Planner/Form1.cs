using System.Windows.Forms;

namespace Tasks_Planner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_Click;
        }

        void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }

}