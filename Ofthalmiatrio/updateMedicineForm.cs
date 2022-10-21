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
    public partial class updateMedicineForm : Form
    {
        private string id;
        public updateMedicineForm(string id)
        {
            InitializeComponent();
            this.id = id;
            var data = DatabaseDev.getMedicine(id);
            if (data.HasRows)
            {
                data.Read();
                {
                    onoma.Text = data["onoma"].ToString();
                    auth.Select();
                    if (data["typos"].ToString() == "Φασών")
                    {
                        fas.Select();
                    }
                    symptomata.Text = data["symptomata"].ToString();
                    promitheftes.Text = data["promitheftes"].ToString();
                
                }
            }
            
        }

        private void add_med_butt_Click(object sender, EventArgs e)
        {
            string check =fas.Text;
            if (auth.Checked)
            {
                check=auth.Text;
            }
            
            if (onoma.Text == "")
            {
                MessageBox.Show("Onoma is required");
            }
            else {
                bool j = DatabaseDev.updateMedicine(id, onoma.Text, check, symptomata.Text, promitheftes.Text);
                if (j)
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed");
                }


            }


            
          

        }
    }
}
