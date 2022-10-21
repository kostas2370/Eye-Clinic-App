using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ofthalmiatrio
{
    
    public partial class patients_admin : Form
    {
        public patients_admin()
        {
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

     

        private void amka_visit_TextChanged(object sender, EventArgs e)
        {

        }


        /*
         We add patient here , 
        first we check if the fields are ok 
        after that we call the static function from databasedev class , with our connection and , the texts of the field
        at the end we check if we sucesfully added the patient
         
         */
        private void add_patient_Click(object sender, EventArgs e)
        {
            if (amka.Text == "")
            {
                MessageBox.Show("You need to insert AMKA");
            }else if (fullname.Text == "")
            {
                MessageBox.Show("You need to insert Fullname");
            }else if (asfaleia.Text == "")
            {
                MessageBox.Show("You need it insert Asfaleia");
            }
            else
            {
               bool j= DatabaseDev.addPatient(amka.Text, fullname.Text,asfaleia.Text);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            var last_rantevou = DatabaseDev.getLastRantevou(comboBox.Text);
            if (last_rantevou.HasRows)
            {
                last_rantevou.Read();
                myopia_aristero.Text = last_rantevou["myopia_aristero"].ToString();
                myopia_dexio.Text = last_rantevou["myopia_dexio"].ToString();
                presviopia_aristero.Text = last_rantevou["presviopia_aristero"].ToString();
                presviopia_dexio.Text = last_rantevou["presviopia_dexio"].ToString();
                ypermetropia_aristero.Text = last_rantevou["ypermatropia_aristero"].ToString();
                ypermetropia_dexio.Text = last_rantevou["ypermatropia_dexio"].ToString();
                astigmatismos_aristero.Text = last_rantevou["astigmatismos_aristero"].ToString(); ;
                astigmatismos_dexio.Text = last_rantevou["astigmatismos_dexio"].ToString();
                piesh_aristero.Text = last_rantevou["piesh_aristero"].ToString();
                piesh_dexio.Text = last_rantevou["piesh_dexio"].ToString();
                astheneia.Text = last_rantevou["asthenia"].ToString();
                therapeia.Text = last_rantevou["therapia"].ToString();
                farmaka.Text = last_rantevou["farmaka"].ToString();

            }
            else
            {

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
                astheneia.Text = "";
                therapeia.Text = "";
                farmaka.Text = "";
            }
            
            
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool j;
            if (AMKA_CHOICES.Text == "")
            {
                MessageBox.Show("You must insert a valid AMKA");
            }else if (kostos.Text == "")
            {
                MessageBox.Show("You must insert a valid cost");
            }
            try
            {
                

                j = DatabaseDev.addVisit(AMKA_CHOICES.Text, visit_date.Value.ToString("yyyy-MM-dd"), myopia_aristero.Text, myopia_dexio.Text, presviopia_aristero.Text, presviopia_dexio.Text, ypermetropia_aristero.Text, ypermetropia_dexio.Text, astigmatismos_aristero.Text, astigmatismos_dexio.Text, piesh_aristero.Text, piesh_dexio.Text, astheneia.Text, therapeia.Text, farmaka.Text, diarkeia_therapeias.Text, kostos.Text);


            }catch (Exception exception)
            {
                MessageBox.Show("Invalid data");
                j = false;
            }
            
            if (j)
            {
                MessageBox.Show("visit added sucesfully");
            }
        }

        private void search_butt_Click(object sender, EventArgs e)
        {
            if (search_at.Text == "")
            {
                MessageBox.Show("You need to insert an AMKA or FULLNAME !");
            }
            else
            {
                bool found=false;
                var search = DatabaseDev.getAstheneis(search_at.Text);
                if (!(search.HasRows))
                {
                    search = DatabaseDev.getAstheneis(search_at.Text,mode: "OnomaTeponimo");
                    if (search.HasRows)
                    {
                        found = true;
                    }
                   

                }
                else
                {
                    found = true;
                }

                if (found)
                {
                    
                    patient form = new patient(search);
                    
                    
                    form.ShowDialog();
                    if (patient.redo)
                    {
                        var search2 = DatabaseDev.getAstheneis(patient.amk);
                        patient.redo = false;
                        patient.amk = null;
                        form= new patient(search2);
                        form.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("We didnt find it");
                }
                
            }

        }

        private void movetomedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm form = new MedicineForm();
            form.ShowDialog();
            form.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void visit_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
