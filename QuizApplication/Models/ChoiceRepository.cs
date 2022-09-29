using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Choice> GetChoicesById(int id)
        {
            List<Choice> choices = new List<Choice>();
            foreach (Choice c in _appDbContext.choices)
            {

                if (c.CollectionId == id)
                {
                    choices.Add(c);
                }
            }
            return choices;
        }

    }
}
