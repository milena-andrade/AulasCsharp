using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bianca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe // variavel // = // new // Classe(); OBJETOOOO
            Turma objetoturma = new Turma();

            //atribuir um valor dentro de turma?
            // variavel.atributo = valor;

            objetoturma.periodo = "primeiro";
            Console.WriteLine(objetoturma.periodo);

            Aluno objetoAluno = new Aluno();
            objetoAluno.matricula = "1234";
            objetoAluno.nome = "Bianca";

            Console.WriteLine(objetoAluno.matricula);
            Console.WriteLine(objetoAluno.nome);

            objetoAluno.turma = objetoturma;
            objetoAluno.turma.periodo = "segundo";

            Console.WriteLine(objetoAluno.turma.periodo);

            objetoAluno.mostrarAluno("Milena", "555"); //métodos
            objetoAluno.mostrarTurma("manhã");
            Console.ReadKey();

        }
    }
}
