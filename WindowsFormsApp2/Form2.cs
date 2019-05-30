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

        /*private void textSacondName_TextChanged(object sender, EventArgs e)
        {
            textSacondName.Text = Form1.textFilterSecondName.Text;
        }*/

        private void UpdateSkillsList()
        {
            checkedListBoxSkills.Items.Clear();

            var skills = Program.Database.GetTable<Data.Skill>();


            var sortedSkills = from s in skills
                               //where textSacondName == null || s.Ps.Any(x => x.Employee == textSacondName)
                               //where s.SkillName.StartsWith(textSkills.Text)
                               orderby s.SkillName
                               select s;


            foreach (var skill in sortedSkills)
            {
                checkedListBoxSkills.Items.Add(skill);
            }
        }


        private void ButtonAddSkill_Click(object sender, EventArgs e)
        {

            Form ifrm = new Form3();
            ifrm.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateSkillsList();
        }
    }
}

