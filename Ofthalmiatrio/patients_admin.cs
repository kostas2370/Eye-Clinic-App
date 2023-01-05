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
            axonas_aristera.Text = "0";
            axonas_dexia.Text = "0";

            diarkeia_therapeias.Text = "30";
            kostos.Text = "20";


            var data = DatabaseDev.getPatients(null, mode: "all");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    string date = "-";
                    var last_visit = DatabaseDev.getLastVisit(data["AMKA"].ToString());
                    if (last_visit.HasRows)
                    {
                        last_visit.Read();
                        date = last_visit["hmerominia"].ToString();
                    }
                    patientdatagrid.Rows.Add(data["AMKA"], data["OnomaTeponimo"], date);

                }
            }
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
                    patientdatagrid.Rows.Add(amka.Text, fullname.Text, "-");
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

            var last_rantevou = DatabaseDev.getLastVisit(comboBox.Text);
            if (last_rantevou.HasRows)
            {
                last_rantevou.Read();
                myopia_aristero.Text = last_rantevou["myopia_aristero"].ToString().Replace(',','.');
                myopia_dexio.Text = last_rantevou["myopia_dexio"].ToString().Replace(',', '.');
                presviopia_aristero.Text = last_rantevou["presviopia_aristero"].ToString().Replace(',', '.');
                presviopia_dexio.Text = last_rantevou["presviopia_dexio"].ToString().Replace(',', '.');
                ypermetropia_aristero.Text = last_rantevou["ypermatropia_aristero"].ToString().Replace(',', '.');
                ypermetropia_dexio.Text = last_rantevou["ypermatropia_dexio"].ToString().Replace(',', '.');
                astigmatismos_aristero.Text = last_rantevou["astigmatismos_aristero"].ToString().Replace(',', '.') ;
                astigmatismos_dexio.Text = last_rantevou["astigmatismos_dexio"].ToString().Replace(',', '.');
                axonas_aristera.Text = last_rantevou["axonas_aristera"].ToString();
                axonas_dexia.Text = last_rantevou["axonas_dexia"].ToString();
                piesh_aristero.Text = last_rantevou["piesh_aristero"].ToString().Replace(',', '.');
                piesh_dexio.Text = last_rantevou["piesh_dexio"].ToString().Replace(',', '.');
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

        private void add_visit_Click(object sender, EventArgs e)
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
            else if (astigmatismos_aristero.Text != "0" & axonas_aristera.Text =="0")
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
                    foreach (DataGridViewRow Row in patientdatagrid.Rows)
                    {
                        if (Row.Cells["AMKA_C"].ToString() == AMKA_CHOICES.Text)
                        {
                            Row.Cells["last_visit"].Value = visit_date.Value.ToString("yyyy-MM-dd");
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
                    axonas_aristera.Text = "0";
                    axonas_dexia.Text = "0";
                    astheneia.Text = "";
                    AMKA_CHOICES.Text = "";
                    therapeia.Text = "";
                    farmaka.Text = "";
                    diarkeia_therapeias.Text = "30";
                    kostos.Text = "20";

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

        private void search_butt_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (DataGridViewRow Row in patientdatagrid.Rows)
            {
                if (Row.Cells["Fullname_c"].Value.ToString().Equals(search_at.Text) || Row.Cells["AMKA_C"].Value.ToString().Equals(search_at.Text))
                {

                    Row.Visible = true;
                    found = true;

                }
                else if (search_at.Text == "")
                {
                    Row.Visible = true;


                }
                else
                {
                    Row.Visible = false;
                }

            }
            if (!found)
            {
                MessageBox.Show("Didnt find it");
            }
        }
    

    

        private void movetomedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm form = new MedicineForm();
            form.ShowDialog();
            form.Close();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

   
        private void user_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void patientdatagrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string AMKA = patientdatagrid.Rows[e.RowIndex].Cells["AMKA_C"].FormattedValue.ToString();
                var info = DatabaseDev.getPatients(AMKA);
                patient form = new patient(info);
                form.ShowDialog();

            }
            catch (Exception x)
            {

            }
        }

        private void patientdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string AMKA = patientdatagrid.Rows[e.RowIndex].Cells["AMKA_C"].FormattedValue.ToString();

                if (patientdatagrid.Columns[e.ColumnIndex].Name == "delete_c")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this patient ?", "Are you sure ?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        bool j = DatabaseDev.deletePatient(AMKA);
                        if (j)
                        {
                            MessageBox.Show("Deleted succesfully");
                            patientdatagrid.Rows[e.RowIndex].Visible = false;
                            AMKA_CHOICES.Items.Remove(AMKA);
                        }
                    }
                }
                else if (patientdatagrid.Columns[e.ColumnIndex].Name == "edit_c")
                {
                    var asthen = DatabaseDev.getPatients(AMKA);
                    asthen.Read();
                    editpatient form = new editpatient(asthen["AMKA"].ToString(), asthen["OnomaTeponimo"].ToString(), asthen["asfaleia"].ToString());
                    form.ShowDialog();
                    asthen = DatabaseDev.getPatients(AMKA);
                    asthen.Read();
                    patientdatagrid.Rows[e.RowIndex].Cells[1].Value = asthen["OnomaTeponimo"].ToString();

                }
            }catch (Exception x)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in patientdatagrid.Rows)
            {

                Row.Visible = true;


            }
        }
    }
}
