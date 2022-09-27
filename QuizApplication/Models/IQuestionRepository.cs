using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public interface IQuestionRepository
    {
       IEnumerable<Question> AllQuestions { get; }
    }
}

