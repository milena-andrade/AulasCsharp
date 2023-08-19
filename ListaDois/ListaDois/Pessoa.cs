using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDois
{
    public class Pessoa
    {
        //propriedade statica
        private static int totalPessoas = 0;

        //toda vez que uma pessoa for criada vai ser adicionado dentro do construtor
        public Pessoa()
        {
            totalPessoas++;
        }
        //usando o private la em cima eu consigo pegar o get do total de pessoas dentro do metodo
        public static int totalPessoasMET
        {
            get { return totalPessoas;  }
        }
    }
}
