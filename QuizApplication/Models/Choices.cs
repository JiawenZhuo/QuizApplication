using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class Choices
    {
        public IEnumerable<Choice> ChoicesOfQuestion { get; set; }
        public int CurrentQuestionId { get; set; }
        public int ChoicesId { get; set; }
       
    }
}

