using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofthalmiatrio
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void patientbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            patients_admin patients_Admin = new patients_admin();
            patients_Admin.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {         
               this.Hide();
               MedicineForm form = new MedicineForm();
               form.ShowDialog();
               form.Close();
            
        }
    }
}
