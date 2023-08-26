using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelsonSabado2
{
    public abstract class Forma
    {
        private double area;
        private string cor;
        private double perimetro;
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                cor = value;
            }
        }
        public double Area
        {
            get
            { return area; }
            set
            { area = value; }
        }
        public double Perimetro
        {
            get
            { return perimetro; }
            set
            { perimetro = value; }
        }
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public string Descricao()
        {
            return "Classe Abstrata Forma";
        }
    }
}
