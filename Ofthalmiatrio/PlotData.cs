using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Axes;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Ofthalmiatrio
{
    public partial class PlotData : Form
    {
        public PlotData(SQLiteDataReader rantevou, string first_rantevou, string last_rantevou)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox=false;

            //Creating the plot models

            var MyopiaModel = new PlotModel { Title = "Μυωπία" };
            var PresviopiaModel = new PlotModel { Title = "Πρεσβυωπία" };
            var YpermetropiaModel = new PlotModel { Title = "Yπερμετρωπία" };
            var AstigmatismosModel = new PlotModel { Title = "Aστιγματισμός" };
            var PieshModel = new PlotModel { Title = "Πίεση Ματιών" };



            //making the lines


            var line_myopia_aristera = new OxyPlot.Series.LineSeries()
            {
                Title = $"Myopia_aristera",
                Color = OxyPlot.OxyColors.Blue,
                StrokeThickness = 3,
            };
            var line_myopia_dexia = new OxyPlot.Series.LineSeries()
            {
                Title = $"Myopia_aristera",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 3,
            };
            var line_presviopia_aristera = new OxyPlot.Series.LineSeries()
            {
                Title = $"Presviopia_aristera",
                Color = OxyPlot.OxyColors.Blue,
                StrokeThickness = 3,
            };
            var line_presviopia_dexia = new OxyPlot.Series.LineSeries()
            {
                Title = $"Presviopia_dexia",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 3,
            };
            var line_ypermetropia_aristera = new OxyPlot.Series.LineSeries()
            {
                Title = $"ypermetropia_aristera",
                Color = OxyPlot.OxyColors.Blue,
                StrokeThickness = 3,
            };
            var line_ypermetropia_dexia = new OxyPlot.Series.LineSeries()
            {
                Title = $"ypermetropia_dexia",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 3,
            };
            var line_astigmatismos_aristera = new OxyPlot.Series.LineSeries()
            {
                Title = $"astigmatismos_aristera",
                Color = OxyPlot.OxyColors.Blue,
                StrokeThickness = 3,
            };
            var line_astigmatismos_dexia = new OxyPlot.Series.LineSeries()
            {
                Title = $"astigmatismos_dexia",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 3,
            };
            var line_piesh_aristera = new OxyPlot.Series.LineSeries()
            {
                Title = $"piesh_aristera",
                Color = OxyPlot.OxyColors.Blue,
                StrokeThickness = 3,

            };
            var line_piesh_dexia = new OxyPlot.Series.LineSeries()
            {
                Title = $"piesh_dexia",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 3,

            };


            //getting the min and max dates for axis

            var mindate = DateTime.Parse(first_rantevou);
            var maxdate = DateTime.Parse(last_rantevou);
            var minValue = DateTimeAxis.ToDouble(mindate);
            var maxValue = DateTimeAxis.ToDouble(maxdate);

            //adding the axes to the models

            MyopiaModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "MM/dd/yyyy" });
            PresviopiaModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "MM/dd/yyyy" });
            YpermetropiaModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "MM/dd/yyyy" });
            AstigmatismosModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "MM/dd/yyyy" });
            PieshModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "MM/dd/yyyy" });
          
            //adding the points to the models
            while (rantevou.Read())
            {

                var date = DateTime.Parse(rantevou["hmerominia"].ToString());


                line_myopia_aristera.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["myopia_aristero"].ToString())));
                line_myopia_dexia.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["myopia_dexio"].ToString())));
                line_presviopia_aristera.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["presviopia_aristero"].ToString())));
                line_presviopia_dexia.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["presviopia_dexio"].ToString())));
                line_ypermetropia_aristera.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["ypermatropia_aristero"].ToString())));
                line_ypermetropia_dexia.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["ypermatropia_dexio"].ToString())));
                line_astigmatismos_aristera.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["astigmatismos_aristero"].ToString())));
                line_astigmatismos_dexia.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["astigmatismos_dexio"].ToString())));
                line_piesh_aristera.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["piesh_aristero"].ToString())));
                line_piesh_dexia.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), Double.Parse(rantevou["piesh_dexio"].ToString())));
            }


            //adding the lines to the models

            MyopiaModel.Series.Add(line_myopia_aristera);
            MyopiaModel.Series.Add(line_myopia_dexia);
            PresviopiaModel.Series.Add(line_presviopia_aristera);
            PresviopiaModel.Series.Add(line_presviopia_dexia);
            YpermetropiaModel.Series.Add(line_ypermetropia_aristera);
            YpermetropiaModel.Series.Add(line_ypermetropia_dexia);
            AstigmatismosModel.Series.Add(line_astigmatismos_aristera);
            AstigmatismosModel.Series.Add(line_astigmatismos_dexia);
            PieshModel.Series.Add(line_piesh_aristera);
            PieshModel.Series.Add(line_piesh_dexia);

            //setting our model to the views

            this.myopia.Model = MyopiaModel;
            this.presviopia.Model = PresviopiaModel;
            this.ypermetropia.Model = YpermetropiaModel;
            this.astigmatismos.Model =AstigmatismosModel;
            this.piesh.Model =PieshModel;
        }



      
    }
}
