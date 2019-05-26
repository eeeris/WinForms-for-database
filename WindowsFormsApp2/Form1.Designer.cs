namespace TestTask
{
    partial class Form1
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
            this.listEmployee = new System.Windows.Forms.ListBox();
            this.ButtonSkills = new System.Windows.Forms.Button();
            this.listSkills = new System.Windows.Forms.ListBox();
            this.textFilerSkillName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFilterSecondName
            // 
            this.textFilterSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilterSecondName.Location = new System.Drawing.Point(42, 56);
            this.textFilterSecondName.Name = "textFilterSecondName";
            this.textFilterSecondName.Size = new System.Drawing.Size(244, 20);
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
            this.groupBox1.Controls.Add(this.listEmployee);
            this.groupBox1.Controls.Add(this.textFilterSecondName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listEmployee
            // 
            this.listEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEmployee.FormattingEnabled = true;
            this.listEmployee.Location = new System.Drawing.Point(42, 91);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(244, 199);
            this.listEmployee.TabIndex = 2;
            // 
            // ButtonSkills
            // 
            this.ButtonSkills.Location = new System.Drawing.Point(203, 12);
            this.ButtonSkills.Name = "ButtonSkills";
            this.ButtonSkills.Size = new System.Drawing.Size(97, 30);
            this.ButtonSkills.TabIndex = 3;
            this.ButtonSkills.Text = "Навыки";
            this.ButtonSkills.UseVisualStyleBackColor = true;
            this.ButtonSkills.Click += new System.EventHandler(this.ButtonSkills_Click);
            // 
            // listSkills
            // 
            this.listSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSkills.FormattingEnabled = true;
            this.listSkills.Location = new System.Drawing.Point(21, 91);
            this.listSkills.Name = "listSkills";
            this.listSkills.Size = new System.Drawing.Size(201, 199);
            this.listSkills.TabIndex = 4;
            // 
            // textFilerSkillName
            // 
            this.textFilerSkillName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilerSkillName.Location = new System.Drawing.Point(21, 56);
            this.textFilerSkillName.Name = "textFilerSkillName";
            this.textFilerSkillName.Size = new System.Drawing.Size(201, 20);
            this.textFilerSkillName.TabIndex = 5;
            this.textFilerSkillName.TextChanged += new System.EventHandler(this.textFilterSkillName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFilerSkillName);
            this.groupBox2.Controls.Add(this.listSkills);
            this.groupBox2.Location = new System.Drawing.Point(436, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 339);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSkills);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textFilterSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listEmployee;
        private System.Windows.Forms.Button ButtonSkills;
        private System.Windows.Forms.ListBox listSkills;
        private System.Windows.Forms.TextBox textFilerSkillName;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

