using System;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class QuestionRepository: IQuestionRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuestionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Question> AllQuestions => _appDbContext.questions;
    }
}

