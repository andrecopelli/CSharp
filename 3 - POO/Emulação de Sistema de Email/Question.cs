using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoM2P3AndreCopelli
{
    public class Question : Email, IDisplayableEmail
    {
        public static int QuestionCount = 1;
        public bool WasAnswered { get; set; }
        public int QuestionId { get; set; }

        public Question()
        {
            QuestionId = QuestionCount++;
        }

        public static void SendQuestion()
        {
            Console.Clear();
            Question newQuestion = new Question();
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======--------- TROPTECH MAIL ---------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- BEM VINDO ALUNO --------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======------- Envie sua dúvida --------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("Digite aqui a sua dúvida:");
            newQuestion.Content = Console.ReadLine();
            newQuestion.WasAnswered = false;
            Email.QuestionList.Add(newQuestion);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Dúvida enviada com sucesso!");
            System.Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadKey();
            Program.StudentMenu();
        }

        public static void ShowQuestions()
        {
            Console.Clear();
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- Lista de Dúvidas -------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine(" ");
            if (QuestionList.Count > 0)
            {
                IEnumerable<Question> query = from Question in QuestionList orderby Question.QuestionId descending select Question;

                foreach (var item in query)
                {
                    System.Console.WriteLine(item.Show());
                }
            }
            else
            {
                System.Console.WriteLine("Nenhuma dúvida enviada.");
            }
            System.Console.WriteLine(" ");
        }

        public static void ShowQuestionsToTeacher()
        {
            Console.Clear();
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine("======-------- Lista de Dúvidas -------======");
            System.Console.WriteLine("======---------------------------------======");
            System.Console.WriteLine(" ");
            if (QuestionList.Count > 0)
            {
                IEnumerable<Question> query = from Question in QuestionList orderby Question.QuestionId descending select Question;

                foreach (var item in query)
                {
                    if (item.WasAnswered == false)
                    {
                        System.Console.WriteLine(item.Show());
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Nenhuma dúvida encontrada.");
            }
            System.Console.WriteLine(" ");
        }

        public string WriteAnswered()
        {
            if (WasAnswered)
            {
                return "Sim.";
            }

            return "Não.";
        }

        public string Show()
        {
            return $"============== Email de Dúvida ==============\n [Identificação da dúvida]: {QuestionId}\n [Pergunta]: {Content}\n [Respondida] {WriteAnswered()}";
        }

    }
}