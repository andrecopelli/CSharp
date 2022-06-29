using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoM2P3AndreCopelli
{
    public class Answer : Email, IDisplayableEmail
    {
        public static int getQuestionId;
        public static string getQuestionContent;
        public bool WasAnswered { get => false; }


        public static void SendAnswer()
        {
            Console.Clear();
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- BEM VINDO ALUNO --------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======----- Identificação do Email ----======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("Informe o número de identificação do email que deseja responder:");
            int typedId = int.Parse(Console.ReadLine());
            Answer newAnswer = new Answer();
            foreach (var item in QuestionList)
            {
                if (item.QuestionId == typedId)
                {
                    Console.Clear();
                    getQuestionId = item.QuestionId;
                    getQuestionContent = item.Content;
                    System.Console.WriteLine("======---------------------------------======");
                    System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
                    System.Console.WriteLine("======---------------------------------======");
                    System.Console.WriteLine("======-------- BEM VINDO ALUNO --------======");
                    System.Console.WriteLine("======---------------------------------======");
                    System.Console.WriteLine("======------- Envie sua Resposta ------======");
                    System.Console.WriteLine("======---------------------------------======");
                    System.Console.WriteLine("Informe sua resposta:");
                    newAnswer.Content = Console.ReadLine();
                    item.WasAnswered = true;
                    Email.AnswerList.Add(newAnswer);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Resposta enviada com sucesso!");
                    System.Console.WriteLine("Aperte qualquer tecla para continuar.");
                    Console.ReadKey();
                    Program.TeacherMenu();
                }

            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine("Email não encontrado.");
            System.Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadKey();
            Program.TeacherMenu();
        }

        public static void ShowAnswers()
        {
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======------ Lista de Respostas -------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine(" ");
            if (AnswerList.Count > 0)
            {
                IEnumerable<Answer> query = from Answer in AnswerList orderby Email.IdNumber descending select Answer;
                foreach (Answer item in query)
                {
                    
                    System.Console.WriteLine(item.Show());
                }
            }
            else
            {
                System.Console.WriteLine("Nenhuma resposta enviada.");
            }
        }

        public string Show()
        {
            return $"============= Email de Resposta =============\n [Identificação da dúvida]: {getQuestionId}\n [Identificação do email]: {IdNumber}\n [Pergunta]: {getQuestionContent}\n [Resposta]: {Content}";
        }

        // public Question FindQuestion()
        // {
        //     Console.Clear();
        //     System.Console.WriteLine("======---------------------------------======");
        //     System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
        //     System.Console.WriteLine("======---------------------------------======");
        //     System.Console.WriteLine("======-------- BEM VINDO ALUNO --------======");
        //     System.Console.WriteLine("======---------------------------------======");
        //     System.Console.WriteLine("======----- Identificação do Email ----======");
        //     System.Console.WriteLine("======---------------------------------======");
        //     System.Console.WriteLine("Informe o número de identificação do email que deseja responder:");
        //     int typedId = int.Parse(Console.ReadLine());
        //     foreach (Question searchedQuestion in QuestionList)
        //     {
        //         if (searchedQuestion.QuestionId == typedId)
        //         {
        //             return searchedQuestion;
        //         }
        //     }

        //     return null;
        // }
    }
}