namespace Tasks_Planner.Forms.TasksCreating
{
    partial class TaskCreating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionBox = new Tasks_Planner.MyRichTextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.repeatableCheck = new System.Windows.Forms.CheckBox();
            this.periodicityCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesChecks = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameBox = new Tasks_Planner.MyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderColor = System.Drawing.Color.Transparent;
            this.descriptionBox.Location = new System.Drawing.Point(154, 70);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(236, 120);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "";
            // 
            // dateField
            // 
            this.dateField.CustomFormat = "dd.MM.yyyy, HH:mm:ss";
            this.dateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateField.Location = new System.Drawing.Point(154, 196);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(236, 27);
            this.dateField.TabIndex = 2;
            // 
            // repeatableCheck
            // 
            this.repeatableCheck.AutoSize = true;
            this.repeatableCheck.Location = new System.Drawing.Point(154, 229);
            this.repeatableCheck.Name = "repeatableCheck";
            this.repeatableCheck.Size = new System.Drawing.Size(130, 24);
            this.repeatableCheck.TabIndex = 3;
            this.repeatableCheck.Text = "Повторяемый";
            this.repeatableCheck.UseVisualStyleBackColor = true;
            this.repeatableCheck.CheckedChanged += new System.EventHandler(this.repeatableCheck_CheckedChanged);
            // 
            // periodicityCombo
            // 
            this.periodicityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodicityCombo.Enabled = false;
            this.periodicityCombo.FormattingEnabled = true;
            this.periodicityCombo.Location = new System.Drawing.Point(154, 259);
            this.periodicityCombo.Name = "periodicityCombo";
            this.periodicityCombo.Size = new System.Drawing.Size(236, 28);
            this.periodicityCombo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Периодичность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Категории";
            // 
            // categoriesChecks
            // 
            this.categoriesChecks.FormattingEnabled = true;
            this.categoriesChecks.Location = new System.Drawing.Point(154, 298);
            this.categoriesChecks.Name = "categoriesChecks";
            this.categoriesChecks.Size = new System.Drawing.Size(236, 114);
            this.categoriesChecks.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(106, 431);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.BorderColor = System.Drawing.Color.Transparent;
            this.nameBox.Location = new System.Drawing.Point(154, 33);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(236, 27);
            this.nameBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(87, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(87, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(49, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "*";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(206, 431);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TaskCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 485);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoriesChecks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodicityCombo);
            this.Controls.Add(this.repeatableCheck);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.descriptionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskCreating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskCreating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyRichTextBox descriptionBox;
        private DateTimePicker dateField;
        private CheckBox repeatableCheck;
        private ComboBox periodicityCombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckedListBox categoriesChecks;
        private Button saveButton;
        private MyTextBox nameBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button cancelButton;
    }
}