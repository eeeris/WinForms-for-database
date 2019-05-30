namespace TestTask
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAddNewSkill = new System.Windows.Forms.Label();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelAddNewSkill
            // 
            this.labelAddNewSkill.AutoSize = true;
            this.labelAddNewSkill.Location = new System.Drawing.Point(46, 38);
            this.labelAddNewSkill.Name = "labelAddNewSkill";
            this.labelAddNewSkill.Size = new System.Drawing.Size(127, 13);
            this.labelAddNewSkill.TabIndex = 1;
            this.labelAddNewSkill.Text = "Добавить новый навык";
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Location = new System.Drawing.Point(46, 135);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(151, 13);
            this.labelAddEmployee.TabIndex = 2;
            this.labelAddEmployee.Text = "сотрудники с этим навыком";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(49, 164);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(163, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.Location = new System.Drawing.Point(239, 135);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonNewEmployee.TabIndex = 4;
            this.buttonNewEmployee.Text = "новый";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            this.buttonNewEmployee.Click += new System.EventHandler(this.ButtonNewEmployee_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewEmployee);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelAddEmployee);
            this.Controls.Add(this.labelAddNewSkill);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAddNewSkill;
        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonNewEmployee;
    }
}