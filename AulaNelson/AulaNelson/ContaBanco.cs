using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AulaNelson
{
    public class ContaBanco
    {
        public int numero;
        public int limite;
        public double saldo;

        public ContaBanco()
        {
            this.numero += 1;
            this.limite = 200;
        }

        public void depositar(double valor)
        {
            this.saldo += valor;
           
        }

        public bool sacar(double valor)
        {
            if(valor > this.saldo)
            {
                return false; 
                
            }
            this.saldo -= valor;
            return true;

        }


        private List<string> movimentacoes = new List<string>();

        public void AdicionarMovimentacao(string descricao, double valor)
        {
            movimentacoes.Add($"[{DateTime.Now}] {descricao}: {valor}");
        }

        public void extrato()
        {
            Console.WriteLine("Movimentações:");
            foreach (string movimentacao in movimentacoes)
            {
                Console.WriteLine(movimentacao);
            }
            Console.WriteLine($"Saldo atual: {saldo}");

            Thread.Sleep(1000);

            Console.Clear();
            Layout LT = new Layout();
            LT.Login();


        }
    }
}
