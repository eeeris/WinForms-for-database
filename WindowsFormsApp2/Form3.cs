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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {

            Form ifrm = new Form2();
            ifrm.ShowDialog();
            //using (var db = new DataContext())
            {
                
            }
        }

    }
}
