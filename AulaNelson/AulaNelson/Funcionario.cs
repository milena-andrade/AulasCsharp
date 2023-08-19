using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace AulaNelson
{
    public class Funcionario : ContaBanco
    {
       
            public string matricula;
            public string nome;
            public string cargo;
            public double salario;
            public ContaBanco conta;
           

        public void aumentarSalario(double salario)
        {

            double taxa = 0.1;
            this.salario = ((taxa * salario) + salario);

        }

        public void aumentarSalario(float porcento)
        {

            double taxa = porcento;

           this.salario = ((taxa * salario) + salario);
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salário: {salario}");
        }
        public void AtualizaSalario(double valor)
        {
            this.salario = conta.saldo;
        }

        public void AlteraNome(string Novonome)
        {
            this.nome = Novonome;
        }
        public void AlteraSalario(double Novosalario)
        {
            this.salario = Novosalario;
        }
    }




}
