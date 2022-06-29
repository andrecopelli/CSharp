using System.Collections.Generic;

namespace ProjetoM2P3AndreCopelli
{
    public class Email
    {
        private string _content;
        public static int IdNumber;
        public static int Counter = 1;
        public static List<Question> QuestionList = new List<Question>();
        public static List<Answer> AnswerList = new List<Answer>();
        public string Content { get =>_content; set => _content = value; }

        public Email()
        {
            IdNumber = Counter++;
        }
    }
}