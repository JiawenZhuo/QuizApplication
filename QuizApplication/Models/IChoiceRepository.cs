using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public interface IChoiceRepository
    {

        IEnumerable<Choice> GetChoices { get; }

        public IEnumerable<Choice> GetChoicesById(int id);
    }
}

