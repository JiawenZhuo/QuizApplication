using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class MockQuestionRepo :IQuestionRepository
    {

        public IEnumerable<Question> AllQuestions =>
            new List<Question>
            {
                new Question{QuestionHeading="In which Italian city can you find the Colosseum?", QuestionId=1},
                new Question{QuestionHeading="In the TV show New Girl, which actress plays Jessica Day?", QuestionId=2}
            };

        public IEnumerable<Question> GetQuestions { get; }

    }
}

