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

            using (var db = Program.OpenConnection())
                Update_checkedListBoxEmployee(db);
        }



        private void Update_checkedListBoxEmployee(Mapping.DataContext db)
        {
            checkedListBoxEmployee.Items.Clear();


            var sortedEmployees = from e in db.employee
                                  orderby e.second_name
                                  select e;

            foreach (var employees in sortedEmployees)
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
                
            {
                var sk = db.skill.FirstOrDefault(x => x.skill_name == addNewSkill.skill_name);
                if (String.IsNullOrEmpty(addNewSkill.skill_name))
                {
                    MessageBox.Show(
                    "ввведите название навыка",
                    "Пустое значение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                }

                else if (sk != null)
                {
                    MessageBox.Show(
                    "Этот навык уже добавлен в базу!",
                    "существующее значение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                }


                else
                {
                    db.skill.InsertOnSubmit(addNewSkill);

                    for (int i = 0; i < checkedListBoxEmployee.Items.Count; i++)
                    {
                        var employee = checkedListBoxEmployee.Items[i] as Mapping.employee;

                        bool isLinkedWithEmployee = addNewSkill.ps.Any(x => x.employee == employee);

                        if (checkedListBoxEmployee.GetItemChecked(i) == true && isLinkedWithEmployee == false)
                        {
                            var ps = new Mapping.ps { skills_id = addNewSkill.skill_id, person_id = employee.employee_id };

                            addNewSkill.ps.Add(ps);
                            employee.ps.Add(ps);

                            db.ps.InsertOnSubmit(ps);

                        }
                    }

                    db.SubmitChanges();
                    Close();
                }
            }
        }



        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {

            Form ifrm = new FormEmployee();
            ifrm.ShowDialog();
            using (var db = Program.OpenConnection())
                Update_checkedListBoxEmployee(db);
            
        }

    }
}
