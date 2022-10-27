using Aspose.Pdf;
using Aspose.Pdf.Operators;
using Microsoft.VisualBasic.Logging;
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
    public partial class usersettingsform : Form
    {
        private string password;
        public usersettingsform()
        {
            InitializeComponent();
            setstyle.setStyle(this);
            var data = DatabaseDev.getUser(Form1.userid);
            data.Read();
            username.Text = data["username"].ToString();
            new_password.Text = data["password"].ToString();
            password_ver.Text = data["password"].ToString();
            password= data["password"].ToString();
            if (Form1.userrole == "secretary")
            {
                movetomedicine.Visible = false;
                movetomedicine.Enabled = false;
                settingsbutt.Location = new System.Drawing.Point(settingsbutt.Location.X - 130, settingsbutt.Location.Y);

            }
            else if (Form1.userrole == "drug specialist")
            {
                patientbut.Visible = false;
                patientbut.Enabled = false;
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("You need to add a valid username ");
            } else if (new_password.Text == "")
            {
                MessageBox.Show("You need to add a valid password ");
            } else if (password_ver.Text != new_password.Text)
            {
                MessageBox.Show("Wrong password verification ");
            } else if (old_password.Text != password)
            {

                MessageBox.Show("Wrong old password");
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure that you want to update yout info ?", "Are you sure ?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DatabaseDev.updateUser(Form1.userid, username.Text, new_password.Text, Form1.userrole);
                        MessageBox.Show("Success !");

                        Form1 form = new Form1();
                        this.Hide();
                        form.ShowDialog();

                    }
                }
                    catch (Exception x)
                {
                    MessageBox.Show("This username is used !");
                }
            }
    
        }

        private void movetomedicine_Click(object sender, EventArgs e)
        {
            MedicineForm form = new MedicineForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
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
            else if(Form1.userrole == "doctor")
            {
                
                giatros form = new giatros();

                form.ShowDialog();
                this.Close();
               
            }else if (Form1.userrole == "secretary")
            {
                secreteriat form = new secreteriat();
                form.ShowDialog();
                this.Close();
                
            }
            this.Close();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

    
    }
}
