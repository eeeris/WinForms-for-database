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

            var employees = Program.Database.GetTable<Data.Employee>();


            var sortedEmployees = from e in employees
                                  where listSkills.SelectedItem == null|| e.Ps.Any(x => x.Skill == listSkills.SelectedItem)
                                  where e.SecondName.StartsWith(textFilterSecondName.Text)
                                  orderby e.SecondName
                                  select e;

            foreach (var employee in sortedEmployees)

            {
                listEmployee.Items.Add(employee);
            }
        }

        private void UpdateSkillsList()
        {
            listSkills.Items.Clear();

            var skills = Program.Database.GetTable<Data.Skill>();
            //var employees = Program.Database.GetTable<Data.Employee>();
            //var ps = Program.Database.GetTable<Data.Ps>();

            var sortedSkills = from s in skills
                               //from e in employees
                               //from p in ps
                               where listEmployee.SelectedItem == null || s.Ps.Any(x => x.Employee == listEmployee.SelectedItem)
                               where s.SkillName.StartsWith(textFilerSkillName.Text)
                               orderby s.SkillName
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

        private void textFilterSecondName_TextChanged(object sender, EventArgs e) => UpdateEmployeesList();

        private void textFilterSkillName_TextChanged(object sender, EventArgs e) => UpdateSkillsList();

        private void listSkills_SelectedValueChanged(object sender, EventArgs e) => UpdateEmployeesList();

        private void listEmployees_SelectedValueChanged(object sender, EventArgs e) => UpdateSkillsList();

        private void ButtonSkills_Click(object sender, EventArgs e)
        {

        }
    }

}

