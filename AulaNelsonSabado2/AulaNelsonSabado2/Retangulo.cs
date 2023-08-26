using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelsonSabado2
{
    public class Retangulo : Forma
    {
        private double altura_retangulo;
        private double base_retangulo;


        public double AlturaRetangulo
        {
            get { return altura_retangulo; }
            set { altura_retangulo = value; }
        }


        public double BaseRetangulo
        {
            get { return base_retangulo; }
            set { base_retangulo = value; }
        }

        public override void CalcularArea()
        {
            this.Area = (base_retangulo * altura_retangulo);
        }
        public override void CalcularPerimetro()
        {
            this.Perimetro = ((2*base_retangulo) + (2*altura_retangulo)) ;
        }



    }
}
