namespace TestTask
{
    partial class Form2
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
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textSecondName = new System.Windows.Forms.TextBox();
            this.labelSkills = new System.Windows.Forms.Label();
            this.textSkills = new System.Windows.Forms.TextBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.checkedListBoxSkills = new System.Windows.Forms.CheckedListBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.textEducation = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelPassportNumber = new System.Windows.Forms.Label();
            this.textPassportNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.buttonAddSkill = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(55, 53);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(60, 13);
            this.labelSecondName.TabIndex = 0;
            this.labelSecondName.Text = "Фамилия*";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(55, 109);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(33, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Имя*";
            // 
            // textFirstName
            // 
            this.textFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirstName.Location = new System.Drawing.Point(58, 125);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(219, 20);
            this.textFirstName.TabIndex = 2;
            // 
            // textSecondName
            // 
            this.textSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSecondName.Location = new System.Drawing.Point(58, 69);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.Size = new System.Drawing.Size(219, 20);
            this.textSecondName.TabIndex = 1;
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.Location = new System.Drawing.Point(55, 222);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new System.Drawing.Size(51, 13);
            this.labelSkills.TabIndex = 4;
            this.labelSkills.Text = "Навыки*";
            // 
            // textSkills
            // 
            this.textSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSkills.Location = new System.Drawing.Point(55, 232);
            this.textSkills.Name = "textSkills";
            this.textSkills.Size = new System.Drawing.Size(221, 20);
            this.textSkills.TabIndex = 4;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(437, 19);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(224, 13);
            this.labelInformation.TabIndex = 7;
            this.labelInformation.Text = "Дополнительная нформация о сотруднике\r\n";
            // 
            // checkedListBoxSkills
            // 
            this.checkedListBoxSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxSkills.FormattingEnabled = true;
            this.checkedListBoxSkills.Location = new System.Drawing.Point(58, 282);
            this.checkedListBoxSkills.Name = "checkedListBoxSkills";
            this.checkedListBoxSkills.Size = new System.Drawing.Size(219, 109);
            this.checkedListBoxSkills.TabIndex = 5;
            this.checkedListBoxSkills.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxSkills_ItemCheck);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(55, 165);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 13);
            this.labelPosition.TabIndex = 9;
            this.labelPosition.Text = "Должность*";
            // 
            // textPosition
            // 
            this.textPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPosition.Location = new System.Drawing.Point(58, 181);
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(219, 20);
            this.textPosition.TabIndex = 3;
            // 
            // labelEducation
            // 
            this.labelEducation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(437, 53);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(75, 13);
            this.labelEducation.TabIndex = 12;
            this.labelEducation.Text = "Образование";
            // 
            // textEducation
            // 
            this.textEducation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEducation.Location = new System.Drawing.Point(440, 69);
            this.textEducation.Name = "textEducation";
            this.textEducation.Size = new System.Drawing.Size(219, 20);
            this.textEducation.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(437, 109);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 14;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(437, 165);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Адрес";
            // 
            // textAddress
            // 
            this.textAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddress.Location = new System.Drawing.Point(440, 181);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(219, 20);
            this.textAddress.TabIndex = 8;
            // 
            // labelPassportNumber
            // 
            this.labelPassportNumber.AutoSize = true;
            this.labelPassportNumber.Location = new System.Drawing.Point(437, 222);
            this.labelPassportNumber.Name = "labelPassportNumber";
            this.labelPassportNumber.Size = new System.Drawing.Size(196, 13);
            this.labelPassportNumber.TabIndex = 18;
            this.labelPassportNumber.Text = "Паспорт (серия, номер, без пробела)";
            // 
            // textPassportNumber
            // 
            this.textPassportNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassportNumber.Location = new System.Drawing.Point(440, 238);
            this.textPassportNumber.Name = "textPassportNumber";
            this.textPassportNumber.Size = new System.Drawing.Size(219, 20);
            this.textPassportNumber.TabIndex = 9;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(437, 282);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 20;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPhoneNumber.Location = new System.Drawing.Point(440, 298);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(219, 20);
            this.textPhoneNumber.TabIndex = 10;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(437, 346);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 22;
            this.labelMail.Text = "Mail";
            // 
            // textMail
            // 
            this.textMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMail.Location = new System.Drawing.Point(440, 362);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(217, 20);
            this.textMail.TabIndex = 11;
            // 
            // buttonAddSkill
            // 
            this.buttonAddSkill.Location = new System.Drawing.Point(296, 238);
            this.buttonAddSkill.Name = "buttonAddSkill";
            this.buttonAddSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSkill.TabIndex = 24;
            this.buttonAddSkill.Text = "Новый ";
            this.buttonAddSkill.UseVisualStyleBackColor = true;
            this.buttonAddSkill.Click += new System.EventHandler(this.ButtonAddSkill_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(584, 431);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmployee.TabIndex = 25;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirth.Location = new System.Drawing.Point(440, 125);
            this.dateOfBirth.MaxDate = new System.DateTime(2019, 6, 10, 0, 0, 0, 0);
            this.dateOfBirth.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ShowCheckBox = true;
            this.dateOfBirth.Size = new System.Drawing.Size(219, 20);
            this.dateOfBirth.TabIndex = 7;
            this.dateOfBirth.Value = new System.DateTime(2019, 6, 10, 0, 0, 0, 0);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(55, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(194, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Основная информация о сотруднике";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textSkills);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(804, 488);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 494);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonAddSkill);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textPassportNumber);
            this.Controls.Add(this.labelPassportNumber);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textEducation);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.checkedListBoxSkills);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelSkills);
            this.Controls.Add(this.textSecondName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textSecondName;
        private System.Windows.Forms.Label labelSkills;
        private System.Windows.Forms.TextBox textSkills;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.CheckedListBox checkedListBoxSkills;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.TextBox textEducation;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelPassportNumber;
        private System.Windows.Forms.TextBox textPassportNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Button buttonAddSkill;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}