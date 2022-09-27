using System;
using System.Collections.Generic;
using QuizApplication.Models;

namespace QuizApplication.Data
{

    public interface IQuestionData
    {
        IEnumerable<Question> GetAll();
    }
    public class QuestionData: IQuestionData
    {
        readonly List<Question> questionData;

        public QuestionData()
        {
            questionData = new List<Question>()
            {
                new Question { QuestionHeading = "In which Italian city can you find the Colosseum?", QuestionId = 1 },
                new Question { QuestionHeading = "In the TV show New Girl, which actress plays Jessica Day?", QuestionId = 2 },
            };
        }

        public IEnumerable<Question> GetAll()
        {
            throw new NotImplementedException();

        }
    }
}

