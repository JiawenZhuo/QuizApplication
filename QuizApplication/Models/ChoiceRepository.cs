using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class ChoiceRepository : IChoiceRepository
    {
        private readonly AppDbContext _appDbContext;
        public ChoiceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Choice> GetChoices => _appDbContext.choices;

    }
}
