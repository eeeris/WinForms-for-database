using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace TestTask
{
    public partial class FormSkill : Form
    {
        public FormSkill()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
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

        public TestTask.Mapping.skill addNewSkill
        {
            get; set;
        }



        private void buttonAddSkill_Click(object sender, EventArgs e)
        {

            addNewSkill = new TestTask.Mapping.skill();
            addNewSkill.skill_name = textBoxAddNewSkill.Text;
            using (var db = Program.OpenConnection())

            //{
            //var sk = db.skill.FirstOrDefault(x => x.skill_name == addNewSkill.skill_name);
            if (String.IsNullOrEmpty(addNewSkill.skill_name))
            {
                    MessageBox.Show(
                    "ввведите название навыка",
                    "Пустое значение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (DataProvider.AddNewSkillSupporting(addNewSkill) != null)
            {
                    MessageBox.Show(
                    "Этот навык уже добавлен в базу!",
                    "существующее значение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                    var employeeIDs = checkedListBoxEmployee.CheckedItems.Cast<Mapping.employee>().Select(x => x.employee_id);
                    DataProvider.AddNewSkillAndLinkWithEmployee(addNewSkill, employeeIDs);
                    Close();
                    /*db.skill.InsertOnSubmit(addNewSkill);

                    foreach (var employee in checkedListBoxEmployee.CheckedItems.Cast<Mapping.employee>())
                    {
                        bool isLinkedWithEmployee = addNewSkill.ps.Any(x => x.employee == employee);

                        if (isLinkedWithEmployee == false)
                        {
                            var ps = new Mapping.ps { skills_id = addNewSkill.skill_id, person_id = employee.employee_id };

                            addNewSkill.ps.Add(ps);
                            employee.ps.Add(ps);

                            db.ps.InsertOnSubmit(ps);

                        }
                    }

                    db.SubmitChanges();
                    */
                }
            
        }
    



        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {

            Form ifrm = new FormEmployee();
            ifrm.ShowDialog();
            //Update_checkedListBoxEmployee();
            
        }

    }
}
