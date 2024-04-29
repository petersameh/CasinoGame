using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Question
    {
        public int Id { get; set; }
        public QuestionTypes.Category Category { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        public string SourceFile { get; set; }
    }
}
