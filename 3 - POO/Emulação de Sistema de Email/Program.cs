using System;

namespace ProjetoM2P3AndreCopelli
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            
                Console.Clear();
                System.Console.WriteLine("======---------------------------------======");
                System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
                System.Console.WriteLine("======---------------------------------======");
                System.Console.WriteLine("======-------- Escolha a opção --------======");
                System.Console.WriteLine("======---------------------------------======");
                System.Console.WriteLine("======-------- [1] -> Aluno -----------======");
                System.Console.WriteLine("======-------- [2] -> Professor -------======");
                System.Console.WriteLine("======-------- [3] -> Sair ------------======");
                System.Console.WriteLine("======---------------------------------======");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        StudentMenu();
                        break;
                    case "2":
                        TeacherMenu();
                        break;
                    case "3":
                        Environment.Exit(1);
                        break;
                    default:
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Opção inválida!");
                        System.Console.WriteLine("Aperte qualquer tecla para voltar.");
                        Console.ReadKey();
                        MainMenu();
                        break;
                }
            
        }

        public static void TeacherMenu()
        {
            Console.Clear();
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======------ BEM VINDO PROFESSOR ------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- Escolha a opção --------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======----- [1] -> Visualizar Dúvidas -======");
            System.Console.WriteLine("======----- [2] -> Enviar Resposta ----======");
            System.Console.WriteLine("======----- [3] -> Voltar -------------======");
            System.Console.WriteLine("======---------------------------------======");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Question.ShowQuestionsToTeacher();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Aperte qualquer tecla para voltar.");
                    Console.ReadKey();
                    TeacherMenu();
                    break;
                case "2":
                    Answer.SendAnswer();
                    break;
                case "3":
                    MainMenu();
                    break;
                default:
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Opção inválida!");
                    System.Console.WriteLine("Aperte qualquer tecla para voltar.");
                    Console.ReadKey();
                    TeacherMenu();
                    break;
            }
        }

        public static void StudentMenu()
        {
            Console.Clear();
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- BEM VINDO ALUNO --------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- Escolha a opção --------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======----- [1] -> Enviar Dúvida ------======");
            System.Console.WriteLine("======----- [2] -> Visualizar Emails --======");
            System.Console.WriteLine("======----- [3] -> Voltar -------------======");
            System.Console.WriteLine("======---------------------------------======");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Question.SendQuestion();
                    break;
                case "2":
                    Question.ShowQuestions();
                    if (Email.AnswerList.Count > 0)
                    {
                        Answer.ShowAnswers();    
                    }
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Aperte qualquer tecla para voltar.");
                    Console.ReadKey();
                    StudentMenu();
                    break;
                case "3":
                    MainMenu();
                    break;
                default:
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Opção inválida!");
                    System.Console.WriteLine("Aperte qualquer tecla para voltar.");
                    Console.ReadKey();
                    StudentMenu();
                    break;
            }
        }
    }
}
