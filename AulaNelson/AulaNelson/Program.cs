using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaNelson
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Turma turma = new Turma();

            /*aluno1.turmAtributo = turma;
            aluno1.turmAtributo.periodo = "5";
            aluno1.nome = "Milena";
            aluno1.rg = "555";
            aluno1.datanas = "16052001";


            /*Console.WriteLine(aluno1.turmAtributo.periodo);
            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.rg);*/

            /*Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Bianca";
            funcionario1.salario = 100;
            funcionario1.aumentarSalario(funcionario1.salario);
            funcionario1.cargo = "desenvolvedora";
            funcionario1.matricula = "555";



            funcionario1.MostrarAtributos();*/

            ContaBanco conta = new ContaBanco();

            Layout telas = new Layout();
            telas.Login();



            Console.ReadKey();
        }
    }
}
