﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace TestTask
{
    public partial class FormSkill : Form
    {
        public FormSkill()
        {
            InitializeComponent();
        }


        private void FormSkill_Load(object sender, EventArgs e)
        {
            Update_checkedListBoxEmployee();
        }


        private void Update_checkedListBoxEmployee()
        {
            checkedListBoxEmployee.Items.Clear();

            foreach (var employees in DataProvider.UpdatecheckedListBoxEmployee())
            {
                checkedListBoxEmployee.Items.Add(employees);
            }
        }


        public Mapping.skill addNewSkill
        {
            get; set;
        }


        private void buttonAddSkill_Click(object sender, EventArgs e)
        {
            addNewSkill = new Mapping.skill();
            addNewSkill.skill_name = textBoxAddNewSkill.Text;

            if (String.IsNullOrEmpty(addNewSkill.skill_name))
            {
                MessageBox.Show
                    (
                    "ввведите название навыка",
                    "Пустое значение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else if (DataProvider.FindAndExcludeDuplicateSkill(addNewSkill.skill_name) != null)
            {
                MessageBox.Show
                    (
                    "Этот навык уже добавлен в базу!",
                    "существующее значение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                var employeeIDs = checkedListBoxEmployee.CheckedItems.Cast<Mapping.employee>().Select(x => x.employee_id);
                DataProvider.AddNewSkillAndLinkWithEmployee(addNewSkill, employeeIDs);
                Close();
            }
            
        }


        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormEmployee();
            ifrm.ShowDialog();
            Update_checkedListBoxEmployee();
        }
    }
}
