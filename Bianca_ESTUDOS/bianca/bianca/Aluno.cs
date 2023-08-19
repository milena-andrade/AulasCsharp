using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bianca
{
    public class Aluno
    {
        public string nome;
        public string matricula;
        public Turma turma; // atributo do tipo turma objeto



        public void mostrarAluno(string nomeAluno, string matriculaAluno) //metodo
        {
            Console.WriteLine(nomeAluno);
            Console.WriteLine(matriculaAluno);

        }

        public void mostrarTurma(string periodo)
        {
            Console.WriteLine(periodo);
        }
    }

}
