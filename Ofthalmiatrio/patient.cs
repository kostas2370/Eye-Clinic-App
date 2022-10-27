
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofthalmiatrio
{
    public partial class patient : Form
    {
        public static bool redo = false;
        public static string amk;
        private static SQLiteDataReader rantevou;
        private static string first_rantevou;
        private static string id;
        string SPH_A = "-";
        string SPH_D = "-";
        string CYL_A = "-";
        string CYL_D = "-";
        string AXES_A = "-";
        string AXES_D = "-";
        string ADD_A = "-";
        string ADD_D = "-";


        
        public patient(SQLiteDataReader patient_info)
        {
            
            InitializeComponent();;
            setstyle.setStyle(this);


            patient_info.Read();
            
            if (Form1.userrole == "doctor" )
            {
                edit_but.Visible = false;
                edit_but.Enabled = false;
            }

            AMKA.Text = patient_info["AMKA"].ToString();
            onomatep.Text = patient_info["OnomaTeponimo"].ToString();
            asfaleia.Text = patient_info["Asfaleia"].ToString();
            episkepseis.Text = patient_info["Episkepseis"].ToString();
            eispraxeis.Text = patient_info["Xrhmatiko_Poso"].ToString();
            
            var last_data = DatabaseDev.getLastVisit(patient_info["AMKA"].ToString());
            if (last_data.HasRows)
            {
                
                last_data.Read();
                
                lastv.Text = last_data["hmerominia"].ToString();
                ma.Text = last_data["myopia_aristero"].ToString();
                md.Text = last_data["myopia_dexio"].ToString();
                pa.Text = last_data["presviopia_aristero"].ToString();
                pd.Text = last_data["presviopia_dexio"].ToString();
                ya.Text = last_data["ypermatropia_aristero"].ToString();
                yd.Text = last_data["ypermatropia_dexio"].ToString();
                aa.Text = last_data["astigmatismos_aristero"].ToString();
                ad.Text = last_data["astigmatismos_dexio"].ToString();
                axa.Text = last_data["axonas_aristera"].ToString();
                axd.Text = last_data["axonas_dexia"].ToString();
                pia.Text = last_data["piesh_aristero"].ToString();
                pid.Text = last_data["piesh_dexio"].ToString();
                apotelesma.Text = last_data["Apotelesmata"].ToString();
                astheneia.Text = last_data["asthenia"].ToString();
                therapeia.Text = last_data["therapia"].ToString();
                farmaka.Text = last_data["farmaka"].ToString();
                diarkeia.Text = last_data["diarkeia_therapeias"].ToString();

                id = last_data["id"].ToString();

                 rantevou = DatabaseDev.getVisit(AMKA.Text);
                last_data.Close();
                int x = 0;

         
                
                //SPH_A
                if (Double.Parse(ma.Text)>0)
                {
                    SPH_A= $"-{ma.Text}";
                }else if(Double.Parse(ya.Text) > 0)
                {
                    SPH_A = $"+{ya.Text}";
                }
                else
                {
                    SPH_A ="Plano";
                }

                //SPH_D
                if (Double.Parse(md.Text) > 0)
                {
                    SPH_D = $"-{md.Text}";
                }
                else if (Double.Parse(yd.Text) > 0)
                {
                    SPH_D = $"+{yd.Text}";
                }
                else
                {
                    SPH_D = "Plano";
                }

                //CYL_A
                if (Double.Parse(aa.Text) > 0)
                {
                    CYL_A = $"{SPH_A[0]}{aa.Text}";
                    if (SPH_A[0].ToString()=="P")
                    {
                        CYL_A = $"+{aa.Text}";
                    }
                    
                    AXES_A = axa.Text;
                }
            
                //CYL_D
                if (Double.Parse(ad.Text) > 0)
                {
                    CYL_D = $"{SPH_D[0]}{ad.Text}";
                    if (SPH_D[0].ToString() == "P")
                    {
                        CYL_D = $"+{ad.Text}";
                    }
                    AXES_D = axd.Text;
                }

                //ADD_A
                if (Double.Parse(pa.Text) > 0)
                {
                    ADD_A = $"+{pa.Text}";
                }
                //ADD_D
                if (Double.Parse(pd.Text) > 0)
                {
                    ADD_D = $"+{pd.Text}";
                }

                gyalia_data_grid.Rows.Add("Α.Ο",SPH_A,CYL_A,AXES_A,ADD_A);
                gyalia_data_grid.Rows.Add("Δ.Ο",SPH_D,CYL_D,AXES_D,ADD_D);
            
                
                while (rantevou.Read())
                {
                    if(x== 0)
                    {
                        first_rantevou = rantevou["hmerominia"].ToString();
                        x = 1;
                    }
                    rantevougrid.Rows.Add(

                                          rantevou["id"].ToString(),
                                          rantevou["hmerominia"].ToString(),
                                          rantevou["myopia_aristero"].ToString(),
                                          rantevou["myopia_dexio"].ToString(),
                                          rantevou["presviopia_aristero"].ToString(),
                                          rantevou["presviopia_dexio"].ToString(),
                                          rantevou["ypermatropia_aristero"].ToString(),
                                          rantevou["ypermatropia_dexio"].ToString(),
                                          rantevou["astigmatismos_aristero"].ToString(),
                                          rantevou["astigmatismos_dexio"].ToString(),
                                          rantevou["axonas_aristera"].ToString(),
                                          rantevou["axonas_dexia"].ToString(),
                                          rantevou["piesh_aristero"].ToString(),
                                          rantevou["piesh_dexio"].ToString(),
                                          rantevou["asthenia"].ToString(),
                                          rantevou["therapia"].ToString(),
                                          rantevou["farmaka"].ToString(),
                                          rantevou["diarkeia_therapeias"].ToString(),
                                          rantevou["Apotelesmata"].ToString()



                        ); 
                }
                rantevou.Close();

                



                if (apotelesma.Text != "")
                {
                    apotelesma.ReadOnly = true;
                    saveapotelesma.Hide();
                }

            }
            else
            {
                apotelesma.ReadOnly = true;
                saveapotelesma.Hide();
            }

        }
        

        private void saveapotelesma_Click(object sender, EventArgs e)
        {
            if (apotelesma.Text == "")
            {
                MessageBox.Show("Prepei na grapseis apotelesmata prwta");
            }
            else
            {
                bool b = DatabaseDev.update_apotelesma(id, apotelesma.Text);
                if (b)
                {
                    redo = true;
                    MessageBox.Show("Success");

                   
                    apotelesma.ReadOnly = true;
                    amk = AMKA.Text;
                    this.Close();
                }
               

            }
        }

        private void rantevougrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (rantevougrid.Columns[e.ColumnIndex].Name == "Print" | rantevougrid.Columns[e.ColumnIndex].Name == "Save" | rantevougrid.Columns[e.ColumnIndex].Name == "Delete" | rantevougrid.Columns[e.ColumnIndex].Name == "Edit")
            {
                string ids = rantevougrid.Rows[e.RowIndex].Cells["ids"].Value.ToString();
                var rantevous = DatabaseDev.getVisit(AMKA.Text,ids);
                var patient=DatabaseDev.getAstheneis(AMKA.Text);
               
                
                
                string path_name;

                    if (rantevougrid.Columns[e.ColumnIndex].Name == "Save")
                    {
                        
                        SaveFileDialog save = new SaveFileDialog();
                        save.Filter = "Pdf Files|*.pdf";
                        if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            path_name = save.FileName;
                            try
                            {

                                PdfMaker.getRantevou(path_name,patient, rantevous,mode:"other");
                            }catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }
                        }
                    }
                    else if (rantevougrid.Columns[e.ColumnIndex].Name == "Print")
                    {
                        PdfMaker.getRantevou($"x{id}.pdf",patient,rantevous, mode: "other");
                        PdfMaker.print($"x{id}.pdf");

                    }
                    else if (rantevougrid.Columns[e.ColumnIndex].Name == "Edit")
                    {


                        EditRant form = new EditRant(rantevous);
                        form.ShowDialog();
                        var new_data = DatabaseDev.getVisit(ids);
                        new_data.Read();
                        this.Close();



                    }


                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this visit ?", "Are you sure ?", MessageBoxButtons.YesNo);

                        if(dialogResult == DialogResult.Yes)
                        {
                            rantevougrid.Rows[e.RowIndex].Visible = false;

                        }
                        DatabaseDev.deleteVisit(ids, AMKA.Text);
                       


                    }
                

                }
                    
                }
            
        private void edit_but_Click(object sender, EventArgs e)
        {
            editpatient form = new editpatient(AMKA.Text, onomatep.Text, asfaleia.Text);
            form.ShowDialog();
            this.Close();
        }

        private void save_pdf_Click(object sender, EventArgs e)
        {

            string path_name;
            var patient_info = DatabaseDev.getAstheneis(AMKA.Text);
            var rantevou_info = DatabaseDev.getLastVisit(AMKA.Text);
            SaveFileDialog save = new SaveFileDialog();
            List<string> list = new List<string>();
            list.Add("A.O");
            list.Add(SPH_A);
            list.Add(CYL_A);
            list.Add(AXES_A);
            list.Add(ADD_A);
            list.Add("Δ.O");
            list.Add(SPH_D);
            list.Add(CYL_D);
            list.Add(AXES_D);
            list.Add(ADD_D);

            save.Filter = "Pdf Files|*.pdf";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path_name = save.FileName;
                PdfMaker.getRantevou(path_name,patient_info,rantevou_info,list);


            }



        }

        private void print_butt_Click(object sender, EventArgs e)
        {
            var patient_info = DatabaseDev.getAstheneis(AMKA.Text);
            var rantevou_info = DatabaseDev.getLastVisit(AMKA.Text);
            PdfMaker.getRantevou($"x{id}.pdf",patient_info,rantevou_info);
            PdfMaker.print($"x{id}.pdf");


        }

        private void graphs_Click(object sender, EventArgs e)

        {
            rantevou = DatabaseDev.getVisit(AMKA.Text);
            if (rantevou.StepCount >= 1) { 
            
            
            PlotData x = new PlotData(rantevou,first_rantevou,lastv.Text);
            x.ShowDialog();

            }
            else
            {
                MessageBox.Show("You have 0-1 visits");

            }
        }

        private void rantevougrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string ids = rantevougrid.Rows[e.RowIndex].Cells["ids"].FormattedValue.ToString();
                var asthenhs = DatabaseDev.getAstheneis(AMKA.Text);
                var rantevou = DatabaseDev.getVisit(AMKA.Text, id: ids);
                visitform form = new visitform(asthenhs, rantevou);
                form.ShowDialog();
            }catch (Exception x)
            {

            }

           ;

        }

        private void gyalia_data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
