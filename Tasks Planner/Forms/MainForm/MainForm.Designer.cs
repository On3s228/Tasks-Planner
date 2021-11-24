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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.tasksView = new System.Windows.Forms.ListView();
            this.idColumn = new System.Windows.Forms.ColumnHeader();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.taskAddButton = new System.Windows.Forms.Button();
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
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 330);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 190);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(493, 212);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(250, 27);
            this.nameBox.TabIndex = 5;
            // 
            // descriptionRichBox
            // 
            this.descriptionRichBox.Enabled = false;
            this.descriptionRichBox.Location = new System.Drawing.Point(493, 245);
            this.descriptionRichBox.Name = "descriptionRichBox";
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
            this.tasksView.Location = new System.Drawing.Point(222, 190);
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
            this.taskAddButton.Location = new System.Drawing.Point(242, 409);
            this.taskAddButton.Name = "taskAddButton";
            this.taskAddButton.Size = new System.Drawing.Size(170, 29);
            this.taskAddButton.TabIndex = 8;
            this.taskAddButton.Text = "Новое напоминание";
            this.taskAddButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskAddButton);
            this.Controls.Add(this.tasksView);
            this.Controls.Add(this.descriptionRichBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Планировщик";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private TextBox nameBox;
        private RichTextBox descriptionRichBox;
        private ListView tasksView;
        private ColumnHeader idColumn;
        private ColumnHeader nameColumn;
        private Button taskAddButton;
    }
}