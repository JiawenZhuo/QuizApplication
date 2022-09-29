using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApplication.Models
{
    public class MockChoiceRepo : IChoiceRepository
    {
 
        public static IEnumerable<Choice> firstChoicesList => new List<Choice>
            {
                new Choice{Body = "Venice", ChoiceId = 1, Title = "a", FacturalStatement = false, CollectionId = 1  },
                new Choice{Body="Rome",ChoiceId=2,Title="b", FacturalStatement=true, CollectionId = 1 },
                new Choice{Body="Naples",ChoiceId=3,Title="c", FacturalStatement=false, CollectionId = 1 },
                new Choice{Body="Milan",ChoiceId=4,Title="d", FacturalStatement=false, CollectionId = 1 },

                new Choice{Body = "Zooey Deschanel", ChoiceId = 5, Title = "a", FacturalStatement = false, CollectionId = 2  },
                new Choice{Body="Kaley Cuoco",ChoiceId=6,Title="b", FacturalStatement=true, CollectionId = 2 },
                new Choice{Body="Jennifer Aniston",ChoiceId=7,Title="c", FacturalStatement=false, CollectionId = 2 },
                new Choice{Body="Alyson Hannigan",ChoiceId=8,Title="d", FacturalStatement=false, CollectionId = 2 },

                new Choice{Body = "Verdon Gorge, France", ChoiceId = 5, Title = "a", FacturalStatement = false, CollectionId = 3  },
                new Choice{Body="King’s Canyon, Australia",ChoiceId=6,Title="b", FacturalStatement=true, CollectionId = 3 },
                new Choice{Body="Grand Canyon, USA",ChoiceId=7,Title="c", FacturalStatement=false, CollectionId = 3 },
                new Choice{Body="Fjaðrárgljúfur Canyon, Iceland",ChoiceId=8,Title="d", FacturalStatement=false, CollectionId = 3 },


                new Choice{Body = "3,525 miles", ChoiceId = 5, Title = "a", FacturalStatement = false, CollectionId = 4  },
                new Choice{Body="4,525 miles",ChoiceId=6,Title="b", FacturalStatement=true, CollectionId = 4 },
                new Choice{Body="5,525 miles",ChoiceId=7,Title="c", FacturalStatement=false, CollectionId = 4 },
                new Choice{Body="6,525 miles",ChoiceId=8,Title="d", FacturalStatement=false, CollectionId = 4 },

            };

        public IEnumerable<ChoiceCollection> choiceCollections = new List<ChoiceCollection>
        {
           new ChoiceCollection{ChoiceCollectionId = 1,  QuestionId = 1},
           new ChoiceCollection{ChoiceCollectionId = 2,  QuestionId = 2}
        };

        public IEnumerable<Choice> GetChoicesByQuestionId => firstChoicesList;

        public IEnumerable<Choice> GetChoices => firstChoicesList;

        public IEnumerable<Choice> GetChoicesById(int id)
        {
            List<Choice> choices = new List<Choice>();
            foreach (Choice c in firstChoicesList)
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

