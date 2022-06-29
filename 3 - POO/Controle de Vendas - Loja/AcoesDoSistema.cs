using System;

namespace Projeto6
{
    public static class AcoesDoSistema
    {

        public static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======-----------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======--------TROPTECH MODAS 1.0---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======-----------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------Digite a opção desejada------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======-----------------------------------======");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[1] Cadastrar Cliente----------======");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[2] Exibir todos os clientes---======");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[3] Pesquisar Cliente----------======");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[4] Remover Cliente------------======");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[5] Cadastrar Venda------------======");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[6] Exibir todas as vendas-----======");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----[0] Sair-----------------------======");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======-----------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======-----------------------------------======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 35;
            string opcao = Console.ReadLine();
            Console.CursorLeft = 35;

            while (opcao != "100000")
            {
                switch (opcao)
                {
                    case "1":
                        AcoesCliente.CadastrarCliente();
                        break;

                    case "2":
                        AcoesCliente.ListarClientes();
                        break;

                    case "3":
                        AcoesCliente.PesquisarCliente();
                        break;

                    case "4":
                        AcoesCliente.RemoverCliente();
                        break;

                    case "5":
                        AcoesVendas.CadastrarVenda();
                        break;

                    case "6":
                        AcoesVendas.ListarVendas();
                        break;

                    case "0":
                        Environment.Exit(1);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Comando inválido!");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        Menu();
                        break;
                }
                Console.Clear();
            }
        }
    }
}