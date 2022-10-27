using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofthalmiatrio
{
    public partial class EditRant : Form
    {
        private string id;
        public EditRant(SQLiteDataReader rantevou_info)
        {
            InitializeComponent();
            setstyle.setStyle(this);
            rantevou_info.Read();
            this.id = rantevou_info["id"].ToString(); ;   
            amka.Text = rantevou_info["AMKA"].ToString(); 
            hmerominia.Text = rantevou_info["hmerominia"].ToString(); ;
            myopia_aristero.Text = rantevou_info["myopia_aristero"].ToString().Replace(',', '.');
            myopia_dexio.Text = rantevou_info["myopia_dexio"].ToString().Replace(',', '.');
            presviopia_aristero.Text = rantevou_info["presviopia_aristero"].ToString().Replace(',', '.');
            presviopia_dexio.Text = rantevou_info["presviopia_dexio"].ToString().Replace(',', '.');
            ypermetropia_aristero.Text = rantevou_info["ypermatropia_aristero"].ToString().Replace(',', '.');
            ypermetropia_dexio.Text = rantevou_info["ypermatropia_dexio"].ToString().Replace(',', '.');
            astigmatismos_aristero.Text = rantevou_info["astigmatismos_aristero"].ToString().Replace(',', '.'); ;
            astigmatismos_dexio.Text = rantevou_info["astigmatismos_dexio"].ToString().Replace(',', '.');
            piesh_aristero.Text= rantevou_info["piesh_aristero"].ToString().Replace(',', '.');
            piesh_dexio.Text= rantevou_info["piesh_dexio"].ToString().Replace(',', '.');
            astheneia.Text = rantevou_info["asthenia"].ToString();
            therapia.Text = rantevou_info["therapia"].ToString();
            farmak.Text = rantevou_info["farmaka"].ToString();
            diarkeia_therapeias.Text = rantevou_info["diarkeia_therapeias"].ToString();
            apot.Text = rantevou_info["Apotelesmata"].ToString();
            axa.Text= rantevou_info["axonas_aristera"].ToString();
            axd.Text = rantevou_info["axonas_dexia"].ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to update this visit ?", "Are you sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DatabaseDev.updateVisit(id, myopia_aristero.Text, myopia_dexio.Text, presviopia_aristero.Text, presviopia_dexio.Text, ypermetropia_aristero.Text, ypermetropia_dexio.Text, astigmatismos_aristero.Text, astigmatismos_dexio.Text,axa.Text,axd.Text, piesh_aristero.Text, piesh_dexio.Text, astheneia.Text, therapia.Text, farmak.Text, diarkeia_therapeias.Text, apot.Text);
                    MessageBox.Show("Success");
                    this.Close();
                }
            
            }catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
    }
}
