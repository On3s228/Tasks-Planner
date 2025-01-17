﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks_Planner.CustomControls;
using Tasks_Planner.Presenters;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Forms.TasksCreating
{
    public partial class TaskCreating : Form, ITasksAddingView
    {
        public TaskCreating()
        {
            InitializeComponent();

            nameBox.Leave += NameBox_Leave;
            nameBox.TextChanged += NameBox_Leave;
            descriptionBox.Leave += NameBox_Leave;
            descriptionBox.TextChanged += NameBox_Leave;
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            //todo: объединить MyRichTextBox и MyTextBox в один интерфейс для более удобного кода ивентов
            if (sender is ICustomTextBox myBox)
            {
                myBox.BorderColor = string.IsNullOrWhiteSpace(myBox.Text) ? Color.Red : Color.Transparent;
            }
        }

        public CheckedListBox CheckedCategories { get => categoriesChecks; set => categoriesChecks = value; }
        public TasksAddingPresenter Presenter { private get; set; }
        public MyTextBox NameField { get => nameBox; set => nameBox = value; }
        public MyRichTextBox DescriptionField { get => descriptionBox; set => descriptionBox = value; }
        public DateTime Date { get => dateField.Value; set => dateField.Value = value; }
        public ComboBox Periodicity { get => periodicityCombo; set => periodicityCombo = value; }
        public bool IsPeriodic { get => repeatableCheck.Checked; set => repeatableCheck.Checked = value; }
        public UserTask Edit { get; set; }

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Presenter.Add();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Tools.Events.Cancel(this);
        }
    }
}
