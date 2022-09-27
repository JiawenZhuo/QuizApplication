using System;
using QuizApplication.Models;
using System.Collections.Generic;

namespace QuizApplication.ViewModels
{
    public class QuestionChoiceViewModel
    {

        public Question Question { get; set; }

        public Choice Choice { get; set; }
    }
}

