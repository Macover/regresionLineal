using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regresion_Lineal
{
    class RegresionLineal
    {
        private double m;
        private double b;
        private int n;
        private double[] x;
        private double[] y;

        public RegresionLineal(double[] x, double[] y, int n)
        {
            this.x = x;
            this.y = y;
            this.n = n;
        }

        public double getM()
        {
            this.m = ((this.n * this.getSumatoriaXY()) - (this.getSumatoriaX() * this.getSumatoriaY())) / (this.n * this.getSumatoriaX2() - Math.Pow(this.getSumatoriaX(), 2));
            return m;
        }
        public double getB() 
        {
            this.b = (this.getSumatoriaY() - (this.getM() * this.getSumatoriaX()) / this.n);
            return b;
        }

        public double productoXY(double x, double y)
        {
            double resultado = x * y;
            return resultado;
        }
        public double getSumatoriaXY()
        {
            double sumatoria = 0;
            for (int i = 0; i < this.n; i++)
            {
                sumatoria += this.productoXY(x[i], y[i]);
            }
            return sumatoria;
        }
        public double getSumatoriaX()
        {
            double sumatoria = 0;
            for (int i = 0; i < this.n; i++)
            {
                sumatoria += x[i];
            }
            return sumatoria;
        }
        public double getSumatoriaY()
        {
            double sumatoria = 0;
            for (int i = 0; i < this.n; i++)
            {
                sumatoria += y[i];
            }
            return sumatoria;
        }
        public double getSumatoriaX2()
        {
            double sumatoria = 0;
            for (int i = 0; i < this.n; i++)
            {
                sumatoria += Math.Pow(x[i],2);
            }
            return sumatoria;
        }

    }
}
