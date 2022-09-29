using System.Collections.Generic;

namespace QuizApplication.Models
{
    public class ChoiceCollectionRepository : IChoiceCollection
    {
        private readonly AppDbContext _appDbContext;
        public ChoiceCollectionRepository(AppDbContext AppDbContext)
        {
            _appDbContext = AppDbContext;
        }

        public IEnumerable<ChoiceCollection> GetAllCollection => _appDbContext.choiceCollection;

    }
}
