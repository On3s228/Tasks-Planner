namespace Tasks_Planner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.tasksView = new System.Windows.Forms.ListView();
            this.idColumn = new System.Windows.Forms.ColumnHeader();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.taskAddButton = new System.Windows.Forms.Button();
            this.categoriesAddingButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tasksPage = new System.Windows.Forms.TabPage();
            this.categoriesPage = new System.Windows.Forms.TabPage();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryDescRich = new System.Windows.Forms.RichTextBox();
            this.categoryNameBox = new Tasks_Planner.MyTextBox();
            this.categoriesListView = new System.Windows.Forms.ListView();
            this.categoryIdColumn = new System.Windows.Forms.ColumnHeader();
            this.categoryNameColumn = new System.Windows.Forms.ColumnHeader();
            this.categoriesChecks = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.periodicityCombo = new System.Windows.Forms.ComboBox();
            this.repeatableCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tasksPage.SuspendLayout();
            this.categoriesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Планировщик";
            this.notifyIcon1.BalloonTipTitle = "Планировщик";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Планировщик";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy, HH:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(494, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(494, 33);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(250, 27);
            this.nameBox.TabIndex = 5;
            // 
            // descriptionRichBox
            // 
            this.descriptionRichBox.Location = new System.Drawing.Point(494, 66);
            this.descriptionRichBox.Name = "descriptionRichBox";
            this.descriptionRichBox.ReadOnly = true;
            this.descriptionRichBox.Size = new System.Drawing.Size(250, 79);
            this.descriptionRichBox.TabIndex = 6;
            this.descriptionRichBox.Text = "";
            // 
            // tasksView
            // 
            this.tasksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.tasksView.FullRowSelect = true;
            this.tasksView.GridLines = true;
            this.tasksView.Location = new System.Drawing.Point(17, 19);
            this.tasksView.MultiSelect = false;
            this.tasksView.Name = "tasksView";
            this.tasksView.Size = new System.Drawing.Size(213, 207);
            this.tasksView.TabIndex = 7;
            this.tasksView.UseCompatibleStateImageBehavior = false;
            this.tasksView.View = System.Windows.Forms.View.Details;
            this.tasksView.SelectedIndexChanged += new System.EventHandler(this.tasksView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название";
            this.nameColumn.Width = 145;
            // 
            // taskAddButton
            // 
            this.taskAddButton.Location = new System.Drawing.Point(17, 242);
            this.taskAddButton.Name = "taskAddButton";
            this.taskAddButton.Size = new System.Drawing.Size(170, 29);
            this.taskAddButton.TabIndex = 8;
            this.taskAddButton.Text = "Новое напоминание";
            this.taskAddButton.UseVisualStyleBackColor = true;
            this.taskAddButton.Click += new System.EventHandler(this.taskAddButton_Click);
            // 
            // categoriesAddingButton
            // 
            this.categoriesAddingButton.Location = new System.Drawing.Point(34, 355);
            this.categoriesAddingButton.Name = "categoriesAddingButton";
            this.categoriesAddingButton.Size = new System.Drawing.Size(121, 29);
            this.categoriesAddingButton.TabIndex = 9;
            this.categoriesAddingButton.Text = "доб. категории";
            this.categoriesAddingButton.UseVisualStyleBackColor = true;
            this.categoriesAddingButton.Click += new System.EventHandler(this.categoriesAddingButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tasksPage);
            this.tabControl1.Controls.Add(this.categoriesPage);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 447);
            this.tabControl1.TabIndex = 10;
            // 
            // tasksPage
            // 
            this.tasksPage.Controls.Add(this.label6);
            this.tasksPage.Controls.Add(this.label7);
            this.tasksPage.Controls.Add(this.label8);
            this.tasksPage.Controls.Add(this.categoriesChecks);
            this.tasksPage.Controls.Add(this.label5);
            this.tasksPage.Controls.Add(this.label4);
            this.tasksPage.Controls.Add(this.periodicityCombo);
            this.tasksPage.Controls.Add(this.repeatableCheck);
            this.tasksPage.Controls.Add(this.taskAddButton);
            this.tasksPage.Controls.Add(this.tasksView);
            this.tasksPage.Controls.Add(this.nameBox);
            this.tasksPage.Controls.Add(this.descriptionRichBox);
            this.tasksPage.Controls.Add(this.dateTimePicker1);
            this.tasksPage.Location = new System.Drawing.Point(4, 29);
            this.tasksPage.Name = "tasksPage";
            this.tasksPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksPage.Size = new System.Drawing.Size(787, 414);
            this.tasksPage.TabIndex = 0;
            this.tasksPage.Text = "Напоминания";
            this.tasksPage.UseVisualStyleBackColor = true;
            // 
            // categoriesPage
            // 
            this.categoriesPage.Controls.Add(this.deleteCategoryButton);
            this.categoriesPage.Controls.Add(this.editButton);
            this.categoriesPage.Controls.Add(this.label3);
            this.categoriesPage.Controls.Add(this.label2);
            this.categoriesPage.Controls.Add(this.label1);
            this.categoriesPage.Controls.Add(this.categoryDescRich);
            this.categoriesPage.Controls.Add(this.categoryNameBox);
            this.categoriesPage.Controls.Add(this.categoriesListView);
            this.categoriesPage.Controls.Add(this.categoriesAddingButton);
            this.categoriesPage.Location = new System.Drawing.Point(4, 29);
            this.categoriesPage.Name = "categoriesPage";
            this.categoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesPage.Size = new System.Drawing.Size(787, 414);
            this.categoriesPage.TabIndex = 1;
            this.categoriesPage.Text = "Категории";
            this.categoriesPage.UseVisualStyleBackColor = true;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(161, 355);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(94, 29);
            this.deleteCategoryButton.TabIndex = 17;
            this.deleteCategoryButton.Text = "удалить";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(458, 260);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(119, 29);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(371, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // categoryDescRich
            // 
            this.categoryDescRich.Location = new System.Drawing.Point(392, 113);
            this.categoryDescRich.Name = "categoryDescRich";
            this.categoryDescRich.ReadOnly = true;
            this.categoryDescRich.Size = new System.Drawing.Size(259, 120);
            this.categoryDescRich.TabIndex = 12;
            this.categoryDescRich.Text = "";
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.BorderColor = System.Drawing.Color.Transparent;
            this.categoryNameBox.Location = new System.Drawing.Point(392, 62);
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.ReadOnly = true;
            this.categoryNameBox.Size = new System.Drawing.Size(259, 27);
            this.categoryNameBox.TabIndex = 11;
            // 
            // categoriesListView
            // 
            this.categoriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryIdColumn,
            this.categoryNameColumn});
            this.categoriesListView.FullRowSelect = true;
            this.categoriesListView.GridLines = true;
            this.categoriesListView.Location = new System.Drawing.Point(34, 27);
            this.categoriesListView.MultiSelect = false;
            this.categoriesListView.Name = "categoriesListView";
            this.categoriesListView.Size = new System.Drawing.Size(221, 322);
            this.categoriesListView.TabIndex = 10;
            this.categoriesListView.UseCompatibleStateImageBehavior = false;
            this.categoriesListView.View = System.Windows.Forms.View.Details;
            this.categoriesListView.SelectedIndexChanged += new System.EventHandler(this.categoriesListView_SelectedIndexChanged);
            // 
            // categoryIdColumn
            // 
            this.categoryIdColumn.Text = "ID";
            // 
            // categoryNameColumn
            // 
            this.categoryNameColumn.Text = "Название";
            this.categoryNameColumn.Width = 157;
            // 
            // categoriesChecks
            // 
            this.categoriesChecks.FormattingEnabled = true;
            this.categoriesChecks.Location = new System.Drawing.Point(494, 256);
            this.categoriesChecks.Name = "categoriesChecks";
            this.categoriesChecks.Size = new System.Drawing.Size(236, 114);
            this.categoriesChecks.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Категории";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Периодичность";
            // 
            // periodicityCombo
            // 
            this.periodicityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodicityCombo.Enabled = false;
            this.periodicityCombo.FormattingEnabled = true;
            this.periodicityCombo.Location = new System.Drawing.Point(494, 217);
            this.periodicityCombo.Name = "periodicityCombo";
            this.periodicityCombo.Size = new System.Drawing.Size(236, 28);
            this.periodicityCombo.TabIndex = 13;
            // 
            // repeatableCheck
            // 
            this.repeatableCheck.AutoSize = true;
            this.repeatableCheck.Location = new System.Drawing.Point(494, 187);
            this.repeatableCheck.Name = "repeatableCheck";
            this.repeatableCheck.Size = new System.Drawing.Size(130, 24);
            this.repeatableCheck.TabIndex = 12;
            this.repeatableCheck.Text = "Повторяемый";
            this.repeatableCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Описание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Название";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Планировщик";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tasksPage.ResumeLayout(false);
            this.tasksPage.PerformLayout();
            this.categoriesPage.ResumeLayout(false);
            this.categoriesPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private DateTimePicker dateTimePicker1;
        private TextBox nameBox;
        private RichTextBox descriptionRichBox;
        private ListView tasksView;
        private ColumnHeader idColumn;
        private ColumnHeader nameColumn;
        private Button taskAddButton;
        private Button categoriesAddingButton;
        private TabControl tabControl1;
        private TabPage tasksPage;
        private TabPage categoriesPage;
        private ListView categoriesListView;
        private ColumnHeader categoryIdColumn;
        private ColumnHeader categoryNameColumn;
        private RichTextBox categoryDescRich;
        private MyTextBox categoryNameBox;
        private Button editButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button deleteCategoryButton;
        private CheckedListBox categoriesChecks;
        private Label label5;
        private Label label4;
        private ComboBox periodicityCombo;
        private CheckBox repeatableCheck;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}