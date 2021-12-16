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

namespace Tasks_Planner.Forms.CategoriesAdding
{
    public partial class CategoryAdding : Form, ICategoriesAddingView
    {
        public MyTextBox NameField { get => nameBox; set => nameBox = value; }
        public RichTextBox DescriptionField { get => descriptionRich; set => descriptionRich = value; }
        public CategoriesAddingPresenter Presenter { private get; set; }

        public CategoryAdding()
        {
            InitializeComponent();
            nameBox.TextChanged += nameBox_Leave;
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            nameBox.BorderColor = string.IsNullOrWhiteSpace(nameBox.Text) ? Color.Red : Color.Transparent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Presenter.AddCategory();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Tools.Events.Cancel(this);
        }
    }
}
