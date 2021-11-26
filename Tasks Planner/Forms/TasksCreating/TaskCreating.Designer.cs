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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.repeatableCheck = new System.Windows.Forms.CheckBox();
            this.periodicityCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesChecks = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.myTextBox1 = new Tasks_Planner.MyTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(154, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 120);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 27);
            this.dateTimePicker1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Периодичность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 298);
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
            this.saveButton.Location = new System.Drawing.Point(154, 431);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.myTextBox1.Location = new System.Drawing.Point(154, 33);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(236, 27);
            this.myTextBox1.TabIndex = 13;
            // 
            // TaskCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 485);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoriesChecks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodicityCombo);
            this.Controls.Add(this.repeatableCheck);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TaskCreating";
            this.Text = "TaskCreating";
            this.Load += new System.EventHandler(this.TaskCreating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private CheckBox repeatableCheck;
        private ComboBox periodicityCombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckedListBox categoriesChecks;
        private Button saveButton;
        private MyTextBox myTextBox1;
    }
}