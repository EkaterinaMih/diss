using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class QuestionBuilder
    {
        private int order_number = 0;
        public List<Answer> Answers { get; set; } = new List<Answer>();

        public void SetAnswer(string decription, double ljivost)
        {
            Answers.Add(new Answer() { Description = decription, Ljivost = ljivost });
        }

        public Question Build(string description)
        {
            var _question = new Question();

            _question.Answers = this.Answers;
            _question.OrderNumber = order_number;
            _question.description = description;

            order_number++;

            return _question;
        }
    }
}
