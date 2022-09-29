using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class MockQuestionRepo :IQuestionRepository
    {

        public IEnumerable<Question> AllQuestions =>
            new List<Question>
            {
                new Question{QuestionHeading="In which Italian city can you find the Colosseum", QuestionId=1, ChoicesId = 1},
                new Question{QuestionHeading="In the TV show New Girl, which actress plays Jessica Day?", QuestionId=2, ChoicesId = 2},
                new Question{QuestionHeading="What is the largest canyon in the world?", QuestionId=3, ChoicesId = 3},
                new Question{QuestionHeading="How long is the border between the United States and Canada?", QuestionId=4, ChoicesId = 4}
            };

        public IEnumerable<Question> GetQuestions { get; }

    }
}

