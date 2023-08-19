using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelsonSabado
{
    class Professor
    {
        //atributos
        protected string nome;
        protected string matricula;
        protected double salarioBase;
        protected double horaAtividade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public double HoraAtividade
        {
            get { return horaAtividade; }
        }
        public double SalarioBase
        {
            get { return salarioBase; }
        }

        public void CalcularHoraAtividade(double salarioProfessor)
        {
            salarioBase = salarioProfessor;
            horaAtividade = salarioBase * 0.05;
        }

    }
}
