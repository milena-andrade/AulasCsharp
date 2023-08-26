using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelsonSabado2
{
    public class Triangulo : Forma
    {
        private double altura;
        private double base_triangulo;
        private double ladoc;

        public double Altura
        {
            get { return altura; }
            set { altura = value;  }
        }

        public double Base
        {
            get { return base_triangulo; }
            set { base_triangulo = value; }
        }

        public double Ladoc
        {
            get { return ladoc; }
            set { ladoc = value; }
        }

        public override void CalcularArea()
        {
            this.Area = (base_triangulo * altura)/2;
        }
        public override void CalcularPerimetro()
        {
            this.Perimetro = base_triangulo + altura  + ladoc;
        }






    }
}
