using System;
namespace QuizApplication.Models
{
    public class Choice
    {
        public Choice()
        {

        }
        public string Body{ get; set; }

        public int ChoiceId { get; set; }

        public string Title { get; set; }

        public bool FacturalStatement { get; set; }

        public void ReducedBodyField()
        {
            Body = "";
        }
    }
}

