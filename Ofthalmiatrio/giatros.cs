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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool j=false;
            if (AMKA_CHOICES.Text == "")
            {
                MessageBox.Show("You must insert a valid AMKA");
            }
            else if (kostos.Text == "")
            {
                MessageBox.Show("You must insert a valid cost");
            }
            try
            {


                j = DatabaseDev.addVisit(AMKA_CHOICES.Text, visit_date.Value.ToString("yyyy-MM-dd"), myopia_aristero.Text, myopia_dexio.Text, presviopia_aristero.Text, presviopia_dexio.Text, ypermetropia_aristero.Text, ypermetropia_dexio.Text, astigmatismos_aristero.Text, astigmatismos_dexio.Text, piesh_aristero.Text, piesh_dexio.Text, astheneia.Text, therapeia.Text, farmaka.Text, diarkeia_therapeias.Text, kostos.Text);


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

        private void AMKA_CHOICES_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            var last_rantevou = DatabaseDev.getLastVisit(comboBox.Text);
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            usersettingsform form = new usersettingsform();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
    

