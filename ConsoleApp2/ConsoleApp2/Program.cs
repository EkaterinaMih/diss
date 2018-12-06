using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var question_builder = GetQuestionBuilder();

            var solution = new Solution();

            solution.threshold = 3;
            solution.write = 0.1;

            solution.Questions.Add(question_builder.Build("1 вопрос"));
            solution.Questions.Add(question_builder.Build("2 вопрос"));
            solution.Questions.Add(question_builder.Build("3 вопрос"));



        }

        public static QuestionBuilder GetQuestionBuilder()
        {
            var question_builder = new QuestionBuilder();
            question_builder.SetAnswer("нет", 1);
            question_builder.SetAnswer("не знаю", 0.5);
            question_builder.SetAnswer("Да", 0);

            return question_builder;
        }
    }
}
