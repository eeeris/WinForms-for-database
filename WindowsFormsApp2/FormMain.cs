using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestTask.Mapping;

namespace TestTask
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateEmployeesList();
            UpdateSkillsList();
        }



        private void UpdateEmployeesList()
        {
            listEmployee.Items.Clear();

            foreach (var employee in DataProvider.GetEmployee(listSkills.SelectedItem as skill, textFilterSecondName.Text))
            {
                listEmployee.Items.Add(employee);
            }
        }



        private void UpdateSkillsList()
        {
            listSkills.Items.Clear();

            foreach (var skill in DataProvider.GetSkill(listEmployee.SelectedItem as employee, textFilerSkillName.Text))
            {
                listSkills.Items.Add(skill);
            }
        }



        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            var ifrm = new FormEmployee();
            ifrm.ChangingEmployee = listEmployee.SelectedItem as TestTask.Mapping.employee;//тип изменен
          
            ifrm.ShowDialog();
            {
                UpdateEmployeesList();
                UpdateSkillsList();
            }
        }



        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormSkill();
            ifrm.ShowDialog();
            {
                UpdateEmployeesList();
                UpdateSkillsList();
            }
        }



        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                (
                "Все данные о сотруднике будут удалены. Удалить?",
                "Удаление информации о сотруднике",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );

            if (result == DialogResult.Yes && listEmployee.SelectedItem != null)
            {
                DataProvider.DaleteEmployee(listEmployee.SelectedItem as employee);
            }

            listEmployee.SelectedItem = null;
            UpdateEmployeesList();
            UpdateSkillsList();
        }



        private void buttonDeleteSkill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
            (
                "Все данные о навыке и владеющих им сотрудниках будут удалены. Удалить?",
                "Удаление информации о навыке",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
             );
            if (result == DialogResult.Yes && listSkills.SelectedItem != null)
            {
                DataProvider.DaleteSkill(listSkills.SelectedItem as skill);
            }
            listSkills.SelectedItem = null;
            UpdateEmployeesList();
            UpdateSkillsList();
        }
        


        private void listEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listEmployee.SelectedItem = null;
        }



        private void listSkills_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listSkills.SelectedItem = null;
        }



        private void textFilterSecondName_TextChanged(object sender, EventArgs e)
        {
            UpdateEmployeesList();
        }



        private void textFilterSkillName_TextChanged(object sender, EventArgs e)
        {
            UpdateSkillsList();
        }



        private void listSkills_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateEmployeesList();
        }



        private void listEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateSkillsList();
        }
    }
}

