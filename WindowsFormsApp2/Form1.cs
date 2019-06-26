﻿using System;
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
            using (var db = Program.OpenConnection())
            {
                UpdateEmployeesList(db);
                UpdateSkillsList(db);
            }

        }



        private void UpdateEmployeesList(Mapping.DataContext db)
        {
            listEmployee.Items.Clear();
            
            var employees = db.employee;
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



        private void UpdateSkillsList(Mapping.DataContext db)
        {
            listSkills.Items.Clear();

            var skills = db.skill;
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
          
            ifrm.ShowDialog();
            using (var db = Program.OpenConnection())
            {
                UpdateEmployeesList(db);
                UpdateSkillsList(db);
            }




        }
        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {

            Form ifrm = new Form3();
            ifrm.ShowDialog();
            using (var db = Program.OpenConnection())
            {
                UpdateEmployeesList(db);
                UpdateSkillsList(db);
            }


        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Все данные о сотруднике будут удалены. Удалить?",
                "Удаление информации о сотруднике",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            using (var db = Program.OpenConnection())
            {
                if (result == DialogResult.Yes)
                {

                    var ChangingEmployee = listEmployee.SelectedItem as TestTask.Mapping.employee;



                    var emId = ChangingEmployee.employee_id;
                    

                    db.employee.DeleteOnSubmit(ChangingEmployee);

                    var deleteSelectedPs = from ps in db.ps
                                           where ps.person_id == emId
                                           select ps;
                    //foreach (var ps in deleteSelectedPs)
                    //{
                    //    Program.Database.ps.DeleteOnSubmit(ps);
                    //}

                    db.ps.DeleteAllOnSubmit(deleteSelectedPs);




                }
                db.SubmitChanges();
                UpdateEmployeesList(db);
                UpdateSkillsList(db);
                Focus();
            }

        }



        private void buttonDeleteSkill_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show(
                "Все данные о навыке и владеющих им сотрудниках будут удалены. Удалить?",
                "Удаление информации о навыке",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            using (var db = Program.OpenConnection())
            {

                if (result == DialogResult.Yes)
                {

                    var ChangingSkill = listSkills.SelectedItem as TestTask.Mapping.skill;



                    var skill_id = ChangingSkill.skill_id;//ссылка на об не указ на экз объекта (не выделен объект)
                    db.skill.DeleteOnSubmit(ChangingSkill);

                    var deleteSelectedPs = from ps in db.ps
                                           where ps.skills_id == skill_id
                                           select ps;


                    db.ps.DeleteAllOnSubmit(deleteSelectedPs);
                }
                db.SubmitChanges();
                listSkills.SelectedItem = null;
                UpdateEmployeesList(db);
                UpdateSkillsList(db);
                BringToFront();

            }


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
            using (var db = Program.OpenConnection())
                UpdateEmployeesList(db);
        }

        private void textFilterSkillName_TextChanged(object sender, EventArgs e)
        {
            using (var db = Program.OpenConnection())
                UpdateSkillsList(db);
        }


        private void listSkills_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var db = Program.OpenConnection())
                UpdateEmployeesList(db);
        }


        private void listEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var db = Program.OpenConnection())
                UpdateSkillsList(db);
        }



 
    }

}

