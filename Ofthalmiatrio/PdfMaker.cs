using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofthalmiatrio
{
    internal class PdfMaker
    {
         static Aspose.Pdf.Text.TextState stoixeiats ;
         static Aspose.Pdf.Text.TextState generalts ;
         static Aspose.Pdf.Text.TextState textts ;
       static PdfMaker()
        {

            var font = FontRepository.FindFont("Arial");
            stoixeiats = new Aspose.Pdf.Text.TextState();
            generalts = new Aspose.Pdf.Text.TextState();
            textts = new Aspose.Pdf.Text.TextState();



            stoixeiats.Font = font;
            stoixeiats.Font.IsEmbedded = true;
            stoixeiats.FontSize = 15;
            stoixeiats.FontStyle = FontStyles.Bold;

            generalts.FontSize = 17;
            generalts.Font = font;
            generalts.Font.IsEmbedded = true;
            generalts.FontStyle = FontStyles.Italic;

            textts.FontSize = 11;
            textts.Font = font;
            textts.Font.IsEmbedded = true;
        }
        public static void getRantevou(string path_name, SQLiteDataReader patient_info, SQLiteDataReader rantevou_info,List<string> gyalia=null,string mode="full")
        {

            //Getting information

            patient_info.Read();
            rantevou_info.Read();
            // creating a doc 
           
            Document doc = new Document();


            // Adding header
            Aspose.Pdf.Text.TextFragment fragment = new Aspose.Pdf.Text.TextFragment();
            Aspose.Pdf.Text.TextSegment inro = new Aspose.Pdf.Text.TextSegment("Στοιχεία Ασθενούς :                                     Eye Clinic\n                                                                       ΔΙΠΑΕ");
            Aspose.Pdf.Text.TextSegment stoixeia;
         
            if (mode != "full")
            {
                 stoixeia = new Aspose.Pdf.Text.TextSegment($"\nΟνοματεπώνυμο : {patient_info["OnomaTeponimo"].ToString()} \nAMKA : {patient_info["AMKA"].ToString()}\nΑσφαλεια : {patient_info["Asfaleia"].ToString()}\nKοστος : {rantevou_info["kostos"].ToString()}€\nΗμερομηνία Ραντεβού : {rantevou_info["hmerominia"].ToString()}");


            }
            else
            {
                stoixeia = new Aspose.Pdf.Text.TextSegment($"\nΟνοματεπώνυμο : {patient_info["OnomaTeponimo"].ToString()} \nAMKA : {patient_info["AMKA"].ToString()}\nΑσφαλεια : {patient_info["Asfaleia"].ToString()}\nΣύνολο Επισκέψεων : {patient_info["Episkepseis"].ToString()}\nΣυνολικές εισπράξεις : {patient_info["Xrhmatiko_Poso"].ToString()}€\nΗμερομηνία Ραντεβού : {rantevou_info["hmerominia"].ToString()}");


            }
            Aspose.Pdf.Text.TextSegment Rantevou_Apotelesmata = new Aspose.Pdf.Text.TextSegment("\n\n\nΜετρήσεις :\n");



  
            
            //creating the pages
            Page page = doc.Pages.Add();
            stoixeia.TextState = stoixeiats;
            inro.TextState = generalts;
            Rantevou_Apotelesmata.TextState = generalts;
            fragment.Segments.Add(inro);
            fragment.Segments.Add(stoixeia);
            fragment.Segments.Add(Rantevou_Apotelesmata);
            Aspose.Pdf.Table data = new Aspose.Pdf.Table();
            data.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black));
            data.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 1f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black));
            
            
            //adding the rows

            data.DefaultCellTextState = textts;
            Aspose.Pdf.Row row = data.Rows.Add();
            row.Cells.Add("Mυωπία Αριστερό Μάτι");
            row.Cells.Add($" {rantevou_info["myopia_aristero"].ToString()}");
            row.Cells.Add("Mυωπία Δεξιό Μάτι");
            row.Cells.Add($" {rantevou_info["myopia_dexio"].ToString()}");


            Aspose.Pdf.Row row2 = data.Rows.Add();
            row2.Cells.Add("Πρεσβυωπία Αριστερό Μάτι");
            row2.Cells.Add($" {rantevou_info["presviopia_aristero"].ToString()}");
            row2.Cells.Add("Πρεσβυωπία Δεξιό Μάτι");
            row2.Cells.Add($" {rantevou_info["presviopia_dexio"].ToString()}");

            Aspose.Pdf.Row row3 = data.Rows.Add();
            row3.Cells.Add("Υπερματρώπια Αριστερό Μάτι");
            row3.Cells.Add($" {rantevou_info["ypermatropia_aristero"].ToString()}");
          
            row3.Cells.Add("Υπερματρώπια Δεξιό Μάτι");
            row3.Cells.Add($" {rantevou_info["ypermatropia_dexio"].ToString()}");

         

            Aspose.Pdf.Row row4 = data.Rows.Add();
            row4.Cells.Add("Aστιγματισμός Αριστερό Μάτι");
            row4.Cells.Add($" {rantevou_info["astigmatismos_aristero"].ToString()}");
            row4.Cells.Add("Aστιγματισμός Δεξιό Μάτι");
            row4.Cells.Add($" {rantevou_info["astigmatismos_dexio"].ToString()}");

            Aspose.Pdf.Row row5 = data.Rows.Add();
            row5.Cells.Add("Πίεση Αριστερόυ Μάτιού");
            row5.Cells.Add($" {rantevou_info["piesh_aristero"].ToString()}");
            row5.Cells.Add("Πίεση Δεξιού Μάτιου");
            row5.Cells.Add($" {rantevou_info["piesh_dexio"].ToString()}");

            page.Paragraphs.Add(fragment);
            page.Paragraphs.Add(data);

            //adding the other parts of the pdf
            Aspose.Pdf.Text.TextFragment fragment2 = new Aspose.Pdf.Text.TextFragment();
            Aspose.Pdf.Text.TextSegment asth= new Aspose.Pdf.Text.TextSegment("\n\nAσθένεια : ");
            asth.TextState = generalts;
            Aspose.Pdf.Text.TextSegment asthen = new Aspose.Pdf.Text.TextSegment($"{rantevou_info["asthenia"].ToString()}");
            asthen.TextState = textts;
            Aspose.Pdf.Text.TextSegment ther = new Aspose.Pdf.Text.TextSegment("\n\nΘεραπεία : ");
            ther.TextState = generalts;
            Aspose.Pdf.Text.TextSegment therap = new Aspose.Pdf.Text.TextSegment($"{rantevou_info["therapia"].ToString()}");
            therap.TextState = textts;
            Aspose.Pdf.Text.TextSegment farm = new Aspose.Pdf.Text.TextSegment("\n\nΦαρμακευτική Αγωγή : \n\n");
            farm.TextState = generalts;
            Aspose.Pdf.Text.TextSegment farmak = new Aspose.Pdf.Text.TextSegment($"{rantevou_info["farmaka"].ToString()}");
            farmak.TextState = textts;
            Aspose.Pdf.Text.TextSegment diark = new Aspose.Pdf.Text.TextSegment($"\n\nΔιάρκεια Θεραπείας : {rantevou_info["diarkeia_therapeias"].ToString()}");
            diark.TextState = generalts;
           
            Aspose.Pdf.Text.TextSegment apot = new Aspose.Pdf.Text.TextSegment("\n\nAποτέλεσμα Θεραπείας : \n\n");
            apot.TextState = generalts;
            Aspose.Pdf.Text.TextSegment apotelesm = new Aspose.Pdf.Text.TextSegment($"{rantevou_info["Apotelesmata"].ToString()}");
            apotelesm.TextState = textts;
            fragment2.Segments.Add(asth);
            fragment2.Segments.Add(asthen);
            fragment2.Segments.Add(ther);
            fragment2.Segments.Add(therap);
            fragment2.Segments.Add(farm);
            fragment2.Segments.Add(farmak);
            fragment2.Segments.Add(diark);
            
            
            
            fragment2.Segments.Add(apot);
            fragment2.Segments.Add(apotelesm);


            page.Paragraphs.Add(fragment2);


            if (!(gyalia is null))
            {

                Aspose.Pdf.Text.TextSegment gιalia = new Aspose.Pdf.Text.TextSegment("\n\nΓυαλιά : \n\n");
                gιalia.TextState = generalts;
                Aspose.Pdf.Table glass_table = new Aspose.Pdf.Table();
                glass_table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black));
                glass_table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All,.5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black));
                glass_table.DefaultCellTextState = textts;
                Aspose.Pdf.Row row_head = glass_table.Rows.Add();
                row_head.Cells.Add("  MATI");
                row_head.Cells.Add("  Sphere");
                row_head.Cells.Add("  CYL");
                row_head.Cells.Add("  AXIS");
                row_head.Cells.Add("  ADD");


                Aspose.Pdf.Row row_aristera = glass_table.Rows.Add();
                row_aristera.Cells.Add($"  {gyalia[0]} ");
                row_aristera.Cells.Add($"  {gyalia[1]} ");
                row_aristera.Cells.Add($"  {gyalia[2]} ");
                row_aristera.Cells.Add($"  {gyalia[3]} ");
                row_aristera.Cells.Add($"  {gyalia[4]} ");
                Aspose.Pdf.Row row_dexia = glass_table.Rows.Add();
                row_dexia.Cells.Add($"  {gyalia[5]} ");
                row_dexia.Cells.Add($"  {gyalia[6]} ");
                row_dexia.Cells.Add($"  {gyalia[7]} ");
                row_dexia.Cells.Add($"  {gyalia[8]} ");
                row_dexia.Cells.Add($"  {gyalia[9]} ");

                glass_table.ColumnWidths = "70 2cm";
                glass_table.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;

                fragment2.Segments.Add(gιalia);

                page.Paragraphs.Add(glass_table);
            }
            //adding the segments into the page
          




            doc.Save(path_name);

           
        }


        //printing the pdf
        public static bool print(string name)
        {

            // creating the viewer and adding the settings
            PdfViewer viewer = new PdfViewer();
            viewer.BindPdf(System.IO.Path.Combine(name));
            viewer.AutoResize = true;         
            viewer.AutoRotate = true;         
            viewer.PrintPageDialog = false;

            System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
            System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PrintDocument prtdoc = new System.Drawing.Printing.PrintDocument();
            ps.PrinterName = prtdoc.PrinterSettings.PrinterName;
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();

            if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                viewer.PrintDocumentWithSettings(pgs, ps);
                return true;
            }

            return false;
        }
        public static void getMedicine(string path_name, SQLiteDataReader medicine_info)
        {
            medicine_info.Read();
   

            // creating a doc 
            Document doc = new Document();
            // The font we will use in our pdf
            var font = FontRepository.FindFont("Arial");
            // Adding header
            Aspose.Pdf.Text.TextFragment fragment = new Aspose.Pdf.Text.TextFragment();
            Aspose.Pdf.Text.TextSegment inro = new Aspose.Pdf.Text.TextSegment("Στοιχεία Φαρμακου :                                     Eye Clinic\n                                                                       ΔΙΠΑΕ");
            Aspose.Pdf.Text.TextSegment stoixeia;



            // creating the page

            Page page = doc.Pages.Add();



            stoixeia = new Aspose.Pdf.Text.TextSegment($"\nID : {medicine_info["id"].ToString()} \nΟνομα Φάρμακου : {medicine_info["onoma"].ToString()}\nΤύπος : {medicine_info["typos"].ToString()}\n\n\n" );

            stoixeia.TextState = stoixeiats;

            inro.TextState = generalts;


            Aspose.Pdf.Text.TextSegment symptomata_label = new Aspose.Pdf.Text.TextSegment("Συμπτώματα : \n\n");
            symptomata_label.TextState = stoixeiats;
            Aspose.Pdf.Text.TextSegment syptomata_text = new Aspose.Pdf.Text.TextSegment(medicine_info["symptomata"].ToString());
            syptomata_text.TextState = textts;
            Aspose.Pdf.Text.TextSegment promitheftes_label = new Aspose.Pdf.Text.TextSegment("\n\nΠρομηθευτές : \n\n");
            promitheftes_label.TextState=stoixeiats;
            Aspose.Pdf.Text.TextSegment promitheftes_text=new Aspose.Pdf.Text.TextSegment(medicine_info["promitheftes"].ToString());
            promitheftes_text.TextState = textts;


            fragment.Segments.Add(inro);
            fragment.Segments.Add(stoixeia);
            fragment.Segments.Add(symptomata_label);
            fragment.Segments.Add(syptomata_text);
            fragment.Segments.Add(promitheftes_label);
            fragment.Segments.Add(promitheftes_text);

            page.Paragraphs.Add(fragment);

            doc.Save(path_name);
            

        }





    }
}
