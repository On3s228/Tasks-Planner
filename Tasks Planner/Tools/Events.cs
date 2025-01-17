﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;
using Tasks_Planner.Properties;

namespace Tasks_Planner.Tools
{
    public class Events
    {
        public static MainPresenter MainPresenter { get; set; }
        public static CategoriesPresenter CategoriesPresenter { get; set; }
        public static void TasksListChanged()
        {
            if (MainPresenter != null)
            {
                MainPresenter.UpdateTasksList();
                MainPresenter.UpdateTaskView();
            }
            else throw new ArgumentException(typeof(Events).ToString());
        }
        public static void CategoriesListChanged()
        {
            if (CategoriesPresenter != null && MainPresenter != null)
            {
                CategoriesPresenter.UpdateCategoriesList();
                MainPresenter.UpdateCheckedListBox();
            }
            else throw new ArgumentException(typeof(Events).ToString());
        }
        public static void Cancel(Form f)
        {
            DialogResult result = MessageBox.Show(Messages.Cancel, Messages.Attention, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                f.Close();
            }
        }
    }
}
