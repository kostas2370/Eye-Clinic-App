using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofthalmiatrio
{
    public partial class edituserform : Form
    {
        string id;
        public edituserform(string id)
        {
            InitializeComponent();
            this.id = id;
            setstyle.setStyle(this);
            var data = DatabaseDev.getUser(id);
            data.Read();
            usernametext.Text = data["username"].ToString();
            passwordtext.Text = data["password"].ToString();
            password_ver_text.Text = data["password"].ToString();
            roles.Text = data["role"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametext.Text == "")
            {
                MessageBox.Show("You need to put a valid username");

            }
            else if (passwordtext.Text == "")
            {
                MessageBox.Show("You need to insert a password");

            }
            else if (password_ver_text.Text != passwordtext.Text)
            {
                MessageBox.Show("Wrong verification");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to update this user ?", "Are you sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DatabaseDev.updateUser(this.id, usernametext.Text, passwordtext.Text, roles.Text))
                    {
                        MessageBox.Show("Success");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("You cant use this username");
                    }

                ;
                }
            }
        }
    }
}
