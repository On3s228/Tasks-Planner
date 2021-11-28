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
            ToolTip t = new ToolTip();
            nameBox.TextChanged += nameBox_Leave;
            t.SetToolTip(nameBox, "Поле для ввода названия создаваемой категории.\n\nДанное поле обязательно для заполнения.");
            t.SetToolTip(descriptionRich, "Поле для ввода описания создаваемой категории.\n\nНеобязательное поле.");
            t.SetToolTip(addButton, "Добавление категории.");
            t.SetToolTip(label3, "Поле обязательно для заполнения.");
            t.SetToolTip(label1, "Поле обязательно для заполнения.");
        }

        private void CategoryAdding_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(nameBox.Text))
            //{
            //    nameBox.ForeColor = Color.Red;
            //    nameBox.BackColor = Color.Black;

            //    nameBox.Select(nameBox.Text.Length, 0);
            //}
        }

        private void nameBox_Leave(object? sender, EventArgs e)
        {
            nameBox.BorderColor = string.IsNullOrWhiteSpace(nameBox.Text) ? Color.Red : Color.Transparent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Presenter.AddCategory();
        }
    }
}
