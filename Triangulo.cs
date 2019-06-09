using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P1_POORazor_ÁreaPerimetro_
{
    public class Triangulo
    {
        private double b, a, c, h;
        public Triangulo() { }
        public Triangulo(double b,  double a, double c, double h)
        {
            this.b = b;
            this.a = a;
            this.c = c;
            this.h = h;
        }

        public double triangulo { get; set; }
        
        public double PerimetroTriangulo()
        {
            return b + a + c;
        }
        public double AreaTriangulo()
        {
            return (b * h)/2;
        }
    }
}