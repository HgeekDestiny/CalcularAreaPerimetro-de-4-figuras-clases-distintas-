using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P1_POORazor_ÁreaPerimetro_
{
    public class Cuadrado
    {
        private double lado;

        public Cuadrado() { }
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }
        //public double Lado { get => lado; set => lado = value; }
        public double Lado { get; set; }

        public double PerimetroCuadrado()
        {
            return this.lado * 4;
        }
        public double AreaCuadrado()
        {
            return this.lado * this.lado;
        }
    }
}