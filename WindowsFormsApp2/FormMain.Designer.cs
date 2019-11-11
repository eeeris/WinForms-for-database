namespace TestTask
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textFilterSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.listEmployee = new System.Windows.Forms.ListBox();
            this.listSkills = new System.Windows.Forms.ListBox();
            this.textFilerSkillName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteSkill = new System.Windows.Forms.Button();
            this.buttonAddSkills = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFilterSecondName
            // 
            this.textFilterSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilterSecondName.Location = new System.Drawing.Point(42, 56);
            this.textFilterSecondName.Name = "textFilterSecondName";
            this.textFilterSecondName.Size = new System.Drawing.Size(185, 20);
            this.textFilterSecondName.TabIndex = 0;
            this.textFilterSecondName.TextChanged += new System.EventHandler(this.textFilterSecondName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDeleteEmployee);
            this.groupBox1.Controls.Add(this.buttonAddEmployee);
            this.groupBox1.Controls.Add(this.listEmployee);
            this.groupBox1.Controls.Add(this.textFilterSecondName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(39, 263);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(215, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "*Двойной щелчок для снятия выделения";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добавить/изменить";
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(42, 293);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(60, 25);
            this.buttonDeleteEmployee.TabIndex = 7;
            this.buttonDeleteEmployee.Text = "удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEmployee.Location = new System.Drawing.Point(167, 293);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(60, 25);
            this.buttonAddEmployee.TabIndex = 3;
            this.buttonAddEmployee.Text = "+";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // listEmployee
            // 
            this.listEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEmployee.FormattingEnabled = true;
            this.listEmployee.Location = new System.Drawing.Point(42, 94);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(185, 160);
            this.listEmployee.TabIndex = 2;
            this.listEmployee.SelectedIndexChanged += new System.EventHandler(this.listEmployees_SelectedValueChanged);
            this.listEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEmployee_MouseDoubleClick);
            // 
            // listSkills
            // 
            this.listSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSkills.FormattingEnabled = true;
            this.listSkills.Location = new System.Drawing.Point(21, 94);
            this.listSkills.Name = "listSkills";
            this.listSkills.Size = new System.Drawing.Size(161, 160);
            this.listSkills.TabIndex = 4;
            this.listSkills.SelectedValueChanged += new System.EventHandler(this.listSkills_SelectedValueChanged);
            this.listSkills.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSkills_MouseDoubleClick);
            // 
            // textFilerSkillName
            // 
            this.textFilerSkillName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilerSkillName.Location = new System.Drawing.Point(21, 56);
            this.textFilerSkillName.Name = "textFilerSkillName";
            this.textFilerSkillName.Size = new System.Drawing.Size(161, 20);
            this.textFilerSkillName.TabIndex = 5;
            this.textFilerSkillName.TextChanged += new System.EventHandler(this.textFilterSkillName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonDeleteSkill);
            this.groupBox2.Controls.Add(this.buttonAddSkills);
            this.groupBox2.Controls.Add(this.textFilerSkillName);
            this.groupBox2.Controls.Add(this.listSkills);
            this.groupBox2.Location = new System.Drawing.Point(-3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 344);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // buttonDeleteSkill
            // 
            this.buttonDeleteSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteSkill.Location = new System.Drawing.Point(21, 293);
            this.buttonDeleteSkill.Name = "buttonDeleteSkill";
            this.buttonDeleteSkill.Size = new System.Drawing.Size(60, 25);
            this.buttonDeleteSkill.TabIndex = 7;
            this.buttonDeleteSkill.Text = "удалить";
            this.buttonDeleteSkill.UseVisualStyleBackColor = true;
            this.buttonDeleteSkill.Click += new System.EventHandler(this.buttonDeleteSkill_Click);
            // 
            // buttonAddSkills
            // 
            this.buttonAddSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSkills.Location = new System.Drawing.Point(122, 293);
            this.buttonAddSkills.Name = "buttonAddSkills";
            this.buttonAddSkills.Size = new System.Drawing.Size(60, 25);
            this.buttonAddSkills.TabIndex = 6;
            this.buttonAddSkills.Text = "+";
            this.buttonAddSkills.UseVisualStyleBackColor = true;
            this.buttonAddSkills.Click += new System.EventHandler(this.ButtonAddSkill_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(469, 344);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Навыки";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Добавить/изменить";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 344);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(485, 250);
            this.Name = "FormMain";
            this.Text = "Сотрудники и их навыки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.TextBox textFilterSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listEmployee;
        private System.Windows.Forms.ListBox listSkills;
        private System.Windows.Forms.TextBox textFilerSkillName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonAddSkills;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteSkill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

