using Aspose.Pdf;
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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            roles.Text = "no role";
            setstyle.setStyle(this);

            var userdata = DatabaseDev.getUser();
            int j = 0;
            if (userdata.HasRows)
            {
                while (userdata.Read())
                {
                    userdatagrid.Rows.Add(userdata["id"].ToString(),userdata["username"].ToString(), userdata["password"].ToString(), userdata["role"].ToString());
                  
                
                }
            }
        }

        private void patientbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            patients_admin form = new patients_admin();
            form.ShowDialog();
            form.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametext.Text == "")
            {
                MessageBox.Show("You need to put a valid username");

            }else if (passwordtext.Text == "")
            {
                MessageBox.Show("You need to insert a password");

            }else if (password_ver_text.Text != passwordtext.Text)
            {
                MessageBox.Show("Wrong verification");
            }
            else

            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to add this user ?", "Are you sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string user = DatabaseDev.addUser(usernametext.Text, passwordtext.Text, roles.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Success !");
                        userdatagrid.Rows.Add(user, usernametext.Text, passwordtext.Text, roles.Text);
                        roles.Text = "no role";
                        usernametext.Text = "";
                        passwordtext.Text = "";
                        password_ver_text.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("This user already exists !");
                    }
                }

            }

        }

        private void userdatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }

        }

        private void searchbutt_Click(object sender, EventArgs e)
        {
            string user = usersearch.Text;
            int j = 0;

            foreach (DataGridViewRow Row in userdatagrid.Rows)
            {
                if (Row.Cells["username"].Value.ToString().Equals(user))
                {

                    Row.Visible = true;
                    j++;

                }
                else if (user == "")
                {
                    Row.Visible = true;
                    j++;

                }
                else
                {
                    Row.Visible = false;
                }

            }
            if (j == 0)
            {
                MessageBox.Show("couldnt find");
            }
        }

        private void show_all_butt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in userdatagrid.Rows)
            {
                Row.Visible = true;
            }
        }

        private void userdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string role = userdatagrid.Rows[e.RowIndex].Cells["role"].FormattedValue.ToString();

            string username = userdatagrid.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
            string id=userdatagrid.Rows[e.RowIndex].Cells["userid"].FormattedValue.ToString();

            if (userdatagrid.Columns[e.ColumnIndex].Name == "deletebut" | userdatagrid.Columns[e.ColumnIndex].Name == "editbut")
            {
               
                if (role != "admin" | Form1.usernamelog==username)
                {
                    if (userdatagrid.Columns[e.ColumnIndex].Name == "deletebut")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this user ?", "Are you sure ?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes) {
                            if (DatabaseDev.deleteUser(id))
                            {
                                MessageBox.Show("Success !");
                                if (username == Form1.usernamelog)
                                {
                                    this.Hide();
                                    Form1 form = new Form1();
                                    Form1.usernamelog = null;
                                    form.ShowDialog();
                                    this.Close();


                                }
                                else
                                {
                                    userdatagrid.Rows[e.RowIndex].Visible = false;

                                }
                            }
                        }

                    }
                    else if (userdatagrid.Columns[e.ColumnIndex].Name == "editbut")
                    {
                        edituserform form = new edituserform(id);
                        form.ShowDialog();
                        var user = DatabaseDev.getUser(id);
                        if (username == Form1.usernamelog)
                        {
                            this.Hide();
                            Form1 form2 = new Form1();
                            Form1.usernamelog = null;
                            form2.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            user.Read();
                            userdatagrid.Rows[e.RowIndex].Cells["username"].Value = user["username"].ToString();
                            userdatagrid.Rows[e.RowIndex].Cells["password"].Value = new string('*', user["password"].ToString().Length);
                            userdatagrid.Rows[e.RowIndex].Cells["role"].Value = user["role"].ToString();
                        }
                    }
                    

                }
                else
                {
                    MessageBox.Show("No permission");

                }



            }
        }
    }
    }
    

