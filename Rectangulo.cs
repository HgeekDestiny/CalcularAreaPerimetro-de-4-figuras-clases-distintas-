using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P1_POORazor_ÁreaPerimetro_
{
    public class Rectangulo
    {
        private double b,h;

        public Rectangulo() { }
        public Rectangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public double Recta { get; set; }

        public double PerimetroRectangulo()
        {
            return b + b+ + h + h;
        }
        public double AreaRectangulo()
        {
            return b * h;
        }
    }
}