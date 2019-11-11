namespace TestTask
{
    partial class FormSkill
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
            this.textBoxAddNewSkill = new System.Windows.Forms.TextBox();
            this.labelAddNewSkill = new System.Windows.Forms.Label();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.checkedListBoxEmployee = new System.Windows.Forms.CheckedListBox();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddSkill = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAddNewSkill
            // 
            this.textBoxAddNewSkill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddNewSkill.Location = new System.Drawing.Point(37, 42);
            this.textBoxAddNewSkill.Name = "textBoxAddNewSkill";
            this.textBoxAddNewSkill.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddNewSkill.TabIndex = 0;
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
            this.labelAddEmployee.Location = new System.Drawing.Point(34, 89);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(152, 13);
            this.labelAddEmployee.TabIndex = 2;
            this.labelAddEmployee.Text = "Сотрудники с этим навыком";
            // 
            // checkedListBoxEmployee
            // 
            this.checkedListBoxEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxEmployee.FormattingEnabled = true;
            this.checkedListBoxEmployee.Location = new System.Drawing.Point(37, 108);
            this.checkedListBoxEmployee.Name = "checkedListBoxEmployee";
            this.checkedListBoxEmployee.Size = new System.Drawing.Size(227, 109);
            this.checkedListBoxEmployee.TabIndex = 3;
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewEmployee.Location = new System.Drawing.Point(237, 84);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(27, 23);
            this.buttonNewEmployee.TabIndex = 4;
            this.buttonNewEmployee.Text = "+";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            this.buttonNewEmployee.Click += new System.EventHandler(this.ButtonNewEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelAddEmployee);
            this.groupBox1.Controls.Add(this.textBoxAddNewSkill);
            this.groupBox1.Controls.Add(this.buttonNewEmployee);
            this.groupBox1.Controls.Add(this.checkedListBoxEmployee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // buttonAddSkill
            // 
            this.buttonAddSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSkill.Location = new System.Drawing.Point(201, 259);
            this.buttonAddSkill.Name = "buttonAddSkill";
            this.buttonAddSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSkill.TabIndex = 0;
            this.buttonAddSkill.Text = "добавить";
            this.buttonAddSkill.UseVisualStyleBackColor = true;
            this.buttonAddSkill.Click += new System.EventHandler(this.buttonAddSkill_Click);
            // 
            // FormSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 290);
            this.Controls.Add(this.labelAddNewSkill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddSkill);
            this.MinimumSize = new System.Drawing.Size(307, 267);
            this.Name = "FormSkill";
            this.Text = "Навыки";
            this.Load += new System.EventHandler(this.FormSkill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddNewSkill;
        private System.Windows.Forms.Label labelAddNewSkill;
        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.CheckedListBox checkedListBoxEmployee;
        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddSkill;
    }
}