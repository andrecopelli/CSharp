using System;

namespace Projeto_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            //MÉTODO DE LOGIN RECURSIVO

            static void LoginRecursivo(int valor)
            {
                string loginDigitado;
                string senhaDigitada;
                
                do
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("-------------------- CALCULADORA INTERATIVA 1.0 --------------------");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("-------------------------------LOGIN--------------------------------");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorLeft = 25;
                Console.Write("Digite o login: ");                                      //TELA DE LOGIN
                loginDigitado = Console.ReadLine();
                Console.CursorLeft = 25;
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if (senhaDigitada == "123456" && loginDigitado == "aluno")
                {
                    MenuCalculadora(1);                                                 //CHAMADA PARA O MENU DA CALCULADORA SE A SENHA E LOGIN FOREM CORRETOS
                    break;
                    }
                else
                {
                    if (senhaDigitada != "123456" && loginDigitado != "aluno")
                    {
                        Console.WriteLine("");
                        Console.CursorLeft = 22;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("LOGIN E SENHA ERRADOS!");                    //SE SENHA E LOGIN FOREM ERRADOS, O VALOR É DECRESCIDO E OS ERROS SÃO INFORMADOS
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        valor--;
                    }

                    if (senhaDigitada == "123456" && loginDigitado != "aluno")
                    {
                        Console.WriteLine("");
                        Console.CursorLeft = 28;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("LOGIN ERRADO!");                             //SE O LOGIN FOR ERRADO, O VALOR É DECRESCIDO E O ERRO É INFORMADO
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        valor--;
                    }

                    if (senhaDigitada != "123456" && loginDigitado == "aluno")
                    {
                        Console.WriteLine("");
                        Console.CursorLeft = 28;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SENHA ERRADA!");                             //SE A SENHA FOR ERRADA, O VALOR É DECRESCIDO E O ERRO É INFORMADO
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        valor--;
                    }
                    
                if (valor == 0)
                {
                    EasterEgg(1);                                                       //SE O VALOR CHEGAR A 0, ACABARAM AS TENTATIVAS, O PROGRAMA EXIBE UM EASTER EGG E FINALIZA
                    Console.CursorLeft = 25;                                            
                    Console.WriteLine("QUANTIDADE DE TENTATIVAS ALCANÇADAS, APERTE QUALQUER TECLA PARA SAIR!");     
                }
                }
                } while (valor != 0);                                                   //ENQUANTO O VALOR FOR DIFERENTE DE 0, O LOOP CONTINUA
                
            }
            
            //MÉTODO DO MENU DA  CALCULADORA

            static void MenuCalculadora(int valor)
            {
                string loginDigitado = "aluno";
                string opcao;
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- MENU ---------------------------------");
                Console.WriteLine($"Escolha alguma das opções abaixo, ou aperte ENTER para sair:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[1] + SOMA");
                Console.ForegroundColor = ConsoleColor.Cyan;                                                    //TELA DE MENU DA CALCULADORA, APRESENTANDO AS OPERAÇÕES, CADA UMA COM SUA COR
                Console.WriteLine($"[2] - SUBTRAÇÃO");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[3] / DIVISÃO");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"[4] x MULTIPLICAÇÃO");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[5] _ SAIR");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    
                        Console.Clear();
                        CalculaAdicao(1);
                        break;
                        
                    case "2":

                        Console.Clear();
                        CalculaSubtracao(1);
                        break;
                    
                    case "3":
                    
                        Console.Clear();
                        CalculaDivisao(1);
                        break;
                        
                    case "4":                                               //SWITCH-CASE COMPARANDO A OPÇÃO DIGITADA E ENCAMINHANDO PARA O MÉTODO CORRESPONDENTE

                        Console.Clear();
                        CalculaMultiplicacao(1);
                        break;
                    
                    case "5":

                        Console.Clear();
                        Sair(1);
                        break;
                    
                    default:

                        Console.Clear();
                        OpcaoInvalida(1);
                        MenuCalculadora(1);                                  //A OPÇÃO DEFAULT CHAMA O MÉTODO DA OPÇÃO INVÁLIDA E LOGO APÓS CHAMA NOVAMENTE O MENU DA CALCULADORA                       
                        break;
                }

            }
            
            static void CalculaAdicao(int valor)
            {
                string loginDigitado = "aluno";
                int numero1;
                int numero2;
                string opcao;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (+) -------------------------");
                Console.WriteLine("Digite o primeiro número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");                                         //MÉTODO QUE CALCULA A ADIÇÃO E CHAMA O SUBMENU
                numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 + numero2;
                Console.WriteLine($"RESULTADO: {numero1} + {numero2} = {resultado}");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"Pressione ENTER para prosseguir!");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (+) -------------------------");
                Console.WriteLine($"Escolha alguma das opções abaixo:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[1] - REFAZER OPERAÇÃO");                                       //SUBMENU QUE REENCAMINHA PARA O MÉTODO ANTERIOR OU PARA O MENU DA CALCULADORA
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[2] - VOLTAR PARA AS OPERAÇÕES");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    
                        Console.Clear();
                        CalculaAdicao(1);
                        break;
                        
                    case "2":

                        Console.Clear();
                        MenuCalculadora(1);                                         //SWITCH-CASE QUE ENCAMINHA PARA OS MÉTODOS CORRESPONDENTES
                        break;
                    
                    default:

                        Console.Clear();
                        OpcaoInvalida(1);
                        MenuCalculadora(1);
                        break;
                   }
            }
            
            static void CalculaSubtracao(int valor)
            {
                string loginDigitado = "aluno";
                int numero1;
                int numero2;
                int opcao;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (-) -------------------------");
                Console.WriteLine("Digite o primeiro número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");                                             //MÉTODO QUE CALCULA A SUBTRAÇÃO E CHAMA O SUBMENU
                numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 - numero2;
                Console.WriteLine($"RESULTADO: {numero1} - {numero2} = {resultado}");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"Pressione ENTER para prosseguir!");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (-) -------------------------");
                Console.WriteLine($"Escolha alguma das opções abaixo:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[1] - REFAZER OPERAÇÃO");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[2] - VOLTAR PARA AS OPERAÇÕES");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    
                        Console.Clear();
                        CalculaSubtracao(1);
                        break;
                        
                    case 2:

                        Console.Clear();
                        MenuCalculadora(1);
                        break;
                    
                    default:

                        Console.Clear();
                        OpcaoInvalida(1);
                        MenuCalculadora(1);
                        break;
                   }
            }

            static void CalculaDivisao(int valor)
            {
                string loginDigitado = "aluno";
                decimal numero1;
                decimal numero2;
                int opcao;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (/) -------------------------");
                Console.WriteLine("Digite o primeiro número: ");
                numero1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");                                             //MÉTODO QUE CALCULA A DIVISÃO E CHAMA O SUBMENU
                numero2 = Convert.ToDecimal(Console.ReadLine());
                decimal resultado = numero1 / numero2;
                Console.WriteLine($"RESULTADO: {numero1} / {numero2} = {resultado}");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"Pressione ENTER para prosseguir!");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (/) -------------------------");
                Console.WriteLine($"Escolha alguma das opções abaixo:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[1] - REFAZER OPERAÇÃO");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[2] - VOLTAR PARA AS OPERAÇÕES");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    
                        Console.Clear();
                        CalculaDivisao(1);                  //VOLTA A CALCULAR A OPERAÇÃO ANTERIOR
                        break;
                        
                    case 2:

                        Console.Clear();
                        MenuCalculadora(1);                 //VOLTA AO MENU DA CALCULADORA
                        break;
                    
                    default:

                        Console.Clear();
                        OpcaoInvalida(1);                   //AVISA DA OPÇÃO INVÁLIDA DE CHAMA O MENU DA CALCULADORA NOVAMENTE
                        MenuCalculadora(1);
                        break;
                   }
            }
            static void CalculaMultiplicacao(int valor)
            {
                string loginDigitado = "aluno";
                int numero1;
                int numero2;
                int opcao;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (x) -------------------------");
                Console.WriteLine("Digite o primeiro número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");                                             //MÉTODO QUE CALCULA A MULTIPLICAÇÃO E CHAMA O SUBMENU
                numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 * numero2;
                Console.WriteLine($"RESULTADO: {numero1} x {numero2} = {resultado}");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"Pressione ENTER para prosseguir!");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"                         USUÁRIO: {loginDigitado}                   ");
                Console.WriteLine($"--------------------------------------------------------------------");
                Console.WriteLine($"----------------------------- OPERAÇÃO (x) -------------------------");
                Console.WriteLine($"Escolha alguma das opções abaixo:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[1] - REFAZER OPERAÇÃO");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[2] - VOLTAR PARA AS OPERAÇÕES");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"--------------------------------------------------------------------");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    
                        Console.Clear();
                        CalculaMultiplicacao(1);
                        break;
                        
                    case 2:

                        Console.Clear();
                        MenuCalculadora(1);
                        break;
                    
                    default:

                        Console.Clear();
                        OpcaoInvalida(1);
                        MenuCalculadora(1);
                        break;
                }
            }

            static void Sair(int valor)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.CursorLeft = 35;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"APERTE QUALQUER TECLA PARA SAIR.");          //MÉTODO QUE FECHA O SISTEMA;
                Console.CursorLeft = 35;
                Console.ReadKey();
                Environment.Exit(0);                                        
            }

            static void OpcaoInvalida(int valor)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.CursorLeft = 35;
                Console.WriteLine($"ATENCÃO! DIGITE UM VALOR VÁLIDO!");       //MÉTODO QUE AVISA QUE A OPÇÃO FOI INVÁLIDA
                System.Threading.Thread.Sleep(1500);
            }

            static void EasterEgg(int valor)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.CursorLeft = 51;
                Console.WriteLine($"DESENVOLVIDO POR:");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;
                Console.WriteLine("      *      ");
                Console.ForegroundColor = ConsoleColor.Red;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;
                Console.WriteLine("     ***     ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;
                Console.WriteLine("    *****    ");
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;                                                //PEQUENO EASTER EGG QUANDO O USUÁRIO ERRA AS 3 TENTATIVAS
                Console.WriteLine("   *******   ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;
                Console.WriteLine("  *********  ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;
                Console.WriteLine(" *********** ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 52;
                Console.WriteLine("*************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.CursorLeft = 50;
                Console.WriteLine($"ANDRÉ LUIZ COPELLI");
                System.Threading.Thread.Sleep(500);
                Console.CursorLeft = 39;
                Console.WriteLine($"QUE A FORÇA ESTEJA COM VOCÊS, TROPTECHERS!");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }

            LoginRecursivo(3);                              //MÉTODO DE LOGIN CHAMADO 3 VEZES, PARA PASSAR O VALOR DAS 3 TENTATIVAS PARA O VALOR DO MÉTODO E SERVIR DE CONTADOR
            System.Threading.Thread.Sleep(1000);
            Console.ReadKey();

            
                
                
        }
    }
}

