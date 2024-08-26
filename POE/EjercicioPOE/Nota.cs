using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOE
{
    public class Nota
    {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public double CalcularNotas (double nota1, double nota2, double nota3, double nota4)
        {
            double totalNota = (nota1 + nota2 + nota3 + nota4) / 4;
            return totalNota;

        }

    }
}
