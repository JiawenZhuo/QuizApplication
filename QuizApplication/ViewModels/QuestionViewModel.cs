using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using QuizApplication.Models;

namespace QuizApplication.ViewModels
{
    public class QuestionViewModel
    {
       
        public IEnumerable<Question> Questions { get; set; }

        public IEnumerable<Choice> Choices { get; set; }       

        public Question Current { get; set; }

        public string Heading { get; set; }
    }
}

