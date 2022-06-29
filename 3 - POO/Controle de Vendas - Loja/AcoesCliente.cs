using System;
using System.Collections.Generic;
using System.Threading;

namespace Projeto6
{
    public static class AcoesCliente
    {
        public static List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();
        public static List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
        public static string nomePJ, nomePF, telefonePJ, telefonePF, cnpj, cpf, ruaPJ, ruaPF, cidadePJ, cidadePF, estadoPJ, estadoPF, paisPJ, paisPF, numeroPJ, numeroPF;
        public static Endereco novoEnderecoPJ, novoEnderecoPF;
        public static PessoaJuridica novaPessoaJuridica;
        public static PessoaFisica novaPessoaFisica;

        public static void CadastrarCliente()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.CursorLeft = 35;
            System.Console.WriteLine("Você é Pessoa Jurídica[1] ou Pessoa Física[2]?");
            Console.CursorLeft = 35;
            string opcao = Console.ReadLine();


            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======--------CADASTRO DE CLIENTES--------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======---------(PESSOA JURÍDICA)----------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o nome do cliente:");
                    Console.CursorLeft = 35;
                    nomePJ = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o telefone do cliente:");
                    Console.CursorLeft = 35;
                    telefonePJ = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o CNPJ do cliente:");
                    Console.CursorLeft = 35;
                    cnpj = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite a rua do cliente:");
                    Console.CursorLeft = 35;
                    ruaPJ = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o numero do cliente:");
                    Console.CursorLeft = 35;
                    numeroPJ = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite a cidade do cliente:");
                    Console.CursorLeft = 35;
                    cidadePJ = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o estado do cliente:");
                    Console.CursorLeft = 35;
                    estadoPJ = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o país do cliente:");
                    Console.CursorLeft = 35;
                    paisPJ = Console.ReadLine();
                    novoEnderecoPJ = new Endereco(ruaPJ, numeroPJ, cidadePJ, estadoPJ, paisPJ);
                    novaPessoaJuridica = new PessoaJuridica(nomePJ, telefonePJ, cnpj, novoEnderecoPJ);
                    listaPessoaJuridica.Add(novaPessoaJuridica);
                    System.Console.WriteLine(" ");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Cliente cadastrado com sucesso.");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.CursorLeft = 35;
                    Console.ReadKey();
                    AcoesDoSistema.Menu();
                    break;

                case "2":
                    Console.Clear();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======--------CADASTRO DE CLIENTES--------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======----------(PESSOA FÍSICA)-----------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o nome do cliente:");
                    Console.CursorLeft = 35;
                    nomePF = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o telefone do cliente:");
                    Console.CursorLeft = 35;
                    telefonePF = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o CPF do cliente:");
                    Console.CursorLeft = 35;
                    cpf = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite a rua do cliente:");
                    Console.CursorLeft = 35;
                    ruaPF = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o numero do cliente:");
                    Console.CursorLeft = 35;
                    numeroPF = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite a cidade do cliente:");
                    Console.CursorLeft = 35;
                    cidadePF = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o estado do cliente:");
                    Console.CursorLeft = 35;
                    estadoPF = Console.ReadLine();
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o país do cliente:");
                    Console.CursorLeft = 35;
                    paisPF = Console.ReadLine();
                    novoEnderecoPF = new Endereco(ruaPF, numeroPF, cidadePF, estadoPF, paisPF);
                    novaPessoaFisica = new PessoaFisica(nomePF, telefonePF, cpf, novoEnderecoPF);
                    listaPessoaFisica.Add(novaPessoaFisica);
                    System.Console.WriteLine(" ");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Cliente cadastrado com sucesso.");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.CursorLeft = 35;
                    Console.ReadKey();
                    AcoesDoSistema.Menu();
                    break;

                default:
                    Console.CursorLeft = 35;
                    System.Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Opção inválida. Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.ReadKey();
                    AcoesDoSistema.Menu();
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ListarClientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======----------LISTA DE CLIENTES---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine("Clientes que são pessoa física:");
            Console.CursorLeft = 35;
            System.Console.WriteLine("-------------------------------");
            foreach (var item in listaPessoaFisica)
            {
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Nome: {item.Nome}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Telefone: {item.Telefone}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"CPF: {item.Cpf}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Endereco: {item.Endereco.Completo} ");
                Console.CursorLeft = 35;
                System.Console.WriteLine("-------------------------------");
            }
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine("--------------------------------");
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;

            Console.CursorLeft = 35;
            System.Console.WriteLine("Clientes que são pessoa jurídica:");
            Console.CursorLeft = 35;
            System.Console.WriteLine("---------------------------------");
            foreach (var item in listaPessoaJuridica)
            {
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Nome: {item.Nome}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Telefone: {item.Telefone}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"CNPJ: {item.Cnpj}");
                Console.CursorLeft = 35;
                System.Console.WriteLine($"Endereco: {item.Endereco.Completo} ");
                Console.CursorLeft = 35;
                System.Console.WriteLine("-------------------------------");
            }
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
            Console.CursorLeft = 35;
            Console.ReadKey();
            AcoesDoSistema.Menu();
        }

        public static void PesquisarCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======--------PESQUISA DE CLIENTES--------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine("======------------------------------------======");
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine("Digite o nome do cliente a ser encontrado:");
            Console.CursorLeft = 35;
            string nomeCliente = Console.ReadLine();
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine($"------------------------------------------------------------");
            Console.CursorLeft = 35;
            System.Console.WriteLine($"--------------CLIENTES TIPO PESSOA FÍSICA-------------------");
            Console.CursorLeft = 35;
            System.Console.WriteLine($"------------------------------------------------------------");
            foreach (var item in listaPessoaFisica)
            {
                if (item.Nome.Contains(nomeCliente))
                {
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"------------------------------------------------------------");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"Nome: {item.Nome}");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"Endereco: {item.Endereco.Completo}");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"Telefone: {item.Telefone}");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"------------------------------------------------------------");

                }
            }
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine($"------------------------------------------------------------");
            Console.CursorLeft = 35;
            System.Console.WriteLine($"--------------CLIENTES TIPO PESSOA JURÍDICA-----------------");
            Console.CursorLeft = 35;
            System.Console.WriteLine($"------------------------------------------------------------");
            foreach (var item in listaPessoaJuridica)
            {
                if (item.Nome.Contains(nomeCliente))
                {
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"------------------------------------------------------------");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"Nome: {item.Nome}");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"Endereco: {item.Endereco.Completo}");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"Telefone: {item.Telefone}");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine($"------------------------------------------------------------");
                }
            }
            Console.CursorLeft = 35;
            System.Console.WriteLine(" ");
            Console.CursorLeft = 35;
            System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
            Console.CursorLeft = 35;
            Console.ReadKey();
            AcoesDoSistema.Menu();
        }

        public static PessoaFisica ClientePessoaFisicaExiste(string cpfDoCliente)
        {
            foreach (PessoaFisica pessoaFisica in listaPessoaFisica)
            {
                if (pessoaFisica.Cpf == cpfDoCliente)
                {
                    return pessoaFisica;
                }
            }
            return null;
        }

        public static PessoaJuridica ClientePessoaJuridicaExiste(string cnpjDoCliente)
        {
            foreach (PessoaJuridica pessoaJuridica in listaPessoaJuridica)
            {
                if (pessoaJuridica.Cnpj == cnpjDoCliente)
                {
                    return pessoaJuridica;
                }
            }
            return null;
        }

        public static void RemoverCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft = 35;
            System.Console.WriteLine("O cliente é Pessoa Juridica[1] ou Pessoa Física[2]?");
            Console.CursorLeft = 35;
            string opcao = System.Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======----------REMOVER CLIENTE-----------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======---------(PESSOA JURÍDICA)----------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o CNPJ do cliente a ser excluído:");
                    Console.CursorLeft = 35;
                    string cnpjDigitado = System.Console.ReadLine();
                    PessoaJuridica pessoaJuridicaExistente = ClientePessoaJuridicaExiste(cnpjDigitado);
                    if (pessoaJuridicaExistente != null)
                    {
                        listaPessoaJuridica.Remove(pessoaJuridicaExistente);
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine($"Cliente {pessoaJuridicaExistente.Nome} removido.");
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
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======---------TROPTECH MODAS 1.0---------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======----------REMOVER CLIENTE-----------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======----------(PESSOA FÍSICA)-----------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("======------------------------------------======");
                    Console.CursorLeft = 35;
                    System.Console.WriteLine("Digite o CPF do cliente a ser excluído:");
                    Console.CursorLeft = 35;
                    string cpfDigitado = System.Console.ReadLine();
                    PessoaFisica pessoaFisicaExistente = ClientePessoaFisicaExiste(cpfDigitado);
                    if (pessoaFisicaExistente != null)
                    {
                        listaPessoaFisica.Remove(pessoaFisicaExistente);
                        System.Console.WriteLine(" ");
                        Console.CursorLeft = 35;
                        System.Console.WriteLine($"Cliente {pessoaFisicaExistente.Nome} removido.");
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
    }
}