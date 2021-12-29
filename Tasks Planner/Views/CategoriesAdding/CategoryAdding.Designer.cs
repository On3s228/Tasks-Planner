namespace Tasks_Planner.Forms.CategoriesAdding
{
    partial class CategoryAdding
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new Tasks_Planner.MyTextBox();
            this.descriptionRich = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание";
            // 
            // nameBox
            // 
            this.nameBox.BorderColor = System.Drawing.Color.Transparent;
            this.nameBox.Location = new System.Drawing.Point(106, 39);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(294, 27);
            this.nameBox.TabIndex = 2;
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // descriptionRich
            // 
            this.descriptionRich.Location = new System.Drawing.Point(97, 105);
            this.descriptionRich.Name = "descriptionRich";
            this.descriptionRich.Size = new System.Drawing.Size(303, 120);
            this.descriptionRich.TabIndex = 3;
            this.descriptionRich.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(117, 245);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(87, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "*";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 245);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CategoryAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 312);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionRich);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление категории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MyTextBox nameBox;
        private RichTextBox descriptionRich;
        private Button addButton;
        private Label label3;
        private Button cancelButton;
    }
}