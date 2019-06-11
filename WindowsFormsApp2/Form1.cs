using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
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

            var employees = Program.Database.employee;
                //var employees = Program.Database.GetTable<Data.Employee>();


            var sortedEmployees = from e in employees
                                  where listSkills.SelectedItem == null|| e.ps.Any(x => x.skill == listSkills.SelectedItem)
                                  where e.second_name.StartsWith(textFilterSecondName.Text)
                                  orderby e.second_name
                                  select e;

            foreach (var employee in sortedEmployees)

            {
                listEmployee.Items.Add(employee);
            }
        }



        private void UpdateSkillsList()
        {
            listSkills.Items.Clear();

            var skills = Program.Database.skill;
                //Program.Database.GetTable<Data.Skill>();

            //var employees = Program.Database.GetTable<Data.Employee>();
            //var ps = Program.Database.GetTable<Data.Ps>();

            var sortedSkills = from s in skills
                               //from e in employees
                               //from p in ps
                               where listEmployee.SelectedItem == null || s.ps.Any(x => x.employee == listEmployee.SelectedItem)
                               where s.skill_name.StartsWith(textFilerSkillName.Text)
                               orderby s.skill_name
                               select s;
         

            //var sortedSkills1 = skills.
            //    Where(s => listEmployee.SelectedItem == null || s.Ps.Any(x => x.Employee == listEmployee.SelectedItem)).
            //    Where(s => s.SkillName.StartsWith(textFilerSkillName.Text)).
            //    OrderBy(s => s.SkillName);

            foreach (var skill in sortedSkills)
            {
                listSkills.Items.Add(skill);
            }
        }

        
        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            
            var ifrm = new Form2();
            ifrm.ChangingEmployee = listEmployee.SelectedItem as TestTask.Mapping.employee;//тип изменен
            if (ifrm.ChangingEmployee == null)
                ifrm.ChangingEmployee = new TestTask.Mapping.employee();
            ifrm.ShowDialog();
            UpdateEmployeesList();
            UpdateSkillsList();




        }
        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {

            Form ifrm = new Form3();
            ifrm.ShowDialog();

        }

        
        private void textFilterSecondName_TextChanged(object sender, EventArgs e) => UpdateEmployeesList();

        private void textFilterSkillName_TextChanged(object sender, EventArgs e) => UpdateSkillsList();

        private void listSkills_SelectedValueChanged(object sender, EventArgs e) => UpdateEmployeesList();

        private void listEmployees_SelectedValueChanged(object sender, EventArgs e) => UpdateSkillsList();

        private void ButtonSkills_Click(object sender, EventArgs e)
        {

        }

    }

}

