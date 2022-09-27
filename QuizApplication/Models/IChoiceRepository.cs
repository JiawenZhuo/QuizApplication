using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public interface IChoiceRepository
    {

        IEnumerable<Choice> GetChoicesByQuestionId { get; }

    }
}

