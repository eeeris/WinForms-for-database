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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }



        private void UpdateSkillsList()
        {
            checkedListBoxSkills.Items.Clear();

            foreach ((skill skill, bool isLinkedWithEmployee) in DataProvider.UpdateCheckedListBoxSkills(ChangingEmployee))
            {
                checkedListBoxSkills.Items.Add(skill, isLinkedWithEmployee);
            }

            /*using (var db = Program.OpenConnection())

            {
                var sortedSkills = from s in db.skill
                                   orderby s.skill_name
                                   select s;


                foreach (var skill in sortedSkills)
                {
                    try
                    {
                        var em = db.employee.Where(x => x.employee_id == ChangingEmployee.employee_id).Single();
                        bool isLinkedWithEmployee = em.ps.Any(x => x.skill == skill);//"Доступ к ликвидированному объекту невозможен.
                        checkedListBoxSkills.Items.Add(skill, isLinkedWithEmployee);
                    }
                    catch
                    { checkedListBoxSkills.Items.Add(skill); }

                }*/
        }



        public TestTask.Mapping.employee ChangingEmployee
        {
            get; set;
        }


        private void UpdateUI()
        {
            if (ChangingEmployee.employee_id == 0)
            {
                textSecondName.Text = null;
                textFirstName.Text = null;
                textPosition.Text = null;
                textEducation.Text = null;
                dateOfBirth.Text = null;
                textAddress.Text = null;
                textPassportNumber.Text = null;
                textPhoneNumber.Text = null;
                textMail.Text = null;
            }
            else
            {
                textSecondName.Text = ChangingEmployee.second_name;
                textFirstName.Text = ChangingEmployee.first_name;
                textPosition.Text = ChangingEmployee.position;
                textEducation.Text = ChangingEmployee.education;

                if (ChangingEmployee.date_of_birth.HasValue)
                {
                    try
                        { dateOfBirth.Value = ChangingEmployee.date_of_birth.Value;
                        dateOfBirth.Checked = true; }
                    catch { }
                }
                else
                {
                    dateOfBirth.Checked = false;
                }

                textAddress.Text = ChangingEmployee.address;
                textPassportNumber.Text = ChangingEmployee.passport_number?.ToString();
                textPhoneNumber.Text = ChangingEmployee.phone_number?.ToString();
                textMail.Text = ChangingEmployee.mail;
            }
        }



        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textSecondName.Text) || String.IsNullOrEmpty(textFirstName.Text) || String.IsNullOrEmpty(textPosition.Text))
            {
                MessageBox.Show(
                "Заполните все поля, отмеченные звездочкой",
                "Не заполнены все обязательные поля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
               
            }
            else
            {
                /*using (var db = Program.OpenConnection())
                {
                    var employees = db.employee;

                    if (ChangingEmployee.employee_id != 0)
                    {
                        ChangingEmployee = db.employee.First(x => x.employee_id == ChangingEmployee.employee_id);
                    }*/

                //*DataProvider.ChangeEmployee(ChangingEmployee);

                Action<employee> setter = (changingEmployee) =>
                {
                    changingEmployee.second_name = textSecondName.Text;
                    changingEmployee.first_name = textFirstName.Text;
                    changingEmployee.position = textPosition.Text;
                    changingEmployee.education = textEducation.Text;
                    changingEmployee.date_of_birth = dateOfBirth.Value;
                    changingEmployee.address = textAddress.Text;
                    try
                    { changingEmployee.passport_number = Convert.ToInt64(textPassportNumber.Text); }
                    catch
                    { changingEmployee.passport_number = null; }
                    try
                    { changingEmployee.phone_number = Convert.ToInt64(textPhoneNumber.Text); }
                    catch
                    { changingEmployee.phone_number = null; }
                    changingEmployee.mail = textMail.Text;
                };

                //var skillsIDs = checkedListBoxSkills.CheckedItems.Cast<Mapping.skill>().Select(x => x.skill_id);
                var skills = Enumerable.Range(0, checkedListBoxSkills.Items.Count).Select(i => ((checkedListBoxSkills.Items[i] as skill).skill_id, checkedListBoxSkills.GetItemChecked(i)));

                DataProvider.AddOrChangeEmployee(ChangingEmployee.employee_id, skills, setter);
                Close();

                /*if (ChangingEmployee.employee_id == 0)
                {
                    employees.InsertOnSubmit(ChangingEmployee);
                    db.SubmitChanges();
                }

                for (int i = 0; i < checkedListBoxSkills.Items.Count; i++)
                {
                    var skill = checkedListBoxSkills.Items[i] as Mapping.skill;

                    var association = ChangingEmployee.ps.FirstOrDefault(x => x.skill.skill_id == skill.skill_id);// потерян экземпляр

                    if (checkedListBoxSkills.GetItemChecked(i) == true && association == null)
                    {
                        association = new Mapping.ps { person_id = ChangingEmployee.employee_id, skills_id = skill.skill_id };

                        ChangingEmployee.ps.Add(association);
                        skill.ps.Add(association);

                        db.ps.InsertOnSubmit(association);

                    }
                    else if (checkedListBoxSkills.GetItemChecked(i) == false && association != null)
                    {

                        db.ps.DeleteOnSubmit(association);

                    }
                }

                db.SubmitChanges();*/
            }

            


        }


        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormSkill();
            ifrm.ShowDialog();
            UpdateSkillsList();
        }



        private void Form2_Shown(object sender, EventArgs e)
        {
            if (ChangingEmployee == null)
                ChangingEmployee = new TestTask.Mapping.employee();

            UpdateSkillsList();
            UpdateUI();
        }
    }
}

