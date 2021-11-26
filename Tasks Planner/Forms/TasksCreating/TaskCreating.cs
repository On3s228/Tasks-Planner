using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks_Planner.Presenters;

namespace Tasks_Planner.Forms.TasksCreating
{
    public partial class TaskCreating : Form, ITasksAddingView
    {
        public TaskCreating()
        {
            InitializeComponent();
        }

        public CheckedListBox CheckedCategories { get => categoriesChecks; set => categoriesChecks = value; }
        public TasksAddingPresenter Presenter { private get; set; }
        public MyTextBox NameField { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public RichTextBox DescriptionField { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Periodicity { get => (List<string>)periodicityCombo.DataSource; set => periodicityCombo.DataSource = value; }

        private void TaskCreating_Load(object sender, EventArgs e)
        {
            periodicityCombo.Items.Add("раз в 30 минут");
            periodicityCombo.Items.Add("раз в 24 часа");
        }

        private void repeatableCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (repeatableCheck.Checked)
            {
                periodicityCombo.Enabled = true;
            }
            else
            {
                if (periodicityCombo.SelectedIndex != -1)
                {
                    periodicityCombo.SelectedIndex = -1;
                }
                periodicityCombo.Enabled = false;
            }
        }
    }
}
