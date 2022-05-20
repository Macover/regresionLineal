using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regresion_Lineal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double []x = { 7, 1, 10, 5, 4, 3, 13, 10, 2 };
            double [] y = { 2,9,2,2,5,7,11,2,5,14 };
            RegresionLineal regresion = new RegresionLineal(x, y, x.Length);

            //graficar los valores iniciales.

            grafica.Series[0].Name = "Valores iniciales";

            for (int i = 0; i < x.Length; i++)
            {
                grafica.Series[0].Points.AddY(y[i]);
            }

            System.Windows.Forms.DataVisualization.Charting.Series valores = new System.Windows.Forms.DataVisualization.Charting.Series();
            valores.Name = "Valores regresion";
            valores.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            double pendiente = regresion.getM();
            double interseccion = regresion.getB();

            for (int i = 0; i < x.Length; i++)
            {
                double Y = (pendiente * x[i]) + interseccion;
                valores.Points.Add(Y);
            }

            grafica.Series.Add(valores);

        }
    }
}
