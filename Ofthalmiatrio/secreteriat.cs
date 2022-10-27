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
    public partial class secreteriat : Form
    {
        public secreteriat()
        {
            InitializeComponent();
            setstyle.setStyle(this);
            var amk = DatabaseDev.getAMKAS();
            AMKA_CHOICES.DropDownStyle = ComboBoxStyle.DropDownList;
            if (amk.HasRows)
            {
                while (amk.Read())
                {
                    AMKA_CHOICES.Items.Add(amk["AMKA"]);

                }

            }
            myopia_aristero.Text = "0";
            myopia_dexio.Text = "0";
            presviopia_aristero.Text = "0";
            presviopia_dexio.Text = "0";
            ypermetropia_aristero.Text = "0";
            ypermetropia_dexio.Text = "0";
            astigmatismos_aristero.Text = "0";
            astigmatismos_dexio.Text = "0";
            piesh_aristero.Text = "0";
            piesh_dexio.Text = "0";
            diarkeia_therapeias.Text = "30";
            kostos.Text = "20";
        }

   
        private void add_patient_Click(object sender, EventArgs e)
        {
            if (amka.Text == "")
            {
                MessageBox.Show("You need to insert AMKA");
            }
            else if (fullname.Text == "")
            {
                MessageBox.Show("You need to insert Fullname");
            }
            else if (asfaleia.Text == "")
            {
                MessageBox.Show("You need it insert Asfaleia");
            }
            else
            {
                bool j = DatabaseDev.addPatient(amka.Text, fullname.Text, asfaleia.Text);
                if (j)
                {
                    MessageBox.Show("You added patient succesfully");
                    AMKA_CHOICES.Items.Add(amka.Text);
                    amka.Text = "";
                    fullname.Text = "";
                    asfaleia.Text = "";

                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void add_visit(object sender, EventArgs e)
        {
            bool j;
            if (AMKA_CHOICES.Text == "")
            {
                MessageBox.Show("You must insert a valid AMKA");
            }
            else if (kostos.Text == "")
            {
                MessageBox.Show("You must insert a valid cost");
            }
            else if (myopia_aristero.Text != "0" & ypermetropia_aristero.Text != "0")
            {

                MessageBox.Show("You cant have values more than 0 in both fields (myopia aristero and ypermetropia aristero) ");
            }
            else if (myopia_dexio.Text != "0" & ypermetropia_dexio.Text != "0")
            {

                MessageBox.Show("You cant have values more than 0 in both fields (myopia dexio and ypermetropia dexio) ");
            }
            else if (astigmatismos_aristero.Text != "0" & axonas_aristera.Text == "0")
            {
                MessageBox.Show("You must add axis value when u have astigmatismos ");

            }
            else if (astigmatismos_dexio.Text != "0" & axonas_dexia.Text == "0")
            {
                MessageBox.Show("You must add axis value when u have astigmatismos ");

            }


            else
            {
                try
                {


                    j = DatabaseDev.addVisit(AMKA_CHOICES.Text, visit_date.Value.ToString("yyyy-MM-dd"), myopia_aristero.Text, myopia_dexio.Text, presviopia_aristero.Text, presviopia_dexio.Text, ypermetropia_aristero.Text, ypermetropia_dexio.Text, astigmatismos_aristero.Text, astigmatismos_dexio.Text, axonas_aristera.Text, axonas_dexia.Text, piesh_aristero.Text, piesh_dexio.Text, astheneia.Text, therapeia.Text, farmaka.Text, diarkeia_therapeias.Text, kostos.Text);
                   

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Invalid data");
                    j = false;
                }

                if (j)
                {
                    MessageBox.Show("visit added sucesfully");
                }
            }
        
    }



        private void settings(object sender, EventArgs e)
        {
            this.Hide();
            usersettingsform form = new usersettingsform();
            form.ShowDialog();
            this.Close();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
    }

