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
    public partial class giatros : Form
    {
        public giatros()
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
            axonas_aristera.Text = "0";
            axonas_dexia.Text = "0";
            piesh_aristero.Text = "0";
            piesh_dexio.Text = "0";
            diarkeia_therapeias.Text = "30";
            kostos.Text = "20";

            var data = DatabaseDev.getAstheneis(null, mode: "all");
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
                    foreach (DataGridViewRow Row in patientdatagrid.Rows)
                    {
                        if (Row.Cells["AMKA_C"].ToString() == AMKA_CHOICES.Text)
                        {
                            Row.Cells["last_visit"].Value = visit_date.Value.ToString("yyyy-MM-dd");
                        }
                    }

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
    
    

    private void AMKA_CHOICES_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            var last_rantevou = DatabaseDev.getLastVisit(comboBox.Text);
            if (last_rantevou.HasRows)
            {
                last_rantevou.Read();
                myopia_aristero.Text = last_rantevou["myopia_aristero"].ToString().Replace(',', '.');
                myopia_dexio.Text = last_rantevou["myopia_dexio"].ToString().Replace(',', '.');
                presviopia_aristero.Text = last_rantevou["presviopia_aristero"].ToString().Replace(',', '.');
                presviopia_dexio.Text = last_rantevou["presviopia_dexio"].ToString().Replace(',', '.');
                ypermetropia_aristero.Text = last_rantevou["ypermatropia_aristero"].ToString().Replace(',', '.');
                ypermetropia_dexio.Text = last_rantevou["ypermatropia_dexio"].ToString().Replace(',', '.');
                astigmatismos_aristero.Text = last_rantevou["astigmatismos_aristero"].ToString().Replace(',', '.');
                astigmatismos_dexio.Text = last_rantevou["astigmatismos_dexio"].ToString().Replace(',', '.');
                axonas_aristera.Text = last_rantevou["axonas_aristera"].ToString().Replace(',', '.');
                axonas_aristera.Text = last_rantevou["axonas_dexia"].ToString().Replace(',', '.');
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
                axonas_aristera.Text = "0";
                axonas_dexia.Text = "0";
                piesh_aristero.Text = "0";
                piesh_dexio.Text = "0";
                astheneia.Text = "";
                therapeia.Text = "";
                farmaka.Text = "";
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

        private void show_all_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in patientdatagrid.Rows)
            {

                Row.Visible = true;


            }
        }

        private void patientdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string AMKA = patientdatagrid.Rows[e.RowIndex].Cells["AMKA_C"].FormattedValue.ToString();
                var info = DatabaseDev.getAstheneis(AMKA);
                patient form = new patient(info);
                form.ShowDialog();

            }
            catch (Exception x)
            {

            }
        }

        private void logout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();

        }

        private void movetomedicine_Click(object sender, EventArgs e)
        {
            MedicineForm form = new MedicineForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void usersettings_Click(object sender, EventArgs e)
        {
            usersettingsform form = new usersettingsform();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

     
    }
}
    

