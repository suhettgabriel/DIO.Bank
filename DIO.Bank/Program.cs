using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas =  new List<Conta>();
        static void Main(string[] args)
        {
            //Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0,"Gabriel Suhett");
            //Console.WriteLine(minhaConta.ToString());
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario= ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços. Volte Sempre!");
            Console.ReadLine();
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas cadastradas.");
            if(listContas.Count == 0 )
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }

            for(int i = 0; i< listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {   
             Console.WriteLine("Inserir nova Conta");
             Console.WriteLine("Digite 1 para conta Físca ou 2 para Jurídica ");
             int entradaTipoConta = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o nome do cliente: ");
             string entradaNome = Console.ReadLine();
             Console.WriteLine("Digite o saldo inicial: ");
             double entradaSaldo = double.Parse(Console.ReadLine());
             Console.WriteLine("Digite o limite de crédito: ");
             double entradaCredito = double.Parse(Console.ReadLine());

             Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                          saldo: entradaSaldo,
                                          credito: entradaCredito,
                                          nome: entradaNome);
            listContas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank ao seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Contas");
            Console.WriteLine("2- Inserir Nova Conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
