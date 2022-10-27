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
    public partial class MedicineView : Form
    {
        public MedicineView(string id)
        {
            InitializeComponent();
            var data = DatabaseDev.getMedicine(id);
            setstyle.setStyle(this);

            data.Read();
            {
                ids.Text = data["id"].ToString();
                onoma.Text = data["onoma"].ToString();
                typos.Text = data["typos"].ToString() ;
                symptomata.Text = data["symptomata"].ToString();
                promitheftes.Text = data["promitheftes"].ToString();



            }

        }

        private void Savebutt_Click(object sender, EventArgs e)
        {
            string path_name;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pdf Files|*.pdf";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path_name = save.FileName;
              
                PdfMaker.getMedicine(path_name, ids.Text, onoma.Text, typos.Text,symptomata.Text, promitheftes.Text);
                
            }
        }

        private void printbutt_Click(object sender, EventArgs e)
        {
            PdfMaker.getMedicine("print.pdf", ids.Text, onoma.Text, typos.Text, symptomata.Text, promitheftes.Text);
            PdfMaker.print("print.pdf");
        }
    }
}
