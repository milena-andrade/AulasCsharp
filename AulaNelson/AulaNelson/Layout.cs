using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AulaNelson
{
    
    public class Layout
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();
        int opcao = 0;

        public void Login()
        {
            Console.WriteLine("Você é funcionário ou T.I");
            Console.WriteLine("1 - Funcionario");
            Console.WriteLine("2 - T.I");

            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Funcionario funcionario = new Funcionario();
                    ContaBanco contaBanco = new ContaBanco();
                    funcionario.conta = contaBanco;
                    funcionarios.Add(funcionario);
                    TelaPrincipal(funcionario);
                    break;
                case 2:
                    Funcionario funcionarioTI = new Funcionario();
                    AlterarDados(funcionarioTI);
                    break;
                default:
                    break;

            }

           
        }
        public void TelaPrincipal(Funcionario funcionario)
        {
            Console.WriteLine("ENTRE COM OS NUMEROS DA OPERAÇÃO:");
            Console.WriteLine("1 - DEPOSITAR");
            Console.WriteLine("2 - SACAR");
            Console.WriteLine("3 - EXTRATO");
            Console.WriteLine("4 - SAIR");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Depositar(funcionario);
                        break;
                case 2:
                    Sacar(funcionario);
                    break;
                case 3:
                    funcionario.conta.extrato();
                    break;
                case 4:
                    Sair();
                    break;
                default:
                    break;

            }
        }

        public void Depositar(Funcionario funcionario)
        {
            Console.WriteLine("Digite o valor do deposito");
            double valor = double.Parse(Console.ReadLine());
            funcionario.conta.depositar(valor);



            funcionario.conta.AdicionarMovimentacao("Depósito", valor);


            Console.Clear();

            Console.WriteLine("                                                                            ");
            Console.WriteLine("                                                                            ");
            Console.WriteLine("                           Deposito Realizado com Sucesso                   ");
            Console.WriteLine("                           Seu saldo é: {0}                        ", funcionario.conta.saldo);
            Console.WriteLine("                           ==========================                       ");

            Thread.Sleep(1000);

            Console.Clear();
            TelaPrincipal(funcionario);

        }

        public void Sacar(Funcionario funcionario)
        {
            Console.WriteLine("Digite o valor do saque");
            double valor = double.Parse(Console.ReadLine());
            bool sacou = funcionario.conta.sacar(valor);

            if (sacou)
            {
                funcionario.conta.AdicionarMovimentacao("Saque", valor);




                Console.Clear();

                Console.WriteLine("                                                                            ");
                Console.WriteLine("                                                                            ");
                Console.WriteLine("                           Saque Realizado com Sucesso                   ");
                Console.WriteLine("                           Seu saldo é:{0}                        ", funcionario.conta.saldo);
                Console.WriteLine("                           ==========================                       ");

                Thread.Sleep(1000);

                Console.Clear();
                TelaPrincipal(funcionario);
            }
            Console.WriteLine("                           VIXIII SALDO INSUFICIENTE                   ");
            Thread.Sleep(1000);

            Console.Clear();
            TelaPrincipal(funcionario);



        }
        public void Sair()
        {
            Console.WriteLine("Pobre");
        }

        public void AlterarDados(Funcionario funcionario)
        {
            funcionario.nome = "Milena";
            funcionario.salario = 6000;
            Console.WriteLine("Funcionarios:");
            Console.WriteLine("Nome {0}",funcionario.nome);
            Console.WriteLine("Nome {0}", funcionario.salario);
            Console.WriteLine("Digite o Novo Nome: ");
            string novoNome = Console.ReadLine();
            funcionario.AlteraNome(novoNome);
            Console.WriteLine("Digite o Novo Salario: ");
            double salario = double.Parse(Console.ReadLine());
            funcionario.AlteraSalario(salario);

            Console.WriteLine("Nome, {0}", funcionario.nome);
            Console.WriteLine("salario, {0}", funcionario.salario);
        }

    }
}
