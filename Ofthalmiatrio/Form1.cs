using System.Data.SQLite;

namespace Ofthalmiatrio
{
    public partial class Form1 : Form
    {
        public static string usernamelog;
        public static string userrole;
        public static string userid;
        public Form1()
        {
           
           InitializeComponent();
            usernamelog = null;
            userrole = null;
            userid = null;
            setstyle.setStyle(this);
            /*
              if the db doesnt exists it creates the db connection
              and setup the tables

            if it exists it just create the connection
            */
            if (!(File.Exists("database.db")))
          
            {
                DatabaseDev.createDb();
                DatabaseDev.CreateTables();

            }

            else
            {
                DatabaseDev.createDb();
            }
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_butt_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("You need to add username");
            }else if (password.Text == "")
            {
                MessageBox.Show("You need to add password");
            }
            else
            {
                var login = DatabaseDev.Login(username.Text, password.Text);
                if (login.HasRows)
                {
                     login.Read();
                    {
                        usernamelog = login["username"].ToString();
                        userrole= login["role"].ToString();
                        userid = login["id"].ToString();
                        MessageBox.Show($"Welcome {usernamelog}");
                        this.Hide();
                       
                        
                        if (login["role"].ToString() == "admin")
                        {

                            patients_admin log = new patients_admin();
                            login.Close();
                            log.ShowDialog();
                          
                        }
           
                        else if (login["role"].ToString() == "doctor")
                        {
                            giatros log = new giatros();
                            login.Close();
                            log.ShowDialog();

                        }
                        else if (login["role"].ToString() == "secretary")
                        {
                            secreteriat log = new secreteriat();
                            login.Close();
                            log.ShowDialog();

                        }else if (login["role"].ToString()=="drug specialist")
                        {
                            MedicineForm log = new MedicineForm();
                            login.Close();
                            log.ShowDialog();
                            
                        }


                        else {
                            MessageBox.Show("You dont have role yet");
                            

                        }

                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong login info,try again !");

                }

            }
        }
    }
}