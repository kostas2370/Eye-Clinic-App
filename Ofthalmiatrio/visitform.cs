using OxyPlot.Axes;
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
    public partial class visitform : Form
    {
        public visitform(SQLiteDataReader patient_info, SQLiteDataReader rantevou)
        {
            InitializeComponent();
            setstyle.setStyle(this);

            if (patient_info.HasRows)
            {
                patient_info.Read();
                AMKA.Text = patient_info["AMKA"].ToString();
                onomatep.Text = patient_info["OnomaTeponimo"].ToString();
                asfaleia.Text = patient_info["Asfaleia"].ToString();
                
            }
            
            if(rantevou.HasRows){
                rantevou.Read();
                lastv.Text = rantevou["hmerominia"].ToString();
                ma.Text = rantevou["myopia_aristero"].ToString();
                md.Text = rantevou["myopia_dexio"].ToString();
                pa.Text = rantevou["presviopia_aristero"].ToString();
                pd.Text = rantevou["presviopia_dexio"].ToString();
                ya.Text = rantevou["ypermatropia_dexio"].ToString();
                yd.Text = rantevou["ypermatropia_dexio"].ToString();
                aa.Text = rantevou["astigmatismos_aristero"].ToString();
                ad.Text = rantevou["astigmatismos_dexio"].ToString();
                pia.Text = rantevou["piesh_aristero"].ToString();
                pid.Text = rantevou["piesh_dexio"].ToString();
                axa.Text = rantevou["axonas_aristera"].ToString();
                axd.Text = rantevou["axonas_dexia"].ToString();
                apotelesma.Text = rantevou["Apotelesmata"].ToString();
                astheneia.Text = rantevou["asthenia"].ToString();
                therapeia.Text = rantevou["therapia"].ToString();
                farmaka.Text = rantevou["farmaka"].ToString();
                diarkeia.Text = rantevou["diarkeia_therapeias"].ToString();

            }
            patient_info.Close();
            rantevou.Close();


        }

        private void Savebutt_Click(object sender, EventArgs e)
        {
            

            string path_name;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pdf Files|*.pdf";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path_name = save.FileName;
                PdfMaker.getRantevou(path_name, onomatep.Text, AMKA.Text, asfaleia.Text, "", "", lastv.Text, ma.Text, md.Text, pa.Text, pd.Text, ya.Text, yd.Text, aa.Text, ad.Text, pia.Text, pid.Text, astheneia.Text, therapeia.Text, farmaka.Text, diarkeia.Text, apotelesma.Text);


            }
        }
            private void printbutt_Click(object sender, EventArgs e)
        {
            PdfMaker.getRantevou("print.pdf", onomatep.Text, AMKA.Text, asfaleia.Text, "", "", lastv.Text, ma.Text, md.Text, pa.Text, pd.Text, ya.Text, yd.Text, aa.Text, ad.Text, pia.Text, pid.Text, astheneia.Text, therapeia.Text, farmaka.Text, diarkeia.Text, apotelesma.Text);
            PdfMaker.print("print.pdf");

        }
    }
}
