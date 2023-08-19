using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelsonSabado
{
    class Mensalista : Professor
    {
        double salarioTotalMensalista;
        //PROPRIEDADES
        public double SalarioTotalMensalista
        {
            get { return salarioTotalMensalista; }
        }
        //MÉTODOS
        public void CalcularSalarioMensalista()
        {
            salarioTotalMensalista = salarioBase + horaAtividade;
        }

    }
}
