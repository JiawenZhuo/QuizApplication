using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class Question
    {
        public Question()
        {
        }
        public int QuestionId { get; set; }
        public string QuestionHeading { get; set; }

        public int ChoicesId { get; set;}
    }
}

