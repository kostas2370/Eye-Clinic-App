using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
        public static void getRantevou(string path_name,string onomateponymo,string amka,string asfaleia,string synolo_episkepsewn,string synolikes_eispraxeis,string visit_date,string mia,string mid,string pa,string pd,string ya,string yd,string aa,string ad,string pia,string pid,string asthenia,string therapeia,string farmaka,string diarkeia,string apotelesma)
        {
             
            
            // creating a doc 
            Document doc = new Document();
            // The font we will use in our pdf
            var font = FontRepository.FindFont("Arial");
           
            // Creating text states
            Aspose.Pdf.Text.TextState stoixeiats = new Aspose.Pdf.Text.TextState();
            Aspose.Pdf.Text.TextState generalts = new Aspose.Pdf.Text.TextState();
            Aspose.Pdf.Text.TextState textts = new Aspose.Pdf.Text.TextState();

            // Adding header
            Aspose.Pdf.Text.TextFragment fragment = new Aspose.Pdf.Text.TextFragment();
            Aspose.Pdf.Text.TextSegment inro = new Aspose.Pdf.Text.TextSegment("Στοιχεία Ασθενούς :                                     Eye Clinic\n                                                                       ΔΙΠΑΕ");
            Aspose.Pdf.Text.TextSegment stoixeia;
         
            if (synolikes_eispraxeis == "")
            {
                 stoixeia = new Aspose.Pdf.Text.TextSegment($"\nΟνοματεπώνυμο : {onomateponymo} \nAMKA : {amka}\nΑσφαλεια : {asfaleia}\nΗμερομηνία Ραντεβού : {visit_date}");


            }
            else
            {
                stoixeia = new Aspose.Pdf.Text.TextSegment($"\nΟνοματεπώνυμο : {onomateponymo} \nAMKA : {amka}\nΑσφαλεια : {asfaleia}\nΣύνολο Επισκέψεων : {synolo_episkepsewn}\nΣυνολικές εισπράξεις : {synolikes_eispraxeis}€\nΗμερομηνία Ραντεβού : {visit_date}");


            }
            Aspose.Pdf.Text.TextSegment Rantevou_Apotelesmata = new Aspose.Pdf.Text.TextSegment("\n\n\nΜετρήσεις :\n");



            // Styling the fonts
            stoixeiats.Font = font;
            stoixeiats.Font.IsEmbedded = true;
            stoixeiats.FontSize =15;
            stoixeiats.FontStyle = FontStyles.Bold;

            generalts.FontSize = 17;
            generalts.Font = font;
            generalts.Font.IsEmbedded = true;
            generalts.FontStyle = FontStyles.Italic;

            textts.FontSize = 11;
            textts.Font = font;
            textts.Font.IsEmbedded = true;
            
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
            row.Cells.Add($" {mia}");
            row.Cells.Add("Mυωπία Δεξιό Μάτι");
            row.Cells.Add($" {mid}");


            Aspose.Pdf.Row row2 = data.Rows.Add();
            row2.Cells.Add("Πρεσβυωπία Αριστερό Μάτι");
            row2.Cells.Add($" {pa}");
            row2.Cells.Add("Πρεσβυωπία Δεξιό Μάτι");
            row2.Cells.Add($" {pd}");

            Aspose.Pdf.Row row3 = data.Rows.Add();
            row3.Cells.Add("Υπερματρώπια Αριστερό Μάτι");
            row3.Cells.Add($" {ya}");
          
            row3.Cells.Add("Υπερματρώπια Δεξιό Μάτι");
            row3.Cells.Add($" {yd}");


            Aspose.Pdf.Row row4 = data.Rows.Add();
            row4.Cells.Add("Aστιγματισμός Αριστερό Μάτι");
            row4.Cells.Add($" {aa}");
            row4.Cells.Add("Aστιγματισμός Δεξιό Μάτι");
            row4.Cells.Add($" {ad}");

            Aspose.Pdf.Row row5 = data.Rows.Add();
            row5.Cells.Add("Πίεση Αριστερόυ Μάτιού");
            row5.Cells.Add($" {pia}");
            row5.Cells.Add("Πίεση Δεξιού Μάτιου");
            row5.Cells.Add($" {pid}");

            page.Paragraphs.Add(fragment);
            page.Paragraphs.Add(data);

            //adding the other parts of the pdf
            Aspose.Pdf.Text.TextFragment fragment2 = new Aspose.Pdf.Text.TextFragment();
            Aspose.Pdf.Text.TextSegment asth= new Aspose.Pdf.Text.TextSegment("\n\nAσθένεια : ");
            asth.TextState = generalts;
            Aspose.Pdf.Text.TextSegment asthen = new Aspose.Pdf.Text.TextSegment($"{asthenia}");
            asthen.TextState = textts;
            Aspose.Pdf.Text.TextSegment ther = new Aspose.Pdf.Text.TextSegment("\n\nΘεραπεία : ");
            ther.TextState = generalts;
            Aspose.Pdf.Text.TextSegment therap = new Aspose.Pdf.Text.TextSegment($"{therapeia}");
            therap.TextState = textts;
            Aspose.Pdf.Text.TextSegment farm = new Aspose.Pdf.Text.TextSegment("\n\nΦαρμακευτική Αγωγή : \n\n");
            farm.TextState = generalts;
            Aspose.Pdf.Text.TextSegment farmak = new Aspose.Pdf.Text.TextSegment($"{farmaka}");
            farmak.TextState = textts;
            Aspose.Pdf.Text.TextSegment diark = new Aspose.Pdf.Text.TextSegment("\n\nΔιάρκεια Θεραπείας : ");
            diark.TextState = generalts;
            Aspose.Pdf.Text.TextSegment diarkia = new Aspose.Pdf.Text.TextSegment($"{diarkeia}");
            diarkia.TextState = textts;
            Aspose.Pdf.Text.TextSegment apot = new Aspose.Pdf.Text.TextSegment("\n\nAποτέλεσμα Θεραπείας : \n\n");
            apot.TextState = generalts;
            Aspose.Pdf.Text.TextSegment apotelesm = new Aspose.Pdf.Text.TextSegment($"{apotelesma}");
            apotelesm.TextState = textts;


            //adding the segments into the page

            fragment2.Segments.Add(asth);
            fragment2.Segments.Add(asthen);
            fragment2.Segments.Add(ther);
            fragment2.Segments.Add(therap);
            fragment2.Segments.Add(farm);
            fragment2.Segments.Add(farmak);
            fragment2.Segments.Add(diark);
            fragment2.Segments.Add(diarkia);
            fragment2.Segments.Add(apot);
            fragment2.Segments.Add(apotelesm);

            page.Paragraphs.Add(fragment2);

            

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
        public static void getMedicine(string path_name,string id,string onoma,string typos,string syptomata,string promitheftes)
        {

            // creating a doc 
            Document doc = new Document();
            // The font we will use in our pdf
            var font = FontRepository.FindFont("Arial");
            // Adding header
            Aspose.Pdf.Text.TextFragment fragment = new Aspose.Pdf.Text.TextFragment();
            Aspose.Pdf.Text.TextSegment inro = new Aspose.Pdf.Text.TextSegment("Στοιχεία Φαρμακου :                                     Eye Clinic\n                                                                       ΔΙΠΑΕ");
            Aspose.Pdf.Text.TextSegment stoixeia;

            //creating text states
            Aspose.Pdf.Text.TextState stoixeiats = new Aspose.Pdf.Text.TextState();
            Aspose.Pdf.Text.TextState generalts = new Aspose.Pdf.Text.TextState();
            Aspose.Pdf.Text.TextState textts = new Aspose.Pdf.Text.TextState();

            // creating the page

            Page page = doc.Pages.Add();



            //styling text states

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

            stoixeia = new Aspose.Pdf.Text.TextSegment($"\nID : {id} \nΟνομα Φάρμακου : {onoma}\nΤύπος : {typos}\n\n\n" );

            stoixeia.TextState = stoixeiats;

            inro.TextState = generalts;


            Aspose.Pdf.Text.TextSegment symptomata_label = new Aspose.Pdf.Text.TextSegment("Συμπτώματα : \n\n");
            symptomata_label.TextState = stoixeiats;
            Aspose.Pdf.Text.TextSegment syptomata_text = new Aspose.Pdf.Text.TextSegment(syptomata);
            syptomata_text.TextState = textts;
            Aspose.Pdf.Text.TextSegment promitheftes_label = new Aspose.Pdf.Text.TextSegment("\n\nΠρομηθευτές : \n\n");
            promitheftes_label.TextState=stoixeiats;
            Aspose.Pdf.Text.TextSegment promitheftes_text=new Aspose.Pdf.Text.TextSegment(promitheftes);
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
