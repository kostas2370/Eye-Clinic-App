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
    public partial class MedicineForm : Form
    {
        public MedicineForm()
        {
            InitializeComponent();
            auth.Select();
            setstyle.setStyle(this);

            var meds =DatabaseDev.getMedicine();
            if (meds.HasRows)
            {
                while (meds.Read())
                {
                    medicingridview.Rows.Add(meds["id"],meds["onoma"], meds["typos"], meds["symptomata"], meds["promitheftes"]);
                }
                meds.Close();

            }

            if (Form1.userrole != "admin" && Form1.userrole !="drug specialist")
            {
                userbutt.Text = "Settings";
                medicingridview.Columns.Remove("delete");
                medicingridview.Columns.Remove("Edit");
               
            }
            if (Form1.userrole == "drug specialist")

            {
                userbutt.Text = "Settings";
                patientbut.Visible = false;
                patientbut.Enabled = false;
                
            }
        }   

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Form1.userrole == "admin")
            {
                patients_admin form = new patients_admin();

                form.ShowDialog();
                this.Close();


            }
            else  if (Form1.userrole == "doctor")
            {
                giatros form = new giatros();

                form.ShowDialog();
                this.Close();
            }
            else if (Form1.userrole == "secretary")
            {
                secreteriat form = new secreteriat();
                form.ShowDialog();
                this.Close();

            }

        }

        
         

        private void logout_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            
        }

        private void add_med_butt_Click(object sender, EventArgs e)
        {
            string check;
            if (onoma.Text == "")
            {
                MessageBox.Show("Onoma field is required");

            }else {
                check = auth.Text;

                if (fas.Checked)
                {
                    check = fas.Text;
                }
                string j =DatabaseDev.addMedicine(onoma.Text, check, symptomata.Text, promitheftes.Text);
                if (!(j is null))
                {
                    MessageBox.Show("Success");
                    medicingridview.Rows.Add(j,onoma.Text, check, symptomata.Text, promitheftes.Text);

                    onoma.Text = "";
                    auth.Select();
                    promitheftes.Text = "";
                    symptomata.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed");
                }


            }
        }

        private void medicingridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ids = medicingridview.Rows[e.RowIndex].Cells["ids"].FormattedValue.ToString();
            if (medicingridview.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this medicine ?", "Are you sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DatabaseDev.deleteMedicine(ids);
                    medicingridview.Rows[e.RowIndex].Visible = false;
                }
            }
            else if (medicingridview.Columns[e.ColumnIndex].Name == "Edit")
            {
                updateMedicineForm form = new updateMedicineForm(ids);
                form.ShowDialog();
                var update_values = DatabaseDev.getMedicine(ids);
                update_values.Read();
                medicingridview.Rows[e.RowIndex].Cells["farmname"].Value = update_values["onoma"].ToString();
                medicingridview.Rows[e.RowIndex].Cells["types"].Value = update_values["typos"].ToString();
                medicingridview.Rows[e.RowIndex].Cells["symp"].Value = update_values["symptomata"].ToString();
                medicingridview.Rows[e.RowIndex].Cells["proms"].Value = update_values["promitheftes"].ToString();


            }
            else if (medicingridview.Columns[e.ColumnIndex].Name == "Save")
            {
                string path_name;
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Pdf Files|*.pdf";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path_name = save.FileName;
                    var data = DatabaseDev.getMedicine(ids);
                    data.Read();
                    PdfMaker.getMedicine(path_name, ids, data["onoma"].ToString(), data["typos"].ToString(), data["symptomata"].ToString(), data["promitheftes"].ToString());
                    data.Close();
                }



            }
            else if (medicingridview.Columns[e.ColumnIndex].Name == "Print")
            {
                var data = DatabaseDev.getMedicine(ids);
                data.Read();
                PdfMaker.getMedicine($"{"print.pdf"}", ids, data["onoma"].ToString(), data["typos"].ToString(), data["symptomata"].ToString(), data["promitheftes"].ToString());
                PdfMaker.print("print.pdf");


            }
        }

        private void medicingridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ids = medicingridview.Rows[e.RowIndex].Cells["ids"].FormattedValue.ToString();
                MedicineView form = new MedicineView(ids);
                form.ShowDialog();
                

            }catch (Exception x)
            {


            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string farmako = search.Text;
            int j = 0;
            
                foreach(DataGridViewRow Row in medicingridview.Rows)
                {
                    if (Row.Cells["farmname"].Value.ToString().Equals(farmako))
                    {

                        Row.Visible = true;
                    j++;

                    }else if(search.Text == "")
                    {
                        Row.Visible = true;
                    j++;

                    }
                    else
                    {
                        Row.Visible= false;
                    }

                }
                if (j == 0)
            {
                MessageBox.Show("couldnt find");
            }
            }

        private void showall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in medicingridview.Rows)
            {
                Row.Visible = true;
            }

        }

        private void settings_Click(object sender, EventArgs e)
        {
            
            if (Form1.userrole == "admin")
            {
                this.Hide();
                UserForm form = new UserForm();
                form.ShowDialog();
            }
            else
            {
                usersettingsform form = new usersettingsform();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            
           
            
            this.Close();
        }
    }
    }

