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
    public partial class EditRant : Form
    {
        private string id;
        public EditRant(string id,string AMKA, string visit_date, string mia, string mid, string pa, string pd, string ya, string yd, string aa, string ad, string pia, string pid, string asthenia, string therapeia, string farmaka, string diarkeia, string apotelesma)
        {
            InitializeComponent();
            this.id = id;   
            amka.Text = AMKA;
            hmerominia.Text = visit_date;
            myopia_aristero.Text = mia;
            myopia_dexio.Text = mid;
            presviopia_aristero.Text = pa;
            presviopia_dexio.Text = pd;
            ypermetropia_aristero.Text = ya;
            ypermetropia_dexio.Text = yd;
            astigmatismos_aristero.Text = aa;
            astigmatismos_dexio.Text = ad;
            piesh_aristero.Text= pia;
            piesh_dexio.Text= pid;
            astheneia.Text = asthenia;
            therapia.Text = therapeia;
            farmak.Text = farmaka;
            diarkeia_therapeias.Text = diarkeia;
            apot.Text = apotelesma;
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseDev.updateRantevou(id, myopia_aristero.Text, myopia_dexio.Text, presviopia_aristero.Text, presviopia_dexio.Text, ypermetropia_aristero.Text, ypermetropia_dexio.Text, astigmatismos_aristero.Text, astigmatismos_dexio.Text, piesh_aristero.Text, piesh_dexio.Text, astheneia.Text, therapia.Text, farmak.Text, diarkeia_therapeias.Text,apot.Text);
                MessageBox.Show("Success");
                this.Close();
            
            }catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
    }
}
