using QuizApplication.Models;
using System.Collections.Generic;

namespace QuizApplication.ViewModels
{
    public class NextQuestionViewModel
    {

        public IEnumerable<Choice> Choices { get; set; }

        public Question Current { get; set; }

        public Question RandomQuestion { get; set; }

        public IEnumerable<Choice> CurrentChoices { get; set; }

        public IEnumerable<Choice> GetChoicesById
        {
            get; set;
        }
    }
}
