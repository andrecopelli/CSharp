using System;
using System.Collections.Generic;
using System.Threading;

namespace Projeto6
{
    public static class AcoesVendas
    {

        public static List<Vendas> listaVendas = new List<Vendas>();
        public static Vendas novaVenda;
        public static string novaDescricao;
        public static decimal novoValorTotal;
        
        public static void CadastrarVenda()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======---------CADASTRO DE VENDAS---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("Você é Pessoa Jurídica[1] ou Pessoa Física[2]?");
            Console.CursorLeft = 35;
            string opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    System.Console.WriteLine(" ");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o nome do cliente:");
                    Console.CursorLeft = 35;
                    string nomeClientePJ = Console.ReadLine();
                    PessoaJuridica vendaPessoaJurudica = PessoaJuridicaVenda(nomeClientePJ);        
                    
                    if (vendaPessoaJurudica != null)
                    {
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Digite a descrição da venda:");
                        Console.CursorLeft = 35;
                        novaDescricao = Console.ReadLine();
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Digite o valor total da venda:");
                        Console.CursorLeft = 35;Console.CursorLeft = 35;
                        novoValorTotal = Convert.ToDecimal(Console.ReadLine());
                        novaVenda = new Vendas(vendaPessoaJurudica);
                        novaVenda.Descricao = novaDescricao;
                        novaVenda.ValorTotal = novoValorTotal;
                        listaVendas.Add(novaVenda);
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Venda cadastrada com sucesso.");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        AcoesDoSistema.Menu();
                    }
                    else if (listaVendas.Count == 0)
                    {
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Nenhum cliente cadastrado.");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        AcoesDoSistema.Menu();
                    }
                    else
                    {
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Cliente não encontrado.");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        AcoesDoSistema.Menu();
                    }    
                    
                    break;

                case "2":
                    System.Console.WriteLine(" ");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o nome do cliente:");
                    Console.CursorLeft = 35;
                    string nomeClientePF = Console.ReadLine();
                    PessoaFisica vendaPessoaFisica = PessoaFisicaVenda(nomeClientePF);
                    
                    if (vendaPessoaFisica != null)
                    {
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Digite a descrição da venda:");
                        Console.CursorLeft = 35;
                        novaDescricao = Console.ReadLine();
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Digite o valor total da venda:");
                        Console.CursorLeft = 35;
                        novoValorTotal = Convert.ToDecimal(Console.ReadLine());
                        novaVenda = new Vendas(vendaPessoaFisica);
                        novaVenda.Descricao = novaDescricao;
                        novaVenda.ValorTotal = novoValorTotal;
                        listaVendas.Add(novaVenda);
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Venda cadastrada com sucesso.");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        AcoesDoSistema.Menu();
                    }
                    else if (listaVendas.Count == 0)
                    {
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Nenhum cliente cadastrado.");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        AcoesDoSistema.Menu();
                    }
                    else
                    {
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Cliente não encontrado.");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                        Console.CursorLeft = 35;
                        Console.ReadKey();
                        AcoesDoSistema.Menu();
                    }    
                    break;

                default:
                    System.Console.WriteLine(" ");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Opção inválida.");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.CursorLeft = 35;
                    Console.ReadKey();
                    AcoesDoSistema.Menu();
                    break;

            }
        }

        public static void ListarVendas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======-----------LISTA DE VENDAS----------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            foreach (var item in listaVendas)
            {
                System.Console.WriteLine(" ");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"---------------------------------------------");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Cliente: {item.Cliente.Nome}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Telefone: {item.Cliente.Telefone}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Descrição da Venda: {item.Descricao}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Valor Total da Venda: {item.ValorTotal}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"---------------------------------------------");
            }
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
            Console.CursorLeft = 35;
            Console.ReadKey();
            AcoesDoSistema.Menu();
        }

        public static PessoaFisica PessoaFisicaVenda(string nomeDoCliente)
        {
            foreach (PessoaFisica pessoaFisica in AcoesCliente.listaPessoaFisica)
            {
                if (pessoaFisica.Nome.Contains(nomeDoCliente))
                {
                    return pessoaFisica;
                }
            }
            return null;
        }

        public static PessoaJuridica PessoaJuridicaVenda(string nomeDoCliente)
        {
            foreach (PessoaJuridica pessoaJuridica in AcoesCliente.listaPessoaJuridica)
            {
                if (pessoaJuridica.Nome.Contains(nomeDoCliente))
                {
                    return pessoaJuridica;
                }
            }
            return null;
        }
    }
}