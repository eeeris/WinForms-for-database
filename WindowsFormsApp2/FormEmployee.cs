using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            foreach ((skill skill, bool isLinkedWithEmployee) in DataProvider.UpdateCheckedListBoxSkills(ChangingEmployee.employee_id))
            {
                checkedListBoxSkills.Items.Add(skill, isLinkedWithEmployee);
            }
        }


        public employee ChangingEmployee
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
                    {
                        dateOfBirth.Value = ChangingEmployee.date_of_birth.Value;
                        dateOfBirth.Checked = true;
                    }
                    catch
                    {
                    }
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

                var skills = Enumerable.Range(0, checkedListBoxSkills.Items.Count).Select(i => ((checkedListBoxSkills.Items[i] as skill).skill_id, checkedListBoxSkills.GetItemChecked(i)));

                DataProvider.AddOrChangeEmployee(ChangingEmployee.employee_id, skills, setter);
                Close();
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
                ChangingEmployee = new employee();

            dateOfBirth.MaxDate = DateTime.Now;

            UpdateSkillsList();
            UpdateUI();
        }
    }
}

