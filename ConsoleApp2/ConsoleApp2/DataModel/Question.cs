using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Question
    {
        public int OrderNumber;
        public string description;
        public IEnumerable<Answer> Answers;
    }
}
