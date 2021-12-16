using Newtonsoft.Json;
using System;
using System.Media;
using System.Windows.Forms;
using Tasks_Planner.Forms.CategoriesAdding;
using Tasks_Planner.Forms.MainForm;
using Tasks_Planner.Presenters;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner
{
    public partial class MainForm : Form, IMainView, ICategoriesView
    {
        #region IMainView
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
                if (tasksView.Items.Count > value)
                {
                    tasksView.SelectedIndices.Clear();
                    tasksView.Items[value].Selected = true; 
                } else
                {
                    tasksView.SelectedIndices.Clear();
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
        public bool IsPeriodic { get => repeatableCheck.Checked; set => repeatableCheck.Checked = value; }
        public ComboBox PeriodicityCombo { get => periodicityCombo; set => periodicityCombo = value; }
        public CheckedListBox Categories { get => categoriesChecks; set => categoriesChecks = value; }
        public MainPresenter Presenter { private get; set; }
        public bool IsVisible { get => Visible; set => Visible = value; }
        public bool IsEditButtonEnabled { get => taskEditButton.Enabled; set => taskEditButton.Enabled = value; }
        public bool IsDeleteButtonEnabled { get => taskDeleteButton.Enabled; set => taskDeleteButton.Enabled = value; }
        #endregion
        #region ICategoriesView
        public int SelectedCategory
        {
            get
            {
                if (categoriesListView.SelectedIndices.Count > 0)
                {
                    return categoriesListView.SelectedIndices[categoriesListView.SelectedIndices.Count - 1];
                }
                else return -1;
            }
            set
            {
                if (categoriesListView.Items.Count > value)
                {
                    categoriesListView.SelectedIndices.Clear();
                    categoriesListView.Items[value].Selected = true; 
                } else
                {
                    categoriesListView.SelectedIndices.Clear();
                }
            }
        }
        public ListView CategoriesList { get => categoriesListView; set => categoriesListView = value; }
        public MyTextBox CategoryName { get => categoryNameBox; set => categoryNameBox = value; }
        public RichTextBox Description { get => categoryDescRich; set => categoryDescRich = value; }
        public CategoriesPresenter CategoriesPresenter { private get; set; }
        public Button EditButton { get => editButton; set => editButton = value; }
        public bool IsCategoryDeleteEnabled { get => deleteCategoryButton.Enabled; set => deleteCategoryButton.Enabled = value; }

        #endregion

        public MainForm()
        {
            InitializeComponent();

            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            categoryNameBox.Leave += CategoryNameBox_Leave;
            categoryNameBox.TextChanged += CategoryNameBox_Leave;
            
            dateTimePicker1.CustomFormat = "";

        }

        private void CategoryNameBox_Leave(object sender, EventArgs e)
        {
            CategoriesPresenter.OnNameFieldLeave();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Hide();               
            }
        }

        private void tasksView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateTaskView();
        }

        private void categoriesAddingButton_Click(object sender, EventArgs e)
        {
            Presenter.NewCategoryAdding();
        }

        private void taskAddButton_Click(object sender, EventArgs e)
        {
            Presenter.NewTasksAdding();
        }

        private void categoriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriesPresenter.UpdateCategoryView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CategoriesPresenter.Edit();
        }

        private void taskEditButton_Click(object sender, EventArgs e)
        {
            Presenter.Edit();
        }

        private void taskDeleteButton_Click(object sender, EventArgs e)
        {
            Presenter.Delete();
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            CategoriesPresenter.Delete();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(Messages.AreYouSure, Messages.Attention, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Presenter.Save();
            } else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Presenter.HandleMissed();
        }
    }

}