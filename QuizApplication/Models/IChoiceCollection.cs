using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace QuizApplication.Models
{
    public interface IChoiceCollection
    {
        public IEnumerable<ChoiceCollection> GetAllCollection {get; }

    }
}
