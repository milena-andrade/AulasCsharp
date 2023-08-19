using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelsonSabado
{
    class Aulista : Professor
    {
        private double salarioProfessorAulista;
        private double salarioTotalAulista;
        private double dsr;
        //PROPRIEDADES
        public double SalarioProfessorAulista
        {
            get { return salarioProfessorAulista; }
        }
        public double DSR
        {
            get { return dsr; }
        }
        public double SalarioTotalAulista
        {
            get { return salarioTotalAulista; }
        }
        //MÉTODOS
        public void CalcularSalarioBaseAulista(int numeroAulas, double valorAulas)
        {
            salarioProfessorAulista = numeroAulas * valorAulas * 4.5;
        }
        public void CalcularDSR()
        {
            dsr = (salarioBase + horaAtividade) / 6;
        }
        public void CalcularSalarioAulista()
        {
            salarioTotalAulista = (salarioBase + horaAtividade + dsr);
        }
    }
}
