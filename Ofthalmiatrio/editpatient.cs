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
    public partial class editpatient : Form


    {
        private string amka;
        public editpatient(String AMKA,String Fullname,String asfaleiam)
        {
            InitializeComponent();
            fullname.Text = Fullname;
            asfaleia.Text = asfaleiam;
            amka = AMKA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (fullname.Text == "")
            {
                MessageBox.Show("fullname field is neccesary");

            }else if (asfaleia.Text=="") {
                MessageBox.Show("Asfaleia field is neccesary");
            }
            else
            {
               bool t= DatabaseDev.updateAstheneis(amka, fullname.Text, asfaleia.Text);
               if (t)
                {
                    
                    MessageBox.Show("Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }

        }
    }
}
