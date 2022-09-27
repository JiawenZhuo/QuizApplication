using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApplication.Models
{
    public class MockChoiceRepo: IChoiceRepository
    {
 
        public static IEnumerable<Choice> firstChoicesList => new List<Choice>
            {
                new Choice{Body = "Venice", ChoiceId = 1, Title = "a", FacturalStatement = false },
                new Choice{Body="Rome",ChoiceId=2,Title="b", FacturalStatement=true},
                new Choice{Body="Naples",ChoiceId=3,Title="c", FacturalStatement=false},
                new Choice{Body="Milan",ChoiceId=4,Title="d", FacturalStatement=false},
            };

        public IEnumerable<Choices> choiceCollection = new List<Choices>
        {
           new Choices{ChoicesId = 1, ChoicesOfQuestion = firstChoicesList, CurrentQuestionId = 1},
           new Choices{ChoicesId = 2, ChoicesOfQuestion = firstChoicesList, CurrentQuestionId = 1}
        };

        public IEnumerable<Choice> GetChoicesByQuestionId => firstChoicesList;

    }
}

