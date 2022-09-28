using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApplication.Models
{
    public class MockChoiceRepo
    {
 
        public static IEnumerable<Choice> firstChoicesList => new List<Choice>
            {
                new Choice{Body = "Venice", ChoiceId = 1, Title = "a", FacturalStatement = false },
                new Choice{Body="Rome",ChoiceId=2,Title="b", FacturalStatement=true},
                new Choice{Body="Naples",ChoiceId=3,Title="c", FacturalStatement=false},
                new Choice{Body="Milan",ChoiceId=4,Title="d", FacturalStatement=false},
            };

        public IEnumerable<ChoiceCollection> choiceCollections = new List<ChoiceCollection>
        {
           new ChoiceCollection{ChoiceCollectionId = 1,  QuestionId = 1},
           new ChoiceCollection{ChoiceCollectionId = 2,  QuestionId = 1}
        };

        public IEnumerable<Choice> GetChoicesByQuestionId => firstChoicesList;

    }
}

