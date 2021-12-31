using System;

namespace Exercicio_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.WriteLine("-------------------");
            Console.WriteLine("Bem vindo ao Banco!");
            Console.WriteLine("-------------------");

            Console.Write("Entre com o Número da sua conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

        digitaropcao:
            Console.Write("Haverá depósito inicial? (s/n)");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 'n')
            {
                conta = new Conta(titular, numero);

            }
            else if (opcao == 's')
            {
                Console.WriteLine();
                Console.Write("Entre com o valor da conta: ");
                double valor = double.Parse(Console.ReadLine());

                conta = new Conta(titular, numero, valor);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("É necessário escolher uma opcao correta (s/n)");
                Console.WriteLine();
                goto digitaropcao;
            }

            char escolhaUsuario = Menu();

            while (escolhaUsuario != 'X')
            {
                switch (escolhaUsuario)
                {
                    case '1':
                        Console.WriteLine(conta);
                        break;
                    case '2':

                        break;
                    case '3':
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
                escolhaUsuario = Menu();
            }

            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Até mais!");
            Console.WriteLine("---------");
            Console.WriteLine();

            static char Menu()
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Escolha uma opção!");
                Console.WriteLine("------------------");

                Console.WriteLine("1 - Ver Conta");
                Console.WriteLine("2 - Depositar valor na Conta");
                Console.WriteLine("3 - Sacar valor da Conta");
                Console.WriteLine("X - Sair");
                char escolha = char.Parse(Console.ReadLine().ToUpper());

                return escolha;
            }
        }
    }
}

