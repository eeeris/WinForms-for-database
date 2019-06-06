using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Data;

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

            var skills = Program.Database.GetTable<Data.Skill>();


            var sortedSkills = from s in skills
                               
                               orderby s.SkillName
                               select s;


            foreach (var skill in sortedSkills)
                if (ChangingEmployee.SecondName == null)
                    checkedListBoxSkills = null;
                else
                {
                bool isLinkedWithEmployee = ChangingEmployee.Ps.Any(x => x.Skill == skill);
                checkedListBoxSkills.Items.Add(skill, isLinkedWithEmployee);
                }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateSkillsList();
            UpdateUI();
        }

        public Data.Employee ChangingEmployee
        {
            get; set;
        }

        private void UpdateUI()
        {
            if (ChangingEmployee.SecondName == null)
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
                textSecondName.Text = ChangingEmployee.SecondName;
                textFirstName.Text = ChangingEmployee.FirstName;
                textPosition.Text = ChangingEmployee.Position;
                textEducation.Text = ChangingEmployee.Education;

                if (ChangingEmployee.YearOfBirth.HasValue)
                {
                    dateOfBirth.Value = ChangingEmployee.YearOfBirth.Value;
                    dateOfBirth.Checked = true;
                }
                else
                {
                    dateOfBirth.Checked = false;
                }

                textAddress.Text = ChangingEmployee.Address;
                textPassportNumber.Text = ChangingEmployee.PassportNumber?.ToString();
                textPhoneNumber.Text = ChangingEmployee.PhoneNumber?.ToString();
                textMail.Text = ChangingEmployee.Mail;

            }
        }



        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {


            ChangingEmployee.SecondName = textSecondName.Text;
            ChangingEmployee.FirstName = textFirstName.Text;
            ChangingEmployee.Position = textPosition.Text;
            ChangingEmployee.Education = textEducation.Text;
            ChangingEmployee.YearOfBirth = dateOfBirth.Value;
            ChangingEmployee.Address = textAddress.Text;
            ChangingEmployee.PassportNumber = Convert.ToInt64(textPassportNumber.Text);
            ChangingEmployee.PhoneNumber = Convert.ToInt64(textPhoneNumber.Text);
            ChangingEmployee.Mail = textMail.Text;
            ChangingEmployee.Ps = new System.Data.Linq.EntitySet<Ps>();

            var employees = Program.Database.GetTable<Data.Employee>();


            if (ChangingEmployee.Id == 0)
            {

                employees.InsertOnSubmit(ChangingEmployee);
                Program.Database.SubmitChanges();
 
                
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

