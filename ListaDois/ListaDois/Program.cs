using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Metodo estatico Somar {0}",Calculadora.somar(5, 5));
            Console.WriteLine("Metodo estatico converter {0}", ConversorCsharp.celsoFaren(32));

            string original = "radar";
            string reversed = StringUtils.InverterString(original);
            bool isPalindrome = StringUtils.Palindromo(original);

            Console.WriteLine("String original: " + original);
            Console.WriteLine("String invertida: " + reversed);
            Console.WriteLine("É um palíndromo? " + isPalindrome);

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();
            Console.WriteLine("Total pessoas: " + Pessoa.totalPessoasMET);

            Console.ReadKey();
        }
    }
}
