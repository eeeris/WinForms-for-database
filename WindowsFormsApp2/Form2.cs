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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void UpdateSkillsList()
        {
            checkedListBoxSkills.Items.Clear();

            var sortedSkills = from s in Program.Database.skill
                               orderby s.skill_name
                               select s;


            foreach (var skill in sortedSkills)
            {
                if (ChangingEmployee.second_name == null)
                    checkedListBoxSkills.Items.Add(skill);
                else
                {
                    bool isLinkedWithEmployee = ChangingEmployee.ps.Any(x => x.skill == skill);
                    checkedListBoxSkills.Items.Add(skill, isLinkedWithEmployee);
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateSkillsList();
            UpdateUI();
        }

        public TestTask.Mapping.employee ChangingEmployee
        {
            get; set;
        }

        private void UpdateUI()
        {
            if (ChangingEmployee.second_name == null)
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


            ChangingEmployee.second_name = textSecondName.Text;
            ChangingEmployee.first_name = textFirstName.Text;
            ChangingEmployee.position = textPosition.Text;
            ChangingEmployee.education = textEducation.Text;
            ChangingEmployee.date_of_birth = dateOfBirth.Value;
            ChangingEmployee.address = textAddress.Text;

            try
            { ChangingEmployee.passport_number = Convert.ToInt64(textPassportNumber.Text); }
            catch
            { ChangingEmployee.passport_number = null; }

            try
            { ChangingEmployee.phone_number = Convert.ToInt64(textPhoneNumber.Text); }
            catch
            { ChangingEmployee.phone_number = null; }

            ChangingEmployee.mail = textMail.Text;
            ChangingEmployee.ps = new System.Data.Linq.EntitySet<Mapping.ps>();

            var employees = Program.Database.employee;


            if (ChangingEmployee.employee_id == 0)
            {

                employees.InsertOnSubmit(ChangingEmployee);
                Program.Database.SubmitChanges();
 
                
             }



            for (int i = 0; i < checkedListBoxSkills.Items.Count; i++)
            {
                var skill = checkedListBoxSkills.Items[i] as Mapping.skill;

                bool isLinkedWithEmployee = ChangingEmployee.ps.Any(x => x.skill == skill);

                if (checkedListBoxSkills.GetItemChecked(i) == true && isLinkedWithEmployee == false)
                {
                    var ps = new Mapping.ps { person_id = ChangingEmployee.employee_id, skills_id = skill.skill_id };


                    Program.Database.ps.InsertOnSubmit(ps);
                    Program.Database.SubmitChanges();
                }


            }
                    






            Close();
            



        }





        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {

            Form ifrm = new Form3();
            ifrm.ShowDialog();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBoxSkills_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}

