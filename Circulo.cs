using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P1_POORazor_ÁreaPerimetro_
{
    public class Circulo
    {
        private double r;

        public Circulo() { }
        public Circulo(double r)
        {
            this.r = r;
        }
        public double Radio { get; set; }

        public double PerimetroCirculo()
        {
            return 2 * 3.1416 * r;
        }
        public double AreaCirculo()
        {
            return 3.1416 * (r*r);
        }
    }
}